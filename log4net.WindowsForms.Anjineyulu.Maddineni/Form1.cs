using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Step 05
using log4net.Config;
[assembly: XmlConfigurator(Watch = true)]

namespace log4net.WindowsForms.Anjineyulu.Maddineni
{
    public partial class Form1 : Form
    {
        //Step 06
        ILog log = log4net.LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Step 07
            log.Info("button1_Click fired");
            try
            {
                object o2 = null;
                int i2 = (int)o2;   // Error
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            log.Info("button1_Click completed");
            label1.Text = "logs generated at C:\\Logs\\log4net.WindowsForms.Anjineyulu.Maddineni.log";
        }
    }
}
