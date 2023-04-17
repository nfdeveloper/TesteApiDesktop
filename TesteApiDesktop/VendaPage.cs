using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace TesteApiDesktop
{
    public partial class VendaPage : Form
    {
        public VendaPage()
        {
            InitializeComponent();
        }

        private static string _urlbase;
        private static List<Venda> _list;
        private static AccessToken accessToken;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Pesquisa de Vendas com Datas do Input
        private async void Pesquisar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txt_dataFinal.Text);
            if (txt_dataFinal.Text == "  -  -    " || txt_dataInicio.Text == "  -  -    ")
            {
                MessageBox.Show
                    ("Campos de Data não podem estar vazios.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            DateTime dataInicio_check = DateTime.Parse(txt_dataInicio.Text);
            DateTime dataFinal_check = DateTime.Parse(txt_dataFinal.Text);


            if(dataInicio_check > dataFinal_check)
            {
                MessageBox.Show
                    ("A Data Inicial não pode ser maior que a data Final", 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            if (dataInicio_check.Year < 2022)
            {
                MessageBox.Show
                    ("A Data Inicial não pode ser menor que 01-01-2022",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (dataFinal_check.Day - dataInicio_check.Day > 31)
            {
                MessageBox.Show
                    ("A diferença entre as datas não pode ser maior que 31 dias",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var acessaApi = new AccessApiService();

            MessageBox.Show("Importando Venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Venda> vendas = await acessaApi.GetVendaPorData(accessToken, txt_dataInicio.Text, txt_dataFinal.Text);
            _list = vendas;
            dgv_vendas.DataSource = vendas;
            dgv_vendas.AutoResizeColumns();

            MessageBox.Show("Venda Importadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private async void VendaPage_Load(object sender, EventArgs e)
        {
            _urlbase = ConfigurationManager.AppSettings["UrlBase"];
            var email = ConfigurationManager.AppSettings["UserID"];
            var password = ConfigurationManager.AppSettings["AccessKey"];


            var urlbase = _urlbase + "Autoriza/login";

            using(var client = new HttpClient())
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

                if(respToken.StatusCode == System.Net.HttpStatusCode.OK)
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

            //try
            //{
            //    var acessaApi = new AccessApiService();
            //    List<Venda> vendas = await acessaApi.GetVendaDiaAnterior(accessToken);
            //    _list = vendas;
            //    dgv_vendas.DataSource = vendas;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro : " + ex.Message);
            //}


        }

        private async void btn_pesquisarVendaDiaAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                _list = new List<Venda>();

                var acessaApi = new AccessApiService();

                MessageBox.Show("Importando Venda","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Venda> vendas = await acessaApi.GetVendaDiaAnterior(accessToken);
                _list = vendas;
                dgv_vendas.DataSource = vendas;
                dgv_vendas.AutoResizeColumns();

                MessageBox.Show("Venda Importadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_list is null)
            {
                MessageBox.Show("É necessário executar uma pesquisa antes da Criação do arquivo.");
            }
            else
            {
                string dataFile = "";
                string data1 = _list.OrderBy(d => d.Data_Venda).First().Data_Venda.Replace(@"/", "");
                string data2 = _list.OrderByDescending(d => d.Data_Venda).First().Data_Venda.Replace(@"/", "");

                if (data1.Equals(data2))
                {
                    dataFile = data1;
                }
                else
                {
                    dataFile = data1 + " - " + data2;
                }

                string path = @"C:\\venda" + dataFile + ".txt";

                StreamWriter x = new StreamWriter(path, true, Encoding.ASCII);

                foreach(Venda v in _list)
                {
                    x.WriteLine(v.Cnpj + ";" + v.Data_Venda + ";" + v.Cod_Produto + ";" + v.Descricao_Produto + ";" + v.Quantidade_Vendida + ";" + v.Valor_Vendido);
                }

                x.Close();

                MessageBox.Show("Arquivo Criado no caminho: "+ path);
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_list is null)
            {
                MessageBox.Show("É necessário executar uma pesquisa antes da Criação do arquivo.");
            }
            else
            {
                string dataFile = "";
                string data1 = _list.OrderBy(d => d.Data_Venda).First().Data_Venda;
                string data2 = _list.OrderByDescending(d => d.Data_Venda).First().Data_Venda;
                string dataExcel = "";

                if (data1.Equals(data2))
                {
                    dataFile = data1.Replace(@"/", "");
                    dataExcel = data1;
                }
                else
                {
                    dataFile = data1.Replace(@"/", "") + " - " + data2.Replace(@"/", "");
                    dataExcel = data1 + " - " + data2;
                }

                string path = @"C:\\venda" + dataFile + ".xlsx";

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();

                var worksheet = excel.Workbook.Worksheets.Add("PlanilhaVendas");

                worksheet.TabColor = System.Drawing.Color.Black;
                worksheet.DefaultRowHeight = 12;

                // ################################################################ //
                //  TÍTULO

                worksheet.Cells["A1:G3"].Merge = true;
                worksheet.Cells[1, 1].Value = "Venda Cometa Supermercados " + dataExcel;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                worksheet.Cells[1, 1].Style.Font.Size = 15;
                worksheet.Cells[1,1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d3d3d3"));

                // ############################################################### //
                // CABEÇALHO

                worksheet.Cells[4, 1].Value = "LOJA";
                worksheet.Cells[4, 1].Style.Font.Size = 13;
                worksheet.Cells[4, 2].Value = "DATA";
                worksheet.Cells[4, 2].Style.Font.Size = 13;
                worksheet.Cells[4, 3].Value = "CNPJ";
                worksheet.Cells[4, 3].Style.Font.Size = 13;
                worksheet.Cells[4, 4].Value = "COD_PRODUTO";
                worksheet.Cells[4, 4].Style.Font.Size = 13;
                worksheet.Cells[4, 5].Value = "DESCRIÇÃO";
                worksheet.Cells[4, 5].Style.Font.Size = 13;
                worksheet.Cells[4, 6].Value = "QTD_VENDIDA";
                worksheet.Cells[4, 6].Style.Font.Size = 13;
                worksheet.Cells[4, 7].Value = "VLR_VENDIDA";
                worksheet.Cells[4, 7].Style.Font.Size = 13;

                // ############################################################# //

                int indice = 5;

                foreach(Venda venda in _list)
                {
                    worksheet.Cells[indice, 1].Value = venda.Loja;
                    worksheet.Cells[indice, 2].Value = venda.Data_Venda;
                    worksheet.Cells[indice, 3].Value = venda.Cnpj;
                    worksheet.Cells[indice, 4].Value = venda.Cod_Produto;
                    worksheet.Cells[indice, 5].Value = venda.Descricao_Produto;
                    worksheet.Cells[indice, 6].Value = venda.Quantidade_Vendida;
                    worksheet.Cells[indice, 7].Value = venda.Valor_Vendido;
                    indice++;
                }

                // ############################################################# //
                // ALINHANDO AS COLUNAS

                worksheet.Column(1).AutoFit();
                worksheet.Column(2).AutoFit();
                worksheet.Column(3).AutoFit();
                worksheet.Column(4).AutoFit();
                worksheet.Column(5).AutoFit();
                worksheet.Column(6).AutoFit();
                worksheet.Column(7).AutoFit();

                if(System.IO.File.Exists(path))
                    System.IO.File.Delete(path);

                FileStream objFileStrm = System.IO.File.Create(path);
                objFileStrm.Close();

                System.IO.File.WriteAllBytes(path, excel.GetAsByteArray());

                excel.Dispose();

                MessageBox.Show("Arquivo Criado no caminho: " + path);
            }
        }

        private void txt_dataInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
