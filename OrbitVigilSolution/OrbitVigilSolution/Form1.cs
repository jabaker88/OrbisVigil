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
            //Remove this 
            var disks = DiskDriveWmiWrapper.GetDisks();
            string tempOutput;
            foreach (ManagementObject disk in disks)
            {
                tempOutput += disk["Model"].ToString() + ",";
            }
        }
    }
}
