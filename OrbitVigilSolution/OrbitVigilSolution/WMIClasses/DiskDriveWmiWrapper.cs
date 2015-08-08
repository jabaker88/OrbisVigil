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

    /// <summary>
    /// Sealed Class that provides Disk Properties for the ManagementObject class
    /// </summary>
    public sealed class WmiDiskProperties
    {
        /// <summary>
        /// Use the ToString() Method to get the actual name 
        /// </summary>
        public enum DiskProperty
	    {
	        Availability,
            BytesPerSector,
            Capabilities,
            CapabilityDescriptions,
            Caption,
            CompressionMethod,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            DefaultBlockSize,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            ErrorMethodology,
            FirmwareRevision,
            Index,
            InstallDate,
            InterfaceType,
            LastErrorCode,
            Manufacturer,
            MaxBlockSize,
            MaxMediaSize,
            MediaLoaded,
            MediaType,
            MinBlockSize,
            Model,
            Name,
            NeedsCleaning,
            NumberOfMediaSupported,
            Partitions,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            SCSIBus,
            SCSILogicalUnit,
            SCSIPort,
            SCSITargetId,
            SectorsPerTrack,
            SerialNumber,
            Signature,
            Size,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TotalCylinders,
            TotalHeads,
            TotalSectors,
            TotalTracks,
            TracksPerCylinder
	    }

    }
}
