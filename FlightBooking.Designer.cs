
namespace FlightBookingProject
{
    partial class FlightBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDocNo = new System.Windows.Forms.Label();
            this.lblDocIssueDate = new System.Windows.Forms.Label();
            this.lblDocExpiryDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.numericUpDownBaggage = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.dtpDocIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDocExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.rbIdentify = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaggage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDocNo
            // 
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNo.Location = new System.Drawing.Point(554, 363);
            this.lblDocNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(105, 17);
            this.lblDocNo.TabIndex = 5;
            this.lblDocNo.Text = "Document No";
            this.lblDocNo.Visible = false;
            // 
            // lblDocIssueDate
            // 
            this.lblDocIssueDate.AutoSize = true;
            this.lblDocIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocIssueDate.Location = new System.Drawing.Point(95, 314);
            this.lblDocIssueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocIssueDate.Name = "lblDocIssueDate";
            this.lblDocIssueDate.Size = new System.Drawing.Size(162, 17);
            this.lblDocIssueDate.TabIndex = 6;
            this.lblDocIssueDate.Text = "Document Issue Date";
            this.lblDocIssueDate.Visible = false;
            // 
            // lblDocExpiryDate
            // 
            this.lblDocExpiryDate.AutoSize = true;
            this.lblDocExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocExpiryDate.Location = new System.Drawing.Point(95, 375);
            this.lblDocExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocExpiryDate.Name = "lblDocExpiryDate";
            this.lblDocExpiryDate.Size = new System.Drawing.Size(168, 17);
            this.lblDocExpiryDate.TabIndex = 7;
            this.lblDocExpiryDate.Text = "Document Expiry Date";
            this.lblDocExpiryDate.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Baggage (Provide as Estimate)";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(-1, 618);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(975, 48);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Book (Without Paying)";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // numericUpDownBaggage
            // 
            this.numericUpDownBaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBaggage.Location = new System.Drawing.Point(553, 524);
            this.numericUpDownBaggage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownBaggage.Name = "numericUpDownBaggage";
            this.numericUpDownBaggage.Size = new System.Drawing.Size(72, 23);
            this.numericUpDownBaggage.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 526);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kgs";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(121, 27);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(160, 20);
            this.txtDeparture.TabIndex = 12;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(698, 27);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(160, 20);
            this.txtDestination.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(712, 115);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(712, 169);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(681, 363);
            this.txtDocNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(160, 20);
            this.txtDocNo.TabIndex = 16;
            this.txtDocNo.Visible = false;
            // 
            // dtpDocIssueDate
            // 
            this.dtpDocIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDocIssueDate.Location = new System.Drawing.Point(98, 333);
            this.dtpDocIssueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDocIssueDate.Name = "dtpDocIssueDate";
            this.dtpDocIssueDate.Size = new System.Drawing.Size(328, 23);
            this.dtpDocIssueDate.TabIndex = 17;
            this.dtpDocIssueDate.Visible = false;
            // 
            // dtpDocExpiryDate
            // 
            this.dtpDocExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDocExpiryDate.Location = new System.Drawing.Point(98, 394);
            this.dtpDocExpiryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDocExpiryDate.Name = "dtpDocExpiryDate";
            this.dtpDocExpiryDate.Size = new System.Drawing.Size(328, 23);
            this.dtpDocExpiryDate.TabIndex = 18;
            this.dtpDocExpiryDate.Visible = false;
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassport.Location = new System.Drawing.Point(32, 25);
            this.rbPassport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(66, 17);
            this.rbPassport.TabIndex = 19;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Passport";
            this.rbPassport.UseVisualStyleBackColor = true;
            this.rbPassport.CheckedChanged += new System.EventHandler(this.rbPassport_CheckedChanged);
            // 
            // rbIdentify
            // 
            this.rbIdentify.AutoSize = true;
            this.rbIdentify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdentify.Location = new System.Drawing.Point(112, 25);
            this.rbIdentify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbIdentify.Name = "rbIdentify";
            this.rbIdentify.Size = new System.Drawing.Size(110, 17);
            this.rbIdentify.TabIndex = 20;
            this.rbIdentify.TabStop = true;
            this.rbIdentify.Text = "Identification Card";
            this.rbIdentify.UseVisualStyleBackColor = true;
            this.rbIdentify.CheckedChanged += new System.EventHandler(this.rbIdentify_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPassport);
            this.groupBox1.Controls.Add(this.rbIdentify);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(619, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 58);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Document";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Choose your Schedule(Scroll to select range or use shift key)";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(98, 115);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 665);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDocExpiryDate);
            this.Controls.Add(this.dtpDocIssueDate);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownBaggage);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDocExpiryDate);
            this.Controls.Add(this.lblDocIssueDate);
            this.Controls.Add(this.lblDocNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightBooking";
            this.Text = "Flight Booking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaggage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDocNo;
        private System.Windows.Forms.Label lblDocIssueDate;
        private System.Windows.Forms.Label lblDocExpiryDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.NumericUpDown numericUpDownBaggage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.DateTimePicker dtpDocIssueDate;
        private System.Windows.Forms.DateTimePicker dtpDocExpiryDate;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.RadioButton rbIdentify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtDestination;
    }
}

