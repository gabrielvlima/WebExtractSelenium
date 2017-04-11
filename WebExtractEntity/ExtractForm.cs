using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using WebExtractSelenium.Entidade;

namespace WebExtractEntity
{
    public partial class ExtractForm : Form
    {
        public const string siteSP = "http://www.legislacao.sp.gov.br"; // Site que disponibiliza a Legislação de São Paulo
        public const string siteRJ = "http://alerjln1.alerj.rj.gov.br"; // Site que disponibiliza a Legislação de Rio de Janeiro

        public ExtractForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que insere o ano atual no textbox_ano de cada pesquisa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtractForm_Load(object sender, EventArgs e)
        {
            tb_rjChromeAno.Text = DateTime.Now.Year.ToString();
            tb_spChromeAno.Text = DateTime.Now.Year.ToString();
            tb_rjPhantomAno.Text = DateTime.Now.Year.ToString();
            tb_spPhantomAno.Text = DateTime.Now.Year.ToString();
        }

        /// <summary>
        /// Click da pesquisa das leis de SP pelo Chrome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_spChrome_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (int.TryParse(tb_spChromeAno.Text, out ano))
            {
                PesquisaSP("Chrome", ano, false);
            }
        }

        /// <summary>
        /// Click da pesquisa das leis de RJ pelo Chrome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_rjChrome_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (int.TryParse(tb_spChromeAno.Text, out ano))
            {
                PesquisaRJ("Chrome", ano, false);
            }
        }

        /// <summary>
        /// Click da pesquisa das leis de SP pelo Phantom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_spPhantom_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (int.TryParse(tb_spChromeAno.Text, out ano))
            {
                PesquisaSP("Phantom", ano, false);
            }
        }

        /// <summary>
        /// Click da pesquisa das leis de RJ pelo Chrome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_rjPhantom_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (int.TryParse(tb_spChromeAno.Text, out ano))
            {
                PesquisaRJ("Phantom", ano, false);
            }
        }

        /// <summary>
        /// Método responsável pela pesquisa das leis do estado de Rio de Janeiro
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="ano"></param>
        /// <param name="hide"></param>
        private void PesquisaRJ(string webDriver, int ano, bool hide)
        {
            // Criação do IwebDriver
            IWebDriver driver;
            // Lista que armazenará os links dos documentos
            List<string> listaDocumentos = new List<string>();
            // Booleano para auxiliar nas pesqusias
            bool continuar = true;
            // Coleção de Matchs, armazenará o resultado das Expressões Regulares
            MatchCollection Documentos;
            // Lista contendo os dados das leis extraídas
            List<Lei> leis = new List<Lei>();

            // If para identificar qual webdriver será usado, Chrome ou Phantom
            if (webDriver.Equals("Chrome"))
            {
                var serviceC = ChromeDriverService.CreateDefaultService();
                serviceC.HideCommandPromptWindow = hide;
                driver = new ChromeDriver(serviceC);

            }
            else if (webDriver.Equals("Phantom"))
            {
                var serviceP = PhantomJSDriverService.CreateDefaultService();
                serviceP.HideCommandPromptWindow = hide;
                driver = new PhantomJSDriver(serviceP);

            }
            else
                return;

            // Iniciando o acesso ao site Legislativo
            driver.Navigate().GoToUrl("http://alerjln1.alerj.rj.gov.br/CONTLEI.NSF/LeiOrdAnoInt?OpenForm");
            // Busca do ano que será efetuada a pesquisa
            driver.FindElements(By.TagName("img")).FirstOrDefault(c => c.GetAttribute("alt").Contains(ano.ToString())).Click();

            // Do-While usado para percorrer todos os documentos do ano
            // Enquanto existir documento, ele continuará a paginação na busca de mais documentos
            do
            {
                // Armazena a lista de Matches com os documentos encontrados na página
                Documentos = Regex.Matches(driver.PageSource, @"href=\""(?<linkDoc>\/CONTLEI.NSF\/\S+?OpenDocument)\""", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                // Foreach percorrendo toda a lista de Matches e adicionando o link do documento no listaDocumentos
                foreach (Match doc in Documentos)
                {
                    listaDocumentos.Add(doc.Groups["linkDoc"].Value);
                }

                // Compara se terminou os documentos, caso contrário, vá para a outra página e continue a pesquisa.
                if (Documentos.Count == 0)
                    continuar = false;
                else
                    driver.FindElements(By.TagName("area")).FirstOrDefault(c => c.GetAttribute("coords").Equals("0,4,82,18")).Click();
            } while (continuar);

            // For para percorrer os documentos encontrados e adicionar na lista de Leis
            // o For está limitado a apenas 10 documentos, para que não demore ao nosso retorno, mas pode ser ...
            // ... limitado ao tamanho total das leis encontradas trocando o valor "10" por "listaDocumentos.Count"
            for (int i = 0; i < 10; i++)
            {
                // Istancia a entidade Lei
                Lei lei = new Lei();

                // Acessamos a url do documento
                driver.Navigate().GoToUrl(siteRJ + listaDocumentos[i]);

                // Criamos 3 variáveis para nos auxliar, um Match, um DateTime e um string, ele verificará o retorno do site e depois irá inserir na nossa entidade
                Match Titulo = Regex.Match(driver.PageSource, @">(?<titulo>Lei\s*n.\s*\d.*?de\s+(?<data>\d+\s+de\s*\S+\s*(de)?\s*\d+))\.?<", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                DateTime data = new DateTime();
                string texto = string.Empty;

                // Pegamos a data da lei e armazenamos na variável auxiliar "data"
                DateTime.TryParse(Titulo.Groups["data"].Value.Trim(), out data);

                // Pegamos o texto da lei, tratamos e armazenamos na variável auxiliar "texto"
                texto = Regex.Replace(driver.PageSource, @"<.*?>", "", RegexOptions.Compiled | RegexOptions.Singleline);
                texto = Regex.Match(texto, @"LEI\s*N.\s*\d.+", RegexOptions.Singleline).Value.Trim();

                // Inserimos os dados na nossa entidade
                lei.Titulo = Titulo.Groups["titulo"].Value.Trim();
                lei.Data = data;
                lei.Texto = texto;

                // Inserimos essa entidade na nossa lista de Leis
                leis.Add(lei);
            }

            // Quando finalizar a extração, fechamos o IWebDriver e exibimos nosso resultado na tela através do DataGridView
            driver.Quit();
            dataGridView1.DataSource = leis;
        }

        /// <summary>
        /// Método responsável pela pesquisa das leis do estado de São Paulo
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="ano"></param>
        /// <param name="hide"></param>
        public void PesquisaSP(string webDriver, int ano, bool hide)
        {
            // Criação do IwebDriver
            IWebDriver driver;
            // Lista que armazenará os links dos documentos
            List<string> listaDocumentos = new List<string>();
            // Booleano para auxiliar nas pesqusias
            bool continuar = true;
            // Coleção de Matchs, armazenará o resultado das Expressões Regulares
            MatchCollection Documentos;
            // Lista contendo os dados das leis extraídas
            List<Lei> leis = new List<Lei>();

            // If para identificar qual webdriver será usado, Chrome ou Phantom
            if (webDriver.Equals("Chrome"))
            {
                var serviceC = ChromeDriverService.CreateDefaultService();
                serviceC.HideCommandPromptWindow = hide;
                driver = new ChromeDriver(serviceC);

            }
            else if (webDriver.Equals("Phantom"))
            {
                var serviceP = PhantomJSDriverService.CreateDefaultService();
                serviceP.HideCommandPromptWindow = hide;
                driver = new PhantomJSDriver(serviceP);

            }
            else
                return;

            // Iniciando o acesso ao site Legislativo
            driver.Navigate().GoToUrl("http://www.legislacao.sp.gov.br/legislacao/dg280202.nsf/Leis?OpenView");

            // Busca do ano que será efetuada a pesquisa
            driver.FindElements(By.TagName("img")).FirstOrDefault(c => c.GetAttribute("alt").Contains(ano.ToString())).Click();

            // Do-While usado para percorrer todos os documentos do ano
            // Enquanto existir documento, ele continuará a paginação na busca de mais documentos
            do
            {
                // Armazena a lista de Matches com os documentos encontrados na página
                Documentos = Regex.Matches(driver.PageSource, @"href=\""(?<linkDoc>\/legislacao\/\S+?OpenDocument)\""", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                // Foreach percorrendo toda a lista de Matches e adicionando o link do documento no listaDocumentos
                foreach (Match doc in Documentos)
                {
                    listaDocumentos.Add(doc.Groups["linkDoc"].Value);
                }

                // Compara se terminou os documentos, caso contrário, vá para a outra página e continue a pesquisa.
                if (Documentos.Count == 0)
                    continuar = false;
                else
                    driver.FindElement(By.Id("RetângulodePontodeAcesso41")).Click();
            } while (continuar);

            // For para percorrer os documentos encontrados e adicionar na lista de Leis
            // o For está limitado a apenas 10 documentos, para que não demore ao nosso retorno, mas pode ser ...
            // ... limitado ao tamanho total das leis encontradas trocando o valor "10" por "listaDocumentos.Count"
            for (int i = 0; i < 10; i++)
            {
                // Istancia a entidade Lei
                Lei lei = new Lei();

                driver.Navigate().GoToUrl(siteSP + listaDocumentos[i]);

                // Criamos 3 variáveis para nos auxliar, um Match, um DateTime e um string, ele verificará o retorno do site e depois irá inserir na nossa entidade
                Match Titulo = Regex.Match(driver.PageSource, @">(?<titulo>Lei\s*n.\s*\d.*?de\s+(?<data>\d+\s+de\s*\S+\s*de\s*\d+))<", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                DateTime data = new DateTime();
                string texto = string.Empty;

                // Pegamos a data da lei e armazenamos na variável auxiliar "data"
                DateTime.TryParse(Titulo.Groups["data"].Value.Trim(), out data);

                // Pegamos o texto da lei, tratamos e armazenamos na variável auxiliar "texto"
                texto = Regex.Replace(driver.PageSource, @"<.*?>", "", RegexOptions.Compiled | RegexOptions.Singleline);
                texto = Regex.Match(texto, @"(?<texto>GOVERNO\s+DO\s+ESTADO.+?)\d+\.doc\s*$", RegexOptions.Singleline | RegexOptions.Multiline).Groups["texto"].Value.Trim();

                // Inserimos os dados na nossa entidade
                lei.Titulo = Titulo.Groups["titulo"].Value.Trim();
                lei.Data = data;
                lei.Texto = texto;

                // Inserimos essa entidade na nossa lista de Leis
                leis.Add(lei);
            }

            // Quando finalizar a extração, fechamos o IWebDriver e exibimos nosso resultado na tela através do DataGridView
            driver.Quit();
            dataGridView1.DataSource = leis;
        }

    }
}
