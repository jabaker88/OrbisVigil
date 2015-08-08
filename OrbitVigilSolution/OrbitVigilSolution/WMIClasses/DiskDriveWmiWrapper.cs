using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace OrbitVigilSolution.WMIClasses
{
    /// <summary>
    /// Utility Class that provies queries to WMI for Disk Drive Information
    /// </summary>
    public static class DiskDriveWmiWrapper
    {
        /// <summary>
        /// Gathers Disk Information from a WMI
        /// </summary>
        /// <returns>Returns a ManagementObjectSearcher Query</returns>
        public static ManagementObjectCollection GetDisks()
        {
            return new ManagementObjectSearcher("Select * FROM Win32_DiskDrive").Get();
        }
    }
}
