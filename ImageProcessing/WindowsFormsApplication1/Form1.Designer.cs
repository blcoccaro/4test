namespace WindowsFormsApplication1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtPathToSave = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 17);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Selecione...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(93, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(52, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "{location}";
            // 
            // txtPathToSave
            // 
            this.txtPathToSave.Location = new System.Drawing.Point(12, 46);
            this.txtPathToSave.Name = "txtPathToSave";
            this.txtPathToSave.Size = new System.Drawing.Size(226, 20);
            this.txtPathToSave.TabIndex = 2;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(245, 46);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 3;
            this.btnResize.Text = "Rezise";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 251);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.txtPathToSave);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtPathToSave;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

