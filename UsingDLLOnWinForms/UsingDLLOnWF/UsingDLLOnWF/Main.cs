using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDLLOnWF
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FillFunctionsVariety();
        }

        private void FillFunctionsVariety()
        {
            CBChooseFun.Items.Add("Addition");
            CBChooseFun.Items.Add("Read .tsv file");
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            switch (CBChooseFun.SelectedIndex)
            {
                case 0:
                    Addition addition = new Addition(this);
                    addition.Show();
                    this.Hide();
                    break;
                case 1:
                    ReadTextFile rdtxtfile = new ReadTextFile(this);
                    rdtxtfile.Show();
                    this.Hide();
                    break;
            }
        }

        private List<string> FunctionsImported = new List<string> { };

        private void CBChooseFun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FunctionsImported.Contains(CBChooseFun.SelectedItem.ToString()))
            {
                switch (CBChooseFun.SelectedItem.ToString()) 
                {
                    case "Addition":
                        break;
                    case "Read .tsv file":
                        break;
                }
                FunctionsImported.Add(CBChooseFun.SelectedItem.ToString());
                BtnGo.Enabled = true;
            }
        }
    }
}
