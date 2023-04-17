using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteApiDesktop
{
    public partial class DevolucaoPage : Form
    {
        public DevolucaoPage()
        {
            InitializeComponent();
        }

        private static string _urlbase;
        private static List<DevolucaoDTO> _list;
        private static AccessToken accessToken;

        // Efetuando Login na API ao carregar a página
        private void DevolucaoPage_Load(object sender, EventArgs e)
        {
            _urlbase = ConfigurationManager.AppSettings["UrlBase"];
            var email = ConfigurationManager.AppSettings["UserID"];
            var password = ConfigurationManager.AppSettings["AccessKey"];


            var urlbase = _urlbase + "Autoriza/login";

            using (var client = new HttpClient())
            {
                string conteudo = "";

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage respToken =
                     client.PostAsync(urlbase, new StringContent(
                         JsonConvert.SerializeObject(new
                         {
                             email,
                             password,
                         }), Encoding.UTF8, "application/json")).Result;

                try
                {
                    conteudo = respToken.Content.ReadAsStringAsync().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw ex;
                }

                if (respToken.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    accessToken = JsonConvert.DeserializeObject<AccessToken>(conteudo);
                    Console.WriteLine(accessToken);

                    if (accessToken.Authenticated)
                    {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken.Token);
                    }
                    else
                    {
                        MessageBox.Show("Falha na autenticação");
                    }
                }
            }
        }

        private async void btn_pesquisarDevolucao15dias_Click(object sender, EventArgs e)
        {
            try
            {
                _list = new List<DevolucaoDTO>();

                var acessaApi = new AccessApiService();

                MessageBox.Show("Importando Devoluções", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<DevolucaoDTO> devolucoes = await acessaApi.Devolucao15dias(accessToken);
                _list = devolucoes;

                List<DevolucaoRender> devolucoesRender = new List<DevolucaoRender>();
                foreach(DevolucaoDTO dev in devolucoes)
                {
                    foreach(NfDevolucaoDTO nfdev in dev.Devolucoes)
                    {
                        foreach(ProdutoDevolucaoDTO prodDev in nfdev.Produtos)
                        {
                            DevolucaoRender devRender = new DevolucaoRender()
                            {
                                Loja = dev.Loja.Nome,
                                Cnpj = dev.Loja.Cnpj,
                                Nf= nfdev.Nf,
                                Emissao= nfdev.Emissao,
                                Ean= prodDev.Ean,
                                Cod_Fornecedor= prodDev.Cod_Fornecedor,
                                Descricao= prodDev.Descricao,
                                Quantidade= prodDev.Quantidade, 
                                Valor= prodDev.Valor,
                            };

                            devolucoesRender.Add(devRender);
                        }
                    }
                }

                dgv_devolucoes.DataSource = devolucoesRender;
                dgv_devolucoes.AutoResizeColumns();

                MessageBox.Show("Devoluções Importadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btn_gerarcsv_Click(object sender, EventArgs e)
        {

        }

        private void btn_geratxt_Click(object sender, EventArgs e)
        {

        }
    }
}
