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
using System.Diagnostics;

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
            GetDiskEvents();
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

        private void GetDiskEvents()
        {
            EventLog[] evtLogs = EventLog.GetEventLogs();
            //Iterate over all event logs
            foreach (EventLog evt in evtLogs)
            {
                EventLogEntryCollection evtCollection = evt.Entries;
                try
                {
                    //Iterate over each entry
                    foreach (EventLogEntry entry in evtCollection)
                    {
                        //If a disk error has occured, display
                        if (entry.Source.ToString().ToLower() == "disk")
                        {
                            eventsListBox.Items.Add(entry.Message); //Log disk event
                            try
                            {
                                //On Bad block logic
                                if (entry.Message.ToLower().Contains("bad block"))
                                {
                                    //On Bad Blocks, throw exception
                                    throw new EventLogClasses.HardDriveEventBadBlockException("Bad Block Detected on: " + entry.Message);
                                }
                            }
                            catch (EventLogClasses.HardDriveEventBadBlockException ex)
                            {
                                OutputConsole.Text += ex.Message + Environment.NewLine;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}