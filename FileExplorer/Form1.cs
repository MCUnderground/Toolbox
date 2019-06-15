﻿using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private string path;
        private string openPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            textBox1.Text = path;
            ShowFiles();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            openPath = path+ @"\" + e.Item.Text;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            if (Directory.Exists(openPath))
            {
                path = openPath;
                listView1.Clear();
                ShowFiles();
            }
            else if (File.Exists(openPath))
            {
                Process.Start(openPath);

            }
            else { MessageBox.Show("File extention unknown."); }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            path = Directory.GetParent(path).FullName; 
            listView1.Clear();
            ShowFiles();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            path = textBox1.Text;
            if (Directory.Exists(path))
            {  
                listView1.Clear();
                ShowFiles();
            }
            else { MessageBox.Show("Path does not exist or it is a file."); }
        }

        private void ShowFiles()
        {
            textBox1.Text = path;
            foreach (string i in Directory.GetDirectories(path))
            {
                listView1.Items.Add(new DirectoryInfo(i).Name, imageList1.Images.Count - 2);
            }
            foreach (string i in Directory.GetFiles(path))
            {
                listView1.Items.Add(Path.GetFileName(i), imageList1.Images.Count - 1);
            }
        }
    }
}
