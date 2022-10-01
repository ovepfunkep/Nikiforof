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
using static UsingDLLOnWF.Dll1ExportedFunctions;

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
            CBChooseFun.Items.Add("Count lines in file");
            CBChooseFun.SelectedIndex = 0;
            CBLanguage.SelectedIndex = 0;
            CBPlace.SelectedIndex = 1;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            mainPath = CBPlace.SelectedItem.ToString() == "VKI" ? VKIDir : HomeDir;
            mainPath += CBLanguage.SelectedItem.ToString() == "C++" ? pathToDLLC : pathToDLLLaz;

            switch (CBChooseFun.SelectedItem.ToString())
            {
                case "Addition":
                    Addition additionForm = new Addition(this);
                    this.Hide();
                    additionForm.ShowDialog();
                    break;
                case "Count lines in file":
                    ReadTextFile readTextFile = new ReadTextFile(this);
                    this.Hide();
                    readTextFile.ShowDialog();
                    break;
            }
        }
    }
}
