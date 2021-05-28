
namespace SportsClub
{
    partial class MembersForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_book = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.lbl_bookid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_totalcost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_ed = new System.Windows.Forms.Label();
            this.lbl_sd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_memid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_notick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_events = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_trips = new System.Windows.Forms.RadioButton();
            this.radioButton_sport = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_book.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_book);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1375, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_book
            // 
            this.tab_book.Controls.Add(this.label8);
            this.tab_book.Controls.Add(this.btn_load);
            this.tab_book.Controls.Add(this.btn_book);
            this.tab_book.Controls.Add(this.lbl_bookid);
            this.tab_book.Controls.Add(this.label13);
            this.tab_book.Controls.Add(this.label12);
            this.tab_book.Controls.Add(this.lbl_totalcost);
            this.tab_book.Controls.Add(this.label10);
            this.tab_book.Controls.Add(this.lbl_ed);
            this.tab_book.Controls.Add(this.lbl_sd);
            this.tab_book.Controls.Add(this.label7);
            this.tab_book.Controls.Add(this.label6);
            this.tab_book.Controls.Add(this.txt_memid);
            this.tab_book.Controls.Add(this.label5);
            this.tab_book.Controls.Add(this.lbl_cost);
            this.tab_book.Controls.Add(this.label4);
            this.tab_book.Controls.Add(this.txt_notick);
            this.tab_book.Controls.Add(this.label3);
            this.tab_book.Controls.Add(this.cmb_events);
            this.tab_book.Controls.Add(this.label2);
            this.tab_book.Controls.Add(this.label1);
            this.tab_book.Controls.Add(this.radioButton_trips);
            this.tab_book.Controls.Add(this.radioButton_sport);
            this.tab_book.Location = new System.Drawing.Point(4, 25);
            this.tab_book.Name = "tab_book";
            this.tab_book.Padding = new System.Windows.Forms.Padding(3);
            this.tab_book.Size = new System.Drawing.Size(1367, 696);
            this.tab_book.TabIndex = 0;
            this.tab_book.Text = "Booking";
            this.tab_book.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "LE";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(592, 89);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(205, 24);
            this.btn_load.TabIndex = 23;
            this.btn_load.Text = "Load Events";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(802, 451);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(131, 42);
            this.btn_book.TabIndex = 22;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // lbl_bookid
            // 
            this.lbl_bookid.AutoSize = true;
            this.lbl_bookid.Location = new System.Drawing.Point(341, 440);
            this.lbl_bookid.Name = "lbl_bookid";
            this.lbl_bookid.Size = new System.Drawing.Size(21, 17);
            this.lbl_bookid.TabIndex = 21;
            this.lbl_bookid.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Booking ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "LE";
            // 
            // lbl_totalcost
            // 
            this.lbl_totalcost.AutoSize = true;
            this.lbl_totalcost.Location = new System.Drawing.Point(341, 390);
            this.lbl_totalcost.Name = "lbl_totalcost";
            this.lbl_totalcost.Size = new System.Drawing.Size(28, 17);
            this.lbl_totalcost.TabIndex = 18;
            this.lbl_totalcost.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Cost";
            // 
            // lbl_ed
            // 
            this.lbl_ed.AutoSize = true;
            this.lbl_ed.Location = new System.Drawing.Point(341, 280);
            this.lbl_ed.Name = "lbl_ed";
            this.lbl_ed.Size = new System.Drawing.Size(79, 17);
            this.lbl_ed.TabIndex = 16;
            this.lbl_ed.Text = "End Date...";
            this.lbl_ed.Click += new System.EventHandler(this.lbl_ed_Click);
            // 
            // lbl_sd
            // 
            this.lbl_sd.AutoSize = true;
            this.lbl_sd.Location = new System.Drawing.Point(341, 221);
            this.lbl_sd.Name = "lbl_sd";
            this.lbl_sd.Size = new System.Drawing.Size(84, 17);
            this.lbl_sd.TabIndex = 15;
            this.lbl_sd.Text = "Start Date...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start Date";
            // 
            // txt_memid
            // 
            this.txt_memid.Location = new System.Drawing.Point(344, 154);
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.Size = new System.Drawing.Size(173, 22);
            this.txt_memid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Member ID";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(698, 340);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(28, 17);
            this.lbl_cost.TabIndex = 8;
            this.lbl_cost.Text = "0.0";
            this.lbl_cost.Click += new System.EventHandler(this.lbl_cost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "One Ticket costs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_notick
            // 
            this.txt_notick.Location = new System.Drawing.Point(344, 335);
            this.txt_notick.Name = "txt_notick";
            this.txt_notick.Size = new System.Drawing.Size(173, 22);
            this.txt_notick.TabIndex = 6;
            this.txt_notick.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Tickets:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb_events
            // 
            this.cmb_events.FormattingEnabled = true;
            this.cmb_events.Location = new System.Drawing.Point(344, 89);
            this.cmb_events.Name = "cmb_events";
            this.cmb_events.Size = new System.Drawing.Size(173, 24);
            this.cmb_events.TabIndex = 4;
            this.cmb_events.SelectedIndexChanged += new System.EventHandler(this.cmb_events_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories:";
            // 
            // radioButton_trips
            // 
            this.radioButton_trips.AutoSize = true;
            this.radioButton_trips.Location = new System.Drawing.Point(383, 26);
            this.radioButton_trips.Name = "radioButton_trips";
            this.radioButton_trips.Size = new System.Drawing.Size(61, 21);
            this.radioButton_trips.TabIndex = 1;
            this.radioButton_trips.TabStop = true;
            this.radioButton_trips.Text = "Trips";
            this.radioButton_trips.UseVisualStyleBackColor = true;
            // 
            // radioButton_sport
            // 
            this.radioButton_sport.AutoSize = true;
            this.radioButton_sport.Location = new System.Drawing.Point(191, 26);
            this.radioButton_sport.Name = "radioButton_sport";
            this.radioButton_sport.Size = new System.Drawing.Size(70, 21);
            this.radioButton_sport.TabIndex = 0;
            this.radioButton_sport.TabStop = true;
            this.radioButton_sport.Text = "Sports";
            this.radioButton_sport.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1367, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "MembersForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MembersForm_FormClosing);
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_book.ResumeLayout(false);
            this.tab_book.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_trips;
        private System.Windows.Forms.RadioButton radioButton_sport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_memid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_notick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_events;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label lbl_bookid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_totalcost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_ed;
        private System.Windows.Forms.Label lbl_sd;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label8;
    }
}

