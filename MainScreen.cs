using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    public partial class MainScreen : Form
    {
        public string username;
        public string rubroid;
        public MainScreen()
        {
            InitializeComponent();
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].LabelFormat = "P";
            //chart1.Series["Series1"].Points[0]["Exploded"] = "true";
            //chart1.Series["Series1"].Points[1]["Exploded"] = "true";
            //chart1.Series["Series1"].Points[2]["Exploded"] = "true";
            //chart1.Series["Series1"].Points[3]["Exploded"] = "true";
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            List<RubroData.Rubro> rubros = RubroData.GetRubros();

            var getRubroByUser = rubros.Where(r => r.rubroid == rubroid).ToList();

            int tIndex = 1;
            foreach(var r in getRubroByUser)
            {
                string pathImage = Application.StartupPath + r.imagen;
                if (tIndex == 1)
                {
                    tabPage1.Text = r.rubroCategoria;
                    richTextBox1.Text = r.description;
                    if (File.Exists(pathImage))
                    {
                        pictureBox1.Load(pathImage);
                    }
                }

                if (tIndex == 2)
                {
                    tabPage2.Text = r.rubroCategoria;
                    richTextBox2.Text = r.description;
                    
                    if (File.Exists(pathImage))
                    {
                        pictureBox2.Load(pathImage);
                    }
                }

                if (tIndex == 3)
                {
                    tabPage3.Text = r.rubroCategoria;
                    richTextBox3.Text = r.description;

                    if (File.Exists(pathImage))
                    {
                        pictureBox3.Load(pathImage);
                    }
                }

                chart1.Series["Series1"].Points.AddXY(r.rubroCategoria, r.porcentaje);
                //chart1.Series["Series1"].Points[tIndex]["Exploded"] = "true";

                tIndex++;
            }
        }
    }
}
