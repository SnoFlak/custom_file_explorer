using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomFileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the ListView to display items in details mode with a single column
            quickDirs.View = View.Details;
            LoadDrives();
        }

        private void LoadDrives()
        {
            quickDirs.Items.Clear();

            // Get all drives
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                // Create a ListViewItem for each drive
                ListViewItem item = new ListViewItem(drive.Name); // Drive name (e.g., "C:\")

                if (drive.IsReady) // Check if the drive is ready to be used
                {
                    String freeSpace = drive.AvailableFreeSpace.ToString();
                    String spaceIdentifier = "TB";

                    String majorCount = "";

                    if (freeSpace.Length >= 13)
                    {
                        // deal with it because nobody should be having petabyte drives in their system if they're using this :sob:
                        majorCount = freeSpace.Substring(0, freeSpace.Length - 12);
                    }
                    else if (freeSpace.Length < 13)
                    {
                        spaceIdentifier = "GB";
                        majorCount = freeSpace.Substring(0, freeSpace.Length - 9);
                    }
                    else if (freeSpace.Length < 10)
                    {
                        majorCount = freeSpace.Substring(0, freeSpace.Length - 6);
                        spaceIdentifier = "MB";
                    }
                    else if (freeSpace.Length < 7)
                    {
                        majorCount = freeSpace.Substring(0, freeSpace.Length - 3);
                        spaceIdentifier = "KB";
                    }
                    else
                    {
                        majorCount = freeSpace;
                        spaceIdentifier = "Byte";
                    }

                    item.SubItems.Add(majorCount + " " + spaceIdentifier); // Available free space
                }
                else
                {
                    item.SubItems.Add("Not Ready");
                    item.SubItems.Add("Not Ready");
                }

                quickDirs.Items.Add(item);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void quickDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quickDirs.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = quickDirs.SelectedItems[0];
                DriveInfo selectedDrive = (DriveInfo)selectedItem.Tag;
                MessageBox.Show("Selected Drive: " + selectedDrive.Name);
            }
        }
    }
}
