namespace CompressJSON
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDeCompress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyToTexto = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 25);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(517, 121);
            this.txtText.TabIndex = 1;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(15, 152);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(113, 23);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDeCompress
            // 
            this.btnDeCompress.Location = new System.Drawing.Point(134, 152);
            this.btnDeCompress.Name = "btnDeCompress";
            this.btnDeCompress.Size = new System.Drawing.Size(118, 23);
            this.btnDeCompress.TabIndex = 3;
            this.btnDeCompress.Text = "Decompress";
            this.btnDeCompress.UseVisualStyleBackColor = true;
            this.btnDeCompress.Click += new System.EventHandler(this.btnDeCompress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // btnCopyToTexto
            // 
            this.btnCopyToTexto.Location = new System.Drawing.Point(454, 156);
            this.btnCopyToTexto.Name = "btnCopyToTexto";
            this.btnCopyToTexto.Size = new System.Drawing.Size(75, 41);
            this.btnCopyToTexto.TabIndex = 6;
            this.btnCopyToTexto.Text = "Copiar Acima";
            this.btnCopyToTexto.UseVisualStyleBackColor = true;
            this.btnCopyToTexto.Click += new System.EventHandler(this.btnCopyToTexto_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(76, 180);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(60, 13);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "{Tamanho}";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 196);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(512, 105);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 336);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnCopyToTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeCompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Compress JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDeCompress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopyToTexto;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}

