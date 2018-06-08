namespace CSharp_Web_Server
{
    partial class SelectInterface
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboxIP = new System.Windows.Forms.ComboBox();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(221, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboxIP
            // 
            this.cboxIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIP.FormattingEnabled = true;
            this.cboxIP.Location = new System.Drawing.Point(12, 12);
            this.cboxIP.Name = "cboxIP";
            this.cboxIP.Size = new System.Drawing.Size(144, 21);
            this.cboxIP.TabIndex = 1;
            this.cboxIP.SelectedIndexChanged += new System.EventHandler(this.cboxIP_SelectedIndexChanged);
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(162, 12);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(53, 20);
            this.tboxPort.TabIndex = 2;
            this.tboxPort.Text = "80";
            // 
            // SelectInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 44);
            this.Controls.Add(this.tboxPort);
            this.Controls.Add(this.cboxIP);
            this.Controls.Add(this.btnSubmit);
            this.Name = "SelectInterface";
            this.Text = "SelectInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboxIP;
        private System.Windows.Forms.TextBox tboxPort;
    }
}