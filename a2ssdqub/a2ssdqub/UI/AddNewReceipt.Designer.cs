namespace a2ssdqub.UI
{
    partial class frmAddNewReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewReceipt));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecIDexplained = new System.Windows.Forms.Label();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comCustomer = new System.Windows.Forms.ComboBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comPay = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCloseFrm = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Receipt";
            // 
            // lblRecIDexplained
            // 
            this.lblRecIDexplained.AutoSize = true;
            this.lblRecIDexplained.Location = new System.Drawing.Point(13, 77);
            this.lblRecIDexplained.Name = "lblRecIDexplained";
            this.lblRecIDexplained.Size = new System.Drawing.Size(229, 13);
            this.lblRecIDexplained.TabIndex = 1;
            this.lblRecIDexplained.Text = "A new Receipt ID will be created automatically.";
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Location = new System.Drawing.Point(107, 111);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateIssue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Issue";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 140);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer";
            // 
            // comCustomer
            // 
            this.comCustomer.FormattingEnabled = true;
            this.comCustomer.Location = new System.Drawing.Point(107, 137);
            this.comCustomer.Name = "comCustomer";
            this.comCustomer.Size = new System.Drawing.Size(200, 21);
            this.comCustomer.TabIndex = 5;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Location = new System.Drawing.Point(12, 194);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(54, 13);
            this.lblTotalDue.TabIndex = 6;
            this.lblTotalDue.Text = "Total Due";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(107, 191);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(135, 20);
            this.txtTotalDue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Payment Method";
            // 
            // comPay
            // 
            this.comPay.FormattingEnabled = true;
            this.comPay.Location = new System.Drawing.Point(107, 164);
            this.comPay.Name = "comPay";
            this.comPay.Size = new System.Drawing.Size(200, 21);
            this.comPay.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "SAVE THIS RECEIPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssMessage
            // 
            this.tssMessage.Name = "tssMessage";
            this.tssMessage.Size = new System.Drawing.Size(122, 17);
            this.tssMessage.Text = "News will appear here";
            // 
            // btnCloseFrm
            // 
            this.btnCloseFrm.Location = new System.Drawing.Point(607, 13);
            this.btnCloseFrm.Name = "btnCloseFrm";
            this.btnCloseFrm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseFrm.TabIndex = 12;
            this.btnCloseFrm.Text = "CLOSE";
            this.btnCloseFrm.UseVisualStyleBackColor = true;
            this.btnCloseFrm.Click += new System.EventHandler(this.btnCloseFrm_Click);
            // 
            // frmAddNewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 371);
            this.Controls.Add(this.btnCloseFrm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalDue);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.comCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.lblRecIDexplained);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewReceipt";
            this.Text = "Add A New Receipt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecIDexplained;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox comCustomer;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMessage;
        private System.Windows.Forms.Button btnCloseFrm;
    }
}