namespace LiveSplit.OoS
{
    partial class OoSSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gnarled Root Dungeon (D1)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Snake\'s Remains (D2)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Poison Moth\'s Lair (D3)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Dancing Dragon Dungeon (D4)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Unicorn\'s Cave (D5)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ancient Ruins (D6)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Explorer\'s Crypt (D7)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sword & Shield Maze (D8)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Dungeon Entrances", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Fertile Soil (D1)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gift of Time (D2)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Bright Sun (D3)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Soothing Rain (D4)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nurturing Warmth (D5)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Blowing Wind (D6)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Seed of Life (D7)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Changing Seasons (D8)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Essences", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("L1 Sword");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Enter Northern Peak");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Enter Onox Fight");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Defeat Onox");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Others", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            this.chkStartTimer = new System.Windows.Forms.CheckBox();
            this.chkSelectFile = new System.Windows.Forms.CheckBox();
            this.chkAutoReset = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new LiveSplit.OoS.NewTreeView();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkStartTimer
            // 
            this.chkStartTimer.AutoSize = true;
            this.chkStartTimer.Location = new System.Drawing.Point(6, 19);
            this.chkStartTimer.Name = "chkStartTimer";
            this.chkStartTimer.Size = new System.Drawing.Size(235, 17);
            this.chkStartTimer.TabIndex = 14;
            this.chkStartTimer.TabStop = false;
            this.chkStartTimer.Text = "Automatically start timer when selecting a file";
            this.chkStartTimer.UseVisualStyleBackColor = true;
            this.chkStartTimer.CheckedChanged += new System.EventHandler(this.checkStartTimer_CheckedChanged);
            // 
            // chkSelectFile
            // 
            this.chkSelectFile.AutoSize = true;
            this.chkSelectFile.Location = new System.Drawing.Point(6, 42);
            this.chkSelectFile.Name = "chkSelectFile";
            this.chkSelectFile.Size = new System.Drawing.Size(226, 17);
            this.chkSelectFile.TabIndex = 15;
            this.chkSelectFile.TabStop = false;
            this.chkSelectFile.Text = "Automatically select file when starting timer";
            this.chkSelectFile.UseVisualStyleBackColor = true;
            this.chkSelectFile.CheckedChanged += new System.EventHandler(this.checkSelectFile_CheckedChanged);
            // 
            // chkAutoReset
            // 
            this.chkAutoReset.AutoSize = true;
            this.chkAutoReset.Location = new System.Drawing.Point(6, 65);
            this.chkAutoReset.Name = "chkAutoReset";
            this.chkAutoReset.Size = new System.Drawing.Size(294, 17);
            this.chkAutoReset.TabIndex = 16;
            this.chkAutoReset.TabStop = false;
            this.chkAutoReset.Text = "Automatically reset timer after hard resetting the emulator ";
            this.chkAutoReset.UseVisualStyleBackColor = true;
            this.chkAutoReset.CheckedChanged += new System.EventHandler(this.checkAutoReset_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStartTimer);
            this.groupBox2.Controls.Add(this.chkSelectFile);
            this.groupBox2.Controls.Add(this.chkAutoReset);
            this.groupBox2.Location = new System.Drawing.Point(10, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 88);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 364);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the splits you would like the autosplitter to split for:";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "node_ED1";
            treeNode1.Text = "Gnarled Root Dungeon (D1)";
            treeNode2.Name = "node_ED2";
            treeNode2.Text = "Snake\'s Remains (D2)";
            treeNode3.Name = "node_ED3";
            treeNode3.Text = "Poison Moth\'s Lair (D3)";
            treeNode4.Name = "node_ED4";
            treeNode4.Text = "Dancing Dragon Dungeon (D4)";
            treeNode5.Name = "node_ED5";
            treeNode5.Text = "Unicorn\'s Cave (D5)";
            treeNode6.Name = "node_ED6";
            treeNode6.Text = "Ancient Ruins (D6)";
            treeNode7.Name = "node_ED7";
            treeNode7.Text = "Explorer\'s Crypt (D7)";
            treeNode8.Name = "node_ED8";
            treeNode8.Text = "Sword & Shield Maze (D8)";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Dungeon Entrances";
            treeNode10.Name = "node_D1";
            treeNode10.Text = "Fertile Soil (D1)";
            treeNode11.Name = "node_D2";
            treeNode11.Text = "Gift of Time (D2)";
            treeNode12.Name = "node_D3";
            treeNode12.Text = "Bright Sun (D3)";
            treeNode13.Name = "node_D4";
            treeNode13.Text = "Soothing Rain (D4)";
            treeNode14.Name = "node_D5";
            treeNode14.Text = "Nurturing Warmth (D5)";
            treeNode15.Name = "node_D6";
            treeNode15.Text = "Blowing Wind (D6)";
            treeNode16.Name = "node_D7";
            treeNode16.Text = "Seed of Life (D7)";
            treeNode17.Name = "node_D8";
            treeNode17.Text = "Changing Seasons (D8)";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Essences";
            treeNode19.Name = "node_L1Sword";
            treeNode19.Text = "L1 Sword";
            treeNode20.Name = "node_ENP";
            treeNode20.Text = "Enter Northern Peak";
            treeNode21.Name = "node_EOnox";
            treeNode21.Text = "Enter Onox Fight";
            treeNode22.Name = "node_Onox";
            treeNode22.Text = "Defeat Onox";
            treeNode23.Name = "Node2";
            treeNode23.Text = "Others";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode18,
            treeNode23});
            this.treeView1.Size = new System.Drawing.Size(458, 345);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersion.Location = new System.Drawing.Point(440, 1);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "v0.0.0";
            // 
            // OoSSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OoSSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(484, 513);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkStartTimer;
        private System.Windows.Forms.CheckBox chkSelectFile;
        private System.Windows.Forms.CheckBox chkAutoReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveSplit.OoS.NewTreeView treeView1;
        private System.Windows.Forms.Label lblVersion;
    }
}
