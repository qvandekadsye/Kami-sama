using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Kami_sama
{
    public partial class Kami : Form
    {
        public Kami()
        {
            InitializeComponent();
        }

        private void buttonGodMode_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selectionnez où mettre le god mode";
            fbd.ShowNewFolderButton = false;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                String path = Path.Combine(fbd.SelectedPath, "GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}");
                Directory.CreateDirectory(path);
                MessageBox.Show("Panneau God Mode crée","Opération terminée");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkQVDK.Text);
        }
    }
}
