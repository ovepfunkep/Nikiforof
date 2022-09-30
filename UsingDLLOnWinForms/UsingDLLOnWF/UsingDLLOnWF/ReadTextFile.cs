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

        private void BtnFindCount_Click(object sender, EventArgs e)
        {
            if (File.Exists(TBFilePath.Text))
            {
                ReadTextFileC readTextFile = (ReadTextFileC)InitFromLibrary(mainPath, "ReadTextFileC", typeof(ReadTextFileC));
                BtnFindCount.Text = readTextFile(TBFilePath.Text).ToString();
            }
        }

        private void ReadTextFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormParent.Show();
        }
    }
}
