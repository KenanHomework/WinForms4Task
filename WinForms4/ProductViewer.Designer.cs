namespace WinForms4
{
    partial class ProductViewer
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_country = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_coast = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.mtbx_coast = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(20, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Product Name";
            // 
            // tbx_name
            // 
            this.tbx_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_name.Location = new System.Drawing.Point(20, 37);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(276, 16);
            this.tbx_name.TabIndex = 1;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            // 
            // tbx_country
            // 
            this.tbx_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_country.Location = new System.Drawing.Point(20, 91);
            this.tbx_country.Name = "tbx_country";
            this.tbx_country.Size = new System.Drawing.Size(276, 16);
            this.tbx_country.TabIndex = 3;
            this.tbx_country.TextChanged += new System.EventHandler(this.tbx_country_TextChanged);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_country.Location = new System.Drawing.Point(20, 68);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(88, 20);
            this.lbl_country.TabIndex = 2;
            this.lbl_country.Text = "Origion Country";
            // 
            // lbl_coast
            // 
            this.lbl_coast.AutoSize = true;
            this.lbl_coast.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_coast.Location = new System.Drawing.Point(20, 124);
            this.lbl_coast.Name = "lbl_coast";
            this.lbl_coast.Size = new System.Drawing.Size(79, 20);
            this.lbl_coast.TabIndex = 4;
            this.lbl_coast.Text = "Product Name";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(20, 187);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(221, 187);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // mtbx_coast
            // 
            this.mtbx_coast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbx_coast.Location = new System.Drawing.Point(20, 147);
            this.mtbx_coast.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000";
            this.mtbx_coast.Name = "mtbx_coast";
            this.mtbx_coast.Size = new System.Drawing.Size(275, 29);
            this.mtbx_coast.TabIndex = 8;
            this.mtbx_coast.TextChanged += new System.EventHandler(this.mtbx_coast_TextChanged);
            // 
            // ProductViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 225);
            this.Controls.Add(this.mtbx_coast);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_coast);
            this.Controls.Add(this.tbx_country);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.Name = "ProductViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private TextBox tbx_name;
        private TextBox tbx_country;
        private Label lbl_country;
        private Label lbl_coast;
        private Button btn_ok;
        private Button btn_cancel;
        private MaskedTextBox mtbx_coast;
    }
}