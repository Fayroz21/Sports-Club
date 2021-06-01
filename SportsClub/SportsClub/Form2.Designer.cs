namespace SportsClub
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eventTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.membersTab = new System.Windows.Forms.TabPage();
            this.memberGridView = new System.Windows.Forms.DataGridView();
            this.updateChangesBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.memberID_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.eventTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.membersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sport",
            "Trip"});
            this.comboBox1.Location = new System.Drawing.Point(336, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 322);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(559, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.button2.Location = new System.Drawing.Point(879, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1104, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "© Team SW_12  Software Engineering. 2021. ";
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.tabPage1);
            this.eventTab.Controls.Add(this.membersTab);
            this.eventTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTab.Location = new System.Drawing.Point(139, 46);
            this.eventTab.Name = "eventTab";
            this.eventTab.SelectedIndex = 0;
            this.eventTab.Size = new System.Drawing.Size(1157, 666);
            this.eventTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // membersTab
            // 
            this.membersTab.Controls.Add(this.memberGridView);
            this.membersTab.Controls.Add(this.updateChangesBtn);
            this.membersTab.Controls.Add(this.searchBtn);
            this.membersTab.Controls.Add(this.memberID_txt);
            this.membersTab.Controls.Add(this.label6);
            this.membersTab.Location = new System.Drawing.Point(4, 34);
            this.membersTab.Name = "membersTab";
            this.membersTab.Padding = new System.Windows.Forms.Padding(3);
            this.membersTab.Size = new System.Drawing.Size(1149, 628);
            this.membersTab.TabIndex = 1;
            this.membersTab.Text = "Members";
            this.membersTab.UseVisualStyleBackColor = true;
            this.membersTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // memberGridView
            // 
            this.memberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGridView.Location = new System.Drawing.Point(51, 175);
            this.memberGridView.Name = "memberGridView";
            this.memberGridView.RowHeadersWidth = 51;
            this.memberGridView.RowTemplate.Height = 24;
            this.memberGridView.Size = new System.Drawing.Size(1041, 339);
            this.memberGridView.TabIndex = 4;
            // 
            // updateChangesBtn
            // 
            this.updateChangesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.updateChangesBtn.Location = new System.Drawing.Point(934, 536);
            this.updateChangesBtn.Name = "updateChangesBtn";
            this.updateChangesBtn.Size = new System.Drawing.Size(158, 62);
            this.updateChangesBtn.TabIndex = 3;
            this.updateChangesBtn.Text = "Update ";
            this.updateChangesBtn.UseVisualStyleBackColor = false;
            this.updateChangesBtn.Click += new System.EventHandler(this.updateChangesBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.searchBtn.Location = new System.Drawing.Point(617, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(148, 50);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // memberID_txt
            // 
            this.memberID_txt.Location = new System.Drawing.Point(408, 35);
            this.memberID_txt.Name = "memberID_txt";
            this.memberID_txt.Size = new System.Drawing.Size(206, 31);
            this.memberID_txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Membership number :";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(194)))));
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(1166, 20);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(230, 30);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "    \r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 68);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sports Club";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.eventTab);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 770);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 834);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.eventTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.membersTab.ResumeLayout(false);
            this.membersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl eventTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage membersTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button updateChangesBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox memberID_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView memberGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}