using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Launcher
{
  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
        }

        private void epic_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Epic Games\Launcher\Engine\Binaries\Win64\UnrealEngineLauncher.exe");
        }

        private void ea_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Electronic Arts\EA Desktop\EA Desktop\EADesktop.exe");
        }
    }
}