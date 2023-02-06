using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class Form1 : Form
    {
        

        #region User Defined variables 

        // We use these constants to convert bytes to megabytes and gigabytes 
        // note these are binary sizes
        const double BytesInMB = 1048576;
        const double BytesInGB = 1073741824;

        #endregion


        #region user defined methods 

        public void basicDriveDetails()
        {

            var driveQuery = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            foreach (ManagementObject i in driveQuery.Get())
            {

                var partitionQueryText = string.Format("associators of {{{0}}} where AssocClass = Win32_DiskDriveToDiskPartition", i.Path.RelativePath);
                var partitionQuery = new ManagementObjectSearcher(partitionQueryText);
                foreach (ManagementObject p in partitionQuery.Get())
                {
                    //Console.WriteLine("Partition");
                    //Console.WriteLine(p);
                    var logicalDriveQueryText = string.Format("associators of {{{0}}} where AssocClass = Win32_LogicalDiskToPartition", p.Path.RelativePath);
                    var logicalDriveQuery = new ManagementObjectSearcher(logicalDriveQueryText);
                    foreach (ManagementObject ld in logicalDriveQuery.Get())
                    {

                       

                        var physicalName = Convert.ToString(i.Properties["Name"].Value); // \\.\PHYSICALDRIVE2
                        var diskName = Convert.ToString(i.Properties["Caption"].Value); // WDC WD5001AALS-xxxxxx
                        var diskModel = Convert.ToString(i.Properties["Model"].Value); // WDC WD5001AALS-xxxxxx
                        var volumeSerial = Convert.ToString(ld.Properties["VolumeSerialNumber"].Value); // 12345678
                        var driveName = Convert.ToString(ld.Properties["Name"].Value); // C:
                        var driveId = Convert.ToString(ld.Properties["DeviceId"].Value); // C:
                        var fileSystem = Convert.ToString(ld.Properties["FileSystem"].Value); // NTFS
                        var freeSpace = Convert.ToUInt64(ld.Properties["FreeSpace"].Value); // in bytes
                        var totalSpace = Convert.ToUInt64(ld.Properties["Size"].Value); // in bytes
                        var volumeName = Convert.ToString(ld.Properties["VolumeName"].Value); // System

                       

                        string[] driveDETAILS = new string[] {driveName, freeSpace.ToString(), totalSpace.ToString(), physicalName,fileSystem, diskName,diskModel,volumeSerial };
                        ListViewItem Drdet = new ListViewItem(driveDETAILS);
                        listView1.Items.Add(Drdet);





                        //    Console.WriteLine("PhysicalName: {0}", physicalName);
                        //    Console.WriteLine("DiskName: {0}", diskName);
                        //    Console.WriteLine("DiskModel: {0}", diskModel);
                        //    Console.WriteLine("VolumeSerial: {0}", volumeSerial);

                        //    Console.WriteLine("DriveName: {0}", driveName);
                        //    Console.WriteLine("DriveId: {0}", driveId);
                        //    Console.WriteLine("FileSystem: {0}", fileSystem);
                        //    Console.WriteLine("FreeSpace: {0} GB", freeSpace / BytesInGB);
                        //    Console.WriteLine("TotalSpace: {0}", totalSpace);

                        //    //                  Console.WriteLine("VolumeName: {0}", volumeName);

                        //    Console.WriteLine(new string('-', 79));
                        //}



                    }
                }
            }
        }
    
        public void SectorsClusters()
        {
            // listView1.Items.Clear();

            DriveInfo[] allDrives = DriveInfo.GetDrives();



            foreach (DriveInfo d in allDrives)
            {

                if (d.IsReady == true)
                {
                    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
                    [return: MarshalAs(UnmanagedType.Bool)]
                    static extern bool GetDiskFreeSpace(string lpRootPathName,
                        out ulong lpSectorsPerCluster,
                        out ulong lpBytesPerSector,
                        out ulong lpNumberOfFreeClusters,
                        out ulong lpTotalNumberOfClusters);

                    ulong SectorsPerCluster;
                    ulong BytesPerSector;
                    ulong NumberOfFreeClusters;
                    ulong TotalNumberOfClusters;

                    GetDiskFreeSpace(d.Name,
                        out SectorsPerCluster,
                        out BytesPerSector,
                        out NumberOfFreeClusters,
                        out TotalNumberOfClusters);
                    var ClusterSize = SectorsPerCluster * BytesPerSector;

                    string[] driveDETAILS = new string[] { d.Name, d.DriveType.ToString(),d.DriveFormat,SectorsPerCluster.ToString(),BytesPerSector.ToString(), NumberOfFreeClusters.ToString(), TotalNumberOfClusters.ToString(),ClusterSize.ToString() };
                    ListViewItem Drdet = new ListViewItem(driveDETAILS);
                    listView2.Items.Add(Drdet);


                    //Console.WriteLine("Sector per cluster      : {0}", SectorsPerCluster);

                    //Console.WriteLine("bytes per sector        : {0}", BytesPerSector);
                    //Console.WriteLine("number of free cluster  : {0}", NumberOfFreeClusters);
                    //Console.WriteLine("total number of clusers : {0}", TotalNumberOfClusters);
                    //Console.WriteLine("Cluster size :   {0} ", ClusterSize);
                }
            }
        }
    




        #endregion

        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView2.View = View.Details;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basicDriveDetails();
            listView2.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SectorsClusters();
           // listView2.View = View.Details;
            button1.Enabled = false;
            listView2.Visible = true;
        }
      

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
