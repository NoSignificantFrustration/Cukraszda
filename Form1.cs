using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cukraszda
{

    

    public partial class Form1 : Form
    {

        public List<Sutemeny> sutik { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                sutik = new List<Sutemeny>();
                while (!sr.EndOfStream)
                {
                    sutik.Add(new Sutemeny(sr.ReadLine()));
                    
                }


                Debug.WriteLine(sutik.Count);
                menuStrip1.Items[1].Enabled = true;
                //süteményekToolStripMenuItem_Click(this, null);

            }

            
        }

        private void süteményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ListaBetolt(sutik);
            f2.Show();
        }
    }
}
