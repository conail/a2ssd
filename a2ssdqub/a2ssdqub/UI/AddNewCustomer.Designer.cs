namespace a2ssdqub
{
    partial class AddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer));
            this.lbl = new System.Windows.Forms.Label();
            this.lblIdMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radUndisclosed = new System.Windows.Forms.RadioButton();
            this.radUnknown = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssText = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(13, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(327, 37);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Add A New Customer";
            // 
            // lblIdMsg
            // 
            this.lblIdMsg.AutoSize = true;
            this.lblIdMsg.Location = new System.Drawing.Point(12, 68);
            this.lblIdMsg.Name = "lblIdMsg";
            this.lblIdMsg.Size = new System.Drawing.Size(233, 13);
            this.lblIdMsg.TabIndex = 1;
            this.lblIdMsg.Text = "A new Customer ID will be created automatically";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(74, 98);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(210, 20);
            this.txtForename.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth";
            // 
            // datDob
            // 
            this.datDob.Location = new System.Drawing.Point(84, 146);
            this.datDob.Name = "datDob";
            this.datDob.Size = new System.Drawing.Size(200, 20);
            this.datDob.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(74, 203);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(74, 227);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 8;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radUndisclosed
            // 
            this.radUndisclosed.AutoSize = true;
            this.radUndisclosed.Location = new System.Drawing.Point(74, 251);
            this.radUndisclosed.Name = "radUndisclosed";
            this.radUndisclosed.Size = new System.Drawing.Size(83, 17);
            this.radUndisclosed.TabIndex = 9;
            this.radUndisclosed.TabStop = true;
            this.radUndisclosed.Text = "Undisclosed";
            this.radUndisclosed.UseVisualStyleBackColor = true;
            // 
            // radUnknown
            // 
            this.radUnknown.AutoSize = true;
            this.radUnknown.Location = new System.Drawing.Point(74, 275);
            this.radUnknown.Name = "radUnknown";
            this.radUnknown.Size = new System.Drawing.Size(71, 17);
            this.radUnknown.TabIndex = 10;
            this.radUnknown.TabStop = true;
            this.radUnknown.Text = "Unknown";
            this.radUnknown.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 300);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(264, 23);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "ADD CUSTOMER";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssText
            // 
            this.tssText.Name = "tssText";
            this.tssText.Size = new System.Drawing.Size(118, 17);
            this.tssText.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD ANOTHER CUSTOMER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radUnknown);
            this.Controls.Add(this.radUndisclosed);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datDob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdMsg);
            this.Controls.Add(this.lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewCustomer";
            this.Text = "Add A New Customer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblIdMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radUndisclosed;
        private System.Windows.Forms.RadioButton radUnknown;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssText;
        private System.Windows.Forms.Button button1;
    }
}