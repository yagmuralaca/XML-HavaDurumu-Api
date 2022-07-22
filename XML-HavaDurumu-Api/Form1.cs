using System.Xml.Linq;

namespace XML_HavaDurumu_Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            string connection = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

            // xml dosyalarýný cekmeye, kullanmaya,islemeye yarar
            XDocument weather = XDocument.Load(connection);



            var ili = weather.Descendants("ili").ElementAt(0).Value;
            var durum = weather.Descendants("Durum").ElementAt(1).Value;
            var sicaklik = weather.Descendants("Mak").ElementAt(2).Value;

            DataGridViewRow row = (DataGridViewRow)dg_havaDurumu.Rows[0].Clone();

            row.Cells[0].Value = ili;
            row.Cells[1].Value = durum;
            row.Cells[2].Value = sicaklik;
            
            dg_havaDurumu.Rows.Add(row);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}