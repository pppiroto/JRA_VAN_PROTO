using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxJVDTLabLib;

namespace JRA_VAN_PROTO
{
    public partial class Form1 : Form
    {
        private AxJVLink jVLink = new AxJVDTLabLib.AxJVLink();
        private System.Resources.ResourceManager resources;

        public Form1()
        {
            resources = new System.Resources.ResourceManager(this.GetType());
            jVLink.Location = new System.Drawing.Point(0, 0);
            jVLink.Name = "jVLink";
            jVLink.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject($"{jVLink.Name}.OcxState");
            jVLink.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(jVLink);

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            jVLink.JVSetUIProperties();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var ret = jVLink.JVInit("UNKNOWN");
                Debug.WriteLine($"RET={ret}");
            } 
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
    }
}
