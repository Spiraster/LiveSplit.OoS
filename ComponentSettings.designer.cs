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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelP1A = new System.Windows.Forms.Label();
            this.labelP1B = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Onox = new System.Windows.Forms.Label();
            this.txt_Onox = new System.Windows.Forms.TextBox();
            this.txt_D8 = new System.Windows.Forms.TextBox();
            this.txt_D7 = new System.Windows.Forms.TextBox();
            this.txt_D6 = new System.Windows.Forms.TextBox();
            this.txt_D5 = new System.Windows.Forms.TextBox();
            this.txt_D4 = new System.Windows.Forms.TextBox();
            this.txt_D3 = new System.Windows.Forms.TextBox();
            this.txt_D2 = new System.Windows.Forms.TextBox();
            this.lbl_D8 = new System.Windows.Forms.Label();
            this.lbl_D7 = new System.Windows.Forms.Label();
            this.lbl_D6 = new System.Windows.Forms.Label();
            this.lbl_D5 = new System.Windows.Forms.Label();
            this.lbl_D4 = new System.Windows.Forms.Label();
            this.lbl_D3 = new System.Windows.Forms.Label();
            this.lbl_D2 = new System.Windows.Forms.Label();
            this.lbl_D1 = new System.Windows.Forms.Label();
            this.txt_D1 = new System.Windows.Forms.TextBox();
            this.lbl_L1Sword = new System.Windows.Forms.Label();
            this.txt_L1Sword = new System.Windows.Forms.TextBox();
            this.txt_ENP = new System.Windows.Forms.TextBox();
            this.lbl_ENP = new System.Windows.Forms.Label();
            this.lbl_ED8 = new System.Windows.Forms.Label();
            this.txt_ED8 = new System.Windows.Forms.TextBox();
            this.txt_ED7 = new System.Windows.Forms.TextBox();
            this.lbl_ED7 = new System.Windows.Forms.Label();
            this.lbl_ED6 = new System.Windows.Forms.Label();
            this.txt_ED6 = new System.Windows.Forms.TextBox();
            this.txt_ED5 = new System.Windows.Forms.TextBox();
            this.lbl_ED5 = new System.Windows.Forms.Label();
            this.lbl_ED4 = new System.Windows.Forms.Label();
            this.txt_ED4 = new System.Windows.Forms.TextBox();
            this.txt_ED3 = new System.Windows.Forms.TextBox();
            this.lbl_ED3 = new System.Windows.Forms.Label();
            this.lbl_ED2 = new System.Windows.Forms.Label();
            this.txt_ED2 = new System.Windows.Forms.TextBox();
            this.txt_ED1 = new System.Windows.Forms.TextBox();
            this.lbl_ED1 = new System.Windows.Forms.Label();
            this.chkStartTimer = new System.Windows.Forms.CheckBox();
            this.chkSelectFile = new System.Windows.Forms.CheckBox();
            this.chkAutoReset = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 21);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Save Splits";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelP1A
            // 
            this.labelP1A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelP1A.AutoSize = true;
            this.labelP1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1A.Location = new System.Drawing.Point(8, 3);
            this.labelP1A.Name = "labelP1A";
            this.labelP1A.Size = new System.Drawing.Size(105, 13);
            this.labelP1A.TabIndex = 26;
            this.labelP1A.Text = "Dungeon Entrances:";
            // 
            // labelP1B
            // 
            this.labelP1B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelP1B.AutoSize = true;
            this.labelP1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1B.Location = new System.Drawing.Point(227, 3);
            this.labelP1B.Name = "labelP1B";
            this.labelP1B.Size = new System.Drawing.Size(64, 13);
            this.labelP1B.TabIndex = 27;
            this.labelP1B.Text = "Instruments:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(6, 19);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(445, 340);
            this.tabControl.TabIndex = 17;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelP1A);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.labelP1B);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Onox, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_Onox, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_D8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_D7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_D6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_D5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_D4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_D3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_D2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_D1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_D1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_L1Sword, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_L1Sword, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ENP, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ENP, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ED1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ED1, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Onox
            // 
            this.lbl_Onox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Onox.AutoSize = true;
            this.lbl_Onox.Location = new System.Drawing.Point(218, 270);
            this.lbl_Onox.Name = "lbl_Onox";
            this.lbl_Onox.Size = new System.Drawing.Size(80, 13);
            this.lbl_Onox.TabIndex = 8;
            this.lbl_Onox.Text = "Defeat Onox:";
            // 
            // txt_Onox
            // 
            this.txt_Onox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Onox.Location = new System.Drawing.Point(304, 267);
            this.txt_Onox.Name = "txt_Onox";
            this.txt_Onox.Size = new System.Drawing.Size(124, 20);
            this.txt_Onox.TabIndex = 21;
            // 
            // txt_D8
            // 
            this.txt_D8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D8.Location = new System.Drawing.Point(304, 236);
            this.txt_D8.Name = "txt_D8";
            this.txt_D8.Size = new System.Drawing.Size(124, 20);
            this.txt_D8.TabIndex = 17;
            // 
            // txt_D7
            // 
            this.txt_D7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D7.Location = new System.Drawing.Point(304, 207);
            this.txt_D7.Name = "txt_D7";
            this.txt_D7.Size = new System.Drawing.Size(124, 20);
            this.txt_D7.TabIndex = 19;
            // 
            // txt_D6
            // 
            this.txt_D6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D6.Location = new System.Drawing.Point(304, 178);
            this.txt_D6.Name = "txt_D6";
            this.txt_D6.Size = new System.Drawing.Size(124, 20);
            this.txt_D6.TabIndex = 14;
            // 
            // txt_D5
            // 
            this.txt_D5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D5.Location = new System.Drawing.Point(304, 149);
            this.txt_D5.Name = "txt_D5";
            this.txt_D5.Size = new System.Drawing.Size(124, 20);
            this.txt_D5.TabIndex = 12;
            // 
            // txt_D4
            // 
            this.txt_D4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D4.Location = new System.Drawing.Point(304, 120);
            this.txt_D4.Name = "txt_D4";
            this.txt_D4.Size = new System.Drawing.Size(124, 20);
            this.txt_D4.TabIndex = 20;
            // 
            // txt_D3
            // 
            this.txt_D3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D3.Location = new System.Drawing.Point(304, 91);
            this.txt_D3.Name = "txt_D3";
            this.txt_D3.Size = new System.Drawing.Size(124, 20);
            this.txt_D3.TabIndex = 8;
            // 
            // txt_D2
            // 
            this.txt_D2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D2.Location = new System.Drawing.Point(304, 62);
            this.txt_D2.Name = "txt_D2";
            this.txt_D2.Size = new System.Drawing.Size(124, 20);
            this.txt_D2.TabIndex = 6;
            // 
            // lbl_D8
            // 
            this.lbl_D8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D8.AutoSize = true;
            this.lbl_D8.Location = new System.Drawing.Point(218, 233);
            this.lbl_D8.Name = "lbl_D8";
            this.lbl_D8.Size = new System.Drawing.Size(80, 26);
            this.lbl_D8.TabIndex = 7;
            this.lbl_D8.Text = "Changing Seasons:";
            // 
            // lbl_D7
            // 
            this.lbl_D7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D7.AutoSize = true;
            this.lbl_D7.Location = new System.Drawing.Point(218, 211);
            this.lbl_D7.Name = "lbl_D7";
            this.lbl_D7.Size = new System.Drawing.Size(80, 13);
            this.lbl_D7.TabIndex = 11;
            this.lbl_D7.Text = "Seed of Life:";
            // 
            // lbl_D6
            // 
            this.lbl_D6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D6.AutoSize = true;
            this.lbl_D6.Location = new System.Drawing.Point(218, 182);
            this.lbl_D6.Name = "lbl_D6";
            this.lbl_D6.Size = new System.Drawing.Size(80, 13);
            this.lbl_D6.TabIndex = 6;
            this.lbl_D6.Text = "Blowing Wind:";
            // 
            // lbl_D5
            // 
            this.lbl_D5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D5.AutoSize = true;
            this.lbl_D5.Location = new System.Drawing.Point(218, 146);
            this.lbl_D5.Name = "lbl_D5";
            this.lbl_D5.Size = new System.Drawing.Size(80, 26);
            this.lbl_D5.TabIndex = 6;
            this.lbl_D5.Text = "Nurturing Warmth:";
            // 
            // lbl_D4
            // 
            this.lbl_D4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D4.AutoSize = true;
            this.lbl_D4.Location = new System.Drawing.Point(218, 124);
            this.lbl_D4.Name = "lbl_D4";
            this.lbl_D4.Size = new System.Drawing.Size(80, 13);
            this.lbl_D4.TabIndex = 10;
            this.lbl_D4.Text = "Soothing Rain:";
            // 
            // lbl_D3
            // 
            this.lbl_D3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D3.AutoSize = true;
            this.lbl_D3.Location = new System.Drawing.Point(218, 95);
            this.lbl_D3.Name = "lbl_D3";
            this.lbl_D3.Size = new System.Drawing.Size(80, 13);
            this.lbl_D3.TabIndex = 6;
            this.lbl_D3.Text = "Bright Sun:";
            // 
            // lbl_D2
            // 
            this.lbl_D2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D2.AutoSize = true;
            this.lbl_D2.Location = new System.Drawing.Point(218, 66);
            this.lbl_D2.Name = "lbl_D2";
            this.lbl_D2.Size = new System.Drawing.Size(80, 13);
            this.lbl_D2.TabIndex = 6;
            this.lbl_D2.Text = "Gift of Time:";
            // 
            // lbl_D1
            // 
            this.lbl_D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_D1.AutoSize = true;
            this.lbl_D1.Location = new System.Drawing.Point(218, 37);
            this.lbl_D1.Name = "lbl_D1";
            this.lbl_D1.Size = new System.Drawing.Size(80, 13);
            this.lbl_D1.TabIndex = 6;
            this.lbl_D1.Text = "Fertile Soil:";
            // 
            // txt_D1
            // 
            this.txt_D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_D1.Location = new System.Drawing.Point(304, 33);
            this.txt_D1.Name = "txt_D1";
            this.txt_D1.Size = new System.Drawing.Size(124, 20);
            this.txt_D1.TabIndex = 4;
            // 
            // lbl_L1Sword
            // 
            this.lbl_L1Sword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_L1Sword.AutoSize = true;
            this.lbl_L1Sword.Location = new System.Drawing.Point(218, 8);
            this.lbl_L1Sword.Name = "lbl_L1Sword";
            this.lbl_L1Sword.Size = new System.Drawing.Size(80, 13);
            this.lbl_L1Sword.TabIndex = 24;
            this.lbl_L1Sword.Text = "Sword:";
            // 
            // txt_L1Sword
            // 
            this.txt_L1Sword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_L1Sword.Location = new System.Drawing.Point(304, 4);
            this.txt_L1Sword.Name = "txt_L1Sword";
            this.txt_L1Sword.Size = new System.Drawing.Size(124, 20);
            this.txt_L1Sword.TabIndex = 25;
            // 
            // txt_ENP
            // 
            this.txt_ENP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ENP.Location = new System.Drawing.Point(89, 267);
            this.txt_ENP.Name = "txt_ENP";
            this.txt_ENP.Size = new System.Drawing.Size(123, 20);
            this.txt_ENP.TabIndex = 23;
            // 
            // lbl_ENP
            // 
            this.lbl_ENP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ENP.AutoSize = true;
            this.lbl_ENP.Location = new System.Drawing.Point(3, 264);
            this.lbl_ENP.Name = "lbl_ENP";
            this.lbl_ENP.Size = new System.Drawing.Size(80, 26);
            this.lbl_ENP.TabIndex = 22;
            this.lbl_ENP.Text = "Enter Northern Peak:";
            // 
            // lbl_ED8
            // 
            this.lbl_ED8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED8.AutoSize = true;
            this.lbl_ED8.Location = new System.Drawing.Point(3, 240);
            this.lbl_ED8.Name = "lbl_ED8";
            this.lbl_ED8.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED8.TabIndex = 6;
            this.lbl_ED8.Text = "Enter D8:";
            // 
            // txt_ED8
            // 
            this.txt_ED8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED8.Location = new System.Drawing.Point(89, 236);
            this.txt_ED8.Name = "txt_ED8";
            this.txt_ED8.Size = new System.Drawing.Size(123, 20);
            this.txt_ED8.TabIndex = 16;
            // 
            // txt_ED7
            // 
            this.txt_ED7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED7.Location = new System.Drawing.Point(89, 207);
            this.txt_ED7.Name = "txt_ED7";
            this.txt_ED7.Size = new System.Drawing.Size(123, 20);
            this.txt_ED7.TabIndex = 18;
            // 
            // lbl_ED7
            // 
            this.lbl_ED7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED7.AutoSize = true;
            this.lbl_ED7.Location = new System.Drawing.Point(3, 211);
            this.lbl_ED7.Name = "lbl_ED7";
            this.lbl_ED7.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED7.TabIndex = 9;
            this.lbl_ED7.Text = "Enter D7:";
            // 
            // lbl_ED6
            // 
            this.lbl_ED6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED6.AutoSize = true;
            this.lbl_ED6.Location = new System.Drawing.Point(3, 182);
            this.lbl_ED6.Name = "lbl_ED6";
            this.lbl_ED6.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED6.TabIndex = 6;
            this.lbl_ED6.Text = "Enter D6:";
            // 
            // txt_ED6
            // 
            this.txt_ED6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED6.Location = new System.Drawing.Point(89, 178);
            this.txt_ED6.Name = "txt_ED6";
            this.txt_ED6.Size = new System.Drawing.Size(123, 20);
            this.txt_ED6.TabIndex = 13;
            // 
            // txt_ED5
            // 
            this.txt_ED5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED5.Location = new System.Drawing.Point(89, 149);
            this.txt_ED5.Name = "txt_ED5";
            this.txt_ED5.Size = new System.Drawing.Size(123, 20);
            this.txt_ED5.TabIndex = 11;
            // 
            // lbl_ED5
            // 
            this.lbl_ED5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED5.AutoSize = true;
            this.lbl_ED5.Location = new System.Drawing.Point(3, 153);
            this.lbl_ED5.Name = "lbl_ED5";
            this.lbl_ED5.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED5.TabIndex = 6;
            this.lbl_ED5.Text = "Enter D5:";
            // 
            // lbl_ED4
            // 
            this.lbl_ED4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED4.AutoSize = true;
            this.lbl_ED4.Location = new System.Drawing.Point(3, 124);
            this.lbl_ED4.Name = "lbl_ED4";
            this.lbl_ED4.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED4.TabIndex = 6;
            this.lbl_ED4.Text = "Enter D4:";
            // 
            // txt_ED4
            // 
            this.txt_ED4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED4.Location = new System.Drawing.Point(89, 120);
            this.txt_ED4.Name = "txt_ED4";
            this.txt_ED4.Size = new System.Drawing.Size(123, 20);
            this.txt_ED4.TabIndex = 9;
            // 
            // txt_ED3
            // 
            this.txt_ED3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED3.Location = new System.Drawing.Point(89, 91);
            this.txt_ED3.Name = "txt_ED3";
            this.txt_ED3.Size = new System.Drawing.Size(123, 20);
            this.txt_ED3.TabIndex = 7;
            // 
            // lbl_ED3
            // 
            this.lbl_ED3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED3.AutoSize = true;
            this.lbl_ED3.Location = new System.Drawing.Point(3, 95);
            this.lbl_ED3.Name = "lbl_ED3";
            this.lbl_ED3.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED3.TabIndex = 6;
            this.lbl_ED3.Text = "Enter D3:";
            // 
            // lbl_ED2
            // 
            this.lbl_ED2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED2.AutoSize = true;
            this.lbl_ED2.Location = new System.Drawing.Point(3, 66);
            this.lbl_ED2.Name = "lbl_ED2";
            this.lbl_ED2.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED2.TabIndex = 6;
            this.lbl_ED2.Text = "Enter D2:";
            // 
            // txt_ED2
            // 
            this.txt_ED2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED2.Location = new System.Drawing.Point(89, 62);
            this.txt_ED2.Name = "txt_ED2";
            this.txt_ED2.Size = new System.Drawing.Size(123, 20);
            this.txt_ED2.TabIndex = 5;
            // 
            // txt_ED1
            // 
            this.txt_ED1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ED1.Location = new System.Drawing.Point(89, 33);
            this.txt_ED1.Name = "txt_ED1";
            this.txt_ED1.Size = new System.Drawing.Size(123, 20);
            this.txt_ED1.TabIndex = 3;
            // 
            // lbl_ED1
            // 
            this.lbl_ED1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ED1.AutoSize = true;
            this.lbl_ED1.Location = new System.Drawing.Point(3, 37);
            this.lbl_ED1.Name = "lbl_ED1";
            this.lbl_ED1.Size = new System.Drawing.Size(80, 13);
            this.lbl_ED1.TabIndex = 6;
            this.lbl_ED1.Text = "Enter D1:";
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
            this.chkAutoReset.Size = new System.Drawing.Size(291, 17);
            this.chkAutoReset.TabIndex = 16;
            this.chkAutoReset.TabStop = false;
            this.chkAutoReset.Text = "Automatically reset timer after hard resetting the emulator";
            this.chkAutoReset.UseVisualStyleBackColor = true;
            this.chkAutoReset.CheckedChanged += new System.EventHandler(this.checkAutoReset_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 364);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split Names";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStartTimer);
            this.groupBox2.Controls.Add(this.chkSelectFile);
            this.groupBox2.Controls.Add(this.chkAutoReset);
            this.groupBox2.Location = new System.Drawing.Point(10, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // OoSSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OoSSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(475, 501);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelP1A;
        private System.Windows.Forms.Label labelP1B;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkStartTimer;
        private System.Windows.Forms.CheckBox chkSelectFile;
        private System.Windows.Forms.CheckBox chkAutoReset;
        private System.Windows.Forms.Label lbl_D7;
        public System.Windows.Forms.TextBox txt_D7;
        private System.Windows.Forms.Label lbl_ED1;
        public System.Windows.Forms.TextBox txt_ED1;
        private System.Windows.Forms.Label lbl_ED2;
        public System.Windows.Forms.TextBox txt_ED2;
        private System.Windows.Forms.Label lbl_ED4;
        public System.Windows.Forms.TextBox txt_ED4;
        private System.Windows.Forms.Label lbl_ED3;
        public System.Windows.Forms.TextBox txt_ED3;
        private System.Windows.Forms.Label lbl_ED6;
        public System.Windows.Forms.TextBox txt_ED6;
        private System.Windows.Forms.Label lbl_D1;
        public System.Windows.Forms.TextBox txt_D1;
        private System.Windows.Forms.Label lbl_ED8;
        public System.Windows.Forms.TextBox txt_ED8;
        private System.Windows.Forms.Label lbl_D3;
        public System.Windows.Forms.TextBox txt_D3;
        private System.Windows.Forms.Label lbl_ED7;
        public System.Windows.Forms.TextBox txt_ED7;
        private System.Windows.Forms.Label lbl_D4;
        public System.Windows.Forms.TextBox txt_D4;
        private System.Windows.Forms.Label lbl_D6;
        public System.Windows.Forms.TextBox txt_D6;
        private System.Windows.Forms.Label lbl_D2;
        public System.Windows.Forms.TextBox txt_D2;
        private System.Windows.Forms.Label lbl_D8;
        public System.Windows.Forms.TextBox txt_D8;
        private System.Windows.Forms.Label lbl_ED5;
        public System.Windows.Forms.TextBox txt_ED5;
        private System.Windows.Forms.Label lbl_D5;
        public System.Windows.Forms.TextBox txt_D5;
        private System.Windows.Forms.Label lbl_ENP;
        public System.Windows.Forms.TextBox txt_ENP;
        private System.Windows.Forms.Label lbl_Onox;
        public System.Windows.Forms.TextBox txt_Onox;
        private System.Windows.Forms.Label lbl_L1Sword;
        public System.Windows.Forms.TextBox txt_L1Sword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
