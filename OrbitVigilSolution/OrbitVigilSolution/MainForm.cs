using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrbitVigilSolution.WMIClasses;
using System.Management;

namespace OrbitVigilSolution
{
    public partial class OrbisVigilMainForm : Form
    {
        public OrbisVigilMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On Main Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrbisVigilMainForm_Load(object sender, EventArgs e)
        {
            GetDiskConsoleOutput();
        }


        //Class Methods
        /// <summary>
        /// Outputs disk information to console
        /// </summary>
        private void GetDiskConsoleOutput()
        {
            //Gather disk information and output to console
            var disks = DiskDriveWmiWrapper.GetDisks();
            foreach (ManagementObject disk in disks)
            {
                OutputConsole.Text += disk[WmiDiskProperties.DiskProperty.Model.ToString()] + Environment.NewLine;

                foreach (var prop in Enum.GetValues(typeof(WmiDiskProperties.DiskProperty)))
                {
                    try
                    {
                        OutputConsole.Text += prop.ToString() + ": " + disk[prop.ToString()] + Environment.NewLine;
                    }
                    catch
                    {
                        //Ignore; attribute not supported or initlized
                    }
                }

                OutputConsole.Text += Environment.NewLine + Environment.NewLine;
            }
        }
    }
}