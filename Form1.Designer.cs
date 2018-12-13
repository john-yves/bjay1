namespace WindowsFormsApp60
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("piano");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Room", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Students");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Utilities", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "piano";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Room";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Students";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Calculator";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(208, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Mainpanel
            // 
            this.Mainpanel.Location = new System.Drawing.Point(214, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(561, 438);
            this.Mainpanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel Mainpanel;
    }
}

