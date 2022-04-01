using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cukraszda
{

    public partial class Form2 : Form
    {

        private List<Sutemeny> sutik;

        private List<CheckBox> cbList;
        private List<TextBox> tbList;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void ListaBetolt(List<Sutemeny> lista)
        {
            sutik = lista;
            cbList = new List<CheckBox>();
            tbList = new List<TextBox>();

            tableLayoutPanel1.RowCount = sutik.Count;

            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
            

            for (int i = 0; i < sutik.Count; i++)
            {
               

                CheckBox cb = new CheckBox();
                cb.TextAlign = ContentAlignment.MiddleRight;
                tableLayoutPanel1.Controls.Add(cb, 0, i);
                cbList.Add(cb);

                Label nevLabel = new Label();
                nevLabel.Text = $"{sutik[i].nev}({sutik[i].ar} Ft)";
                nevLabel.TextAlign = ContentAlignment.MiddleLeft;
                nevLabel.AutoSize = true;
                tableLayoutPanel1.Controls.Add(nevLabel, 1, i);

                TextBox tb = new TextBox();
                tb.TextAlign = HorizontalAlignment.Right;
                tableLayoutPanel1.Controls.Add(tb, 2, i);
                tbList.Add(tb);

                Label adagLabel = new Label();
                adagLabel.Text = "adag";
                adagLabel.TextAlign = ContentAlignment.MiddleLeft;
                tableLayoutPanel1.Controls.Add(adagLabel, 3, i);


            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kimenet = "";

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                if (cbList[i].Checked && int.TryParse(tbList[i].Text, out int adag))
                {
                    kimenet += $"{adag}db {sutik[i].nev}({sutik[i].ar} Ft): {adag * sutik[i].ar} Ft\n";
                }
            }
            Debug.WriteLine(kimenet);

            string[,] asd = new string[5, 6];
            Debug.WriteLine(asd.GetLength(0));
        }
    }
}
