using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static UsingDLLOnWF.Dll1ExportedFunctions;

namespace UsingDLLOnWF
{
    public partial class ReadTextFile : Form
    {
        public ReadTextFile(Form form)
        {
            InitializeComponent();
            FormParent = form;
        }

        Form FormParent;
        Dll1ExportedFunctions.ReadTextFile readTextFile = (Dll1ExportedFunctions.ReadTextFile)InitFromLibrary(mainPath, "ReadTextFile", typeof(Dll1ExportedFunctions.ReadTextFile));

        private void BtnFindCount_Click(object sender, EventArgs e)
        {
            BtnFindCount.Text = readTextFile(TBFilePath.Text.ToString(), out string Text, out int CountLines).ToString();
        }

        private void ReadTextFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormParent.Show();
        }
    }
}
