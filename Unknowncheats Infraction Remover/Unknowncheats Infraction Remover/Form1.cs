using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unknowncheats_Infraction_Remover
{
    public partial class UIRForm : Form
    {
        public UIRForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // don't do shit in here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalUtilities.HandleBrowser handleBrowser = new LocalUtilities.HandleBrowser();
            handleBrowser.GetRightBrowser();
            if (handleBrowser.GetDriver() != null)
            {
                //handleBrowser.InjectAndExcecute(handleBrowser.script);
                System.Windows.Forms.MessageBox.Show("Success!");
            }
            else System.Windows.Forms.MessageBox.Show("No supported browser was found");

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // do gay shit on loading (open random browsers to troll 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // idfk what the fuck this is doing here
        }
    }
}
