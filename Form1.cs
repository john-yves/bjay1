using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form y; 
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":
                    y.Dispose();
                    y = new Formcaculatel();
                    y.TopLevel = false;
                    Mainpanel.Controls.Add(y);
                    y.Dock = DockStyle.Fill;
                    y.Show();

                    break;


                case "piano":
                    y.Dispose();
                    y = new formroom();
                    y.TopLevel = false;
                    Mainpanel.Controls.Add(y);
                    y.Dock = DockStyle.Fill;
                    y.Show();

                    break;

                case "Room":
                    y.Dispose();
                    y = new Room();
                    y.TopLevel = false;
                    Mainpanel.Controls.Add(y);
                    y.Dock = DockStyle.Fill;
                    y.Show();

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            y = new Formcaculatel
            {
                TopLevel = false
            };
            this.Mainpanel.Controls.Add(y);
            y.Dock = DockStyle.Fill;
        }
    } }