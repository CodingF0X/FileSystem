
namespace FileSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.DriveName = new System.Windows.Forms.ColumnHeader();
            this.FreeSpace = new System.Windows.Forms.ColumnHeader();
            this.TotalSpace = new System.Windows.Forms.ColumnHeader();
            this.Physicalname = new System.Windows.Forms.ColumnHeader();
            this.FileSystem = new System.Windows.Forms.ColumnHeader();
            this.DiskName = new System.Windows.Forms.ColumnHeader();
            this.DiskModel = new System.Windows.Forms.ColumnHeader();
            this.VolumeSerial = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Drive = new System.Windows.Forms.ColumnHeader();
            this.DriveType = new System.Windows.Forms.ColumnHeader();
            this.DriveFormat = new System.Windows.Forms.ColumnHeader();
            this.SectorPerCluster = new System.Windows.Forms.ColumnHeader();
            this.BytesPerSector = new System.Windows.Forms.ColumnHeader();
            this.FreeClusters = new System.Windows.Forms.ColumnHeader();
            this.TotalNumberOfClusters = new System.Windows.Forms.ColumnHeader();
            this.ClusterSize = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriveName,
            this.FreeSpace,
            this.TotalSpace,
            this.Physicalname,
            this.FileSystem,
            this.DiskName,
            this.DiskModel,
            this.VolumeSerial});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(137, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1084, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DriveName
            // 
            this.DriveName.Text = "DriveName";
            this.DriveName.Width = 100;
            // 
            // FreeSpace
            // 
            this.FreeSpace.Text = "FreeSpace";
            this.FreeSpace.Width = 150;
            // 
            // TotalSpace
            // 
            this.TotalSpace.Text = "TotalSpace";
            this.TotalSpace.Width = 150;
            // 
            // Physicalname
            // 
            this.Physicalname.Text = "Physicalname";
            this.Physicalname.Width = 200;
            // 
            // FileSystem
            // 
            this.FileSystem.Text = "FileSystem";
            this.FileSystem.Width = 150;
            // 
            // DiskName
            // 
            this.DiskName.Text = "DiskName";
            this.DiskName.Width = 300;
            // 
            // DiskModel
            // 
            this.DiskModel.Text = "DiskModel";
            this.DiskModel.Width = 300;
            // 
            // VolumeSerial
            // 
            this.VolumeSerial.Text = "VolumeSerial";
            this.VolumeSerial.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sectors & Clusters";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drive,
            this.DriveType,
            this.DriveFormat,
            this.SectorPerCluster,
            this.BytesPerSector,
            this.FreeClusters,
            this.TotalNumberOfClusters,
            this.ClusterSize});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(137, 321);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1084, 205);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
            // 
            // Drive
            // 
            this.Drive.Text = "DriveName";
            this.Drive.Width = 100;
            // 
            // DriveType
            // 
            this.DriveType.Text = "DriveType";
            // 
            // DriveFormat
            // 
            this.DriveFormat.Text = "DriveFormat";
            this.DriveFormat.Width = 100;
            // 
            // SectorPerCluster
            // 
            this.SectorPerCluster.Text = "SectorPerCluster";
            this.SectorPerCluster.Width = 200;
            // 
            // BytesPerSector
            // 
            this.BytesPerSector.Text = "BytesPerSector";
            this.BytesPerSector.Width = 150;
            // 
            // FreeClusters
            // 
            this.FreeClusters.Text = "FreeClusters";
            this.FreeClusters.Width = 150;
            // 
            // TotalNumberOfClusters
            // 
            this.TotalNumberOfClusters.Text = "TotalNumberOfClusters";
            this.TotalNumberOfClusters.Width = 300;
            // 
            // ClusterSize
            // 
            this.ClusterSize.Text = "ClusterSize";
            this.ClusterSize.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 559);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Physicalname;
        private System.Windows.Forms.ColumnHeader DiskName;
        private System.Windows.Forms.ColumnHeader DiskModel;
        private System.Windows.Forms.ColumnHeader VolumeSerial;
        private System.Windows.Forms.ColumnHeader DriveName;
        private System.Windows.Forms.ColumnHeader FileSystem;
        private System.Windows.Forms.ColumnHeader FreeSpace;
        private System.Windows.Forms.ColumnHeader TotalSpace;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Drive;
        private System.Windows.Forms.ColumnHeader DriveType;
        private System.Windows.Forms.ColumnHeader DriveFormat;
        private System.Windows.Forms.ColumnHeader SectorPerCluster;
        private System.Windows.Forms.ColumnHeader BytesPerSector;
        private System.Windows.Forms.ColumnHeader FreeClusters;
        private System.Windows.Forms.ColumnHeader TotalNumberOfClusters;
        private System.Windows.Forms.ColumnHeader ClusterSize;
    }
}

