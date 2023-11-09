namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLampada = new System.Windows.Forms.PictureBox();
            this.btnAcender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAciona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).BeginInit();
            this.SuspendLayout();
            // 
            // picLampada
            // 
            this.picLampada.Location = new System.Drawing.Point(250, 36);
            this.picLampada.Name = "picLampada";
            this.picLampada.Size = new System.Drawing.Size(150, 218);
            this.picLampada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLampada.TabIndex = 0;
            this.picLampada.TabStop = false;
            // 
            // btnAcender
            // 
            this.btnAcender.Location = new System.Drawing.Point(296, 275);
            this.btnAcender.Name = "btnAcender";
            this.btnAcender.Size = new System.Drawing.Size(75, 23);
            this.btnAcender.TabIndex = 1;
            this.btnAcender.Text = "Acender";
            this.btnAcender.UseVisualStyleBackColor = true;
            this.btnAcender.Click += new System.EventHandler(this.btnAcender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(296, 304);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAciona
            // 
            this.btnAciona.Location = new System.Drawing.Point(298, 343);
            this.btnAciona.Name = "btnAciona";
            this.btnAciona.Size = new System.Drawing.Size(75, 23);
            this.btnAciona.TabIndex = 3;
            this.btnAciona.Text = "???";
            this.btnAciona.UseVisualStyleBackColor = true;
            this.btnAciona.Click += new System.EventHandler(this.btnAciona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAciona);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAcender);
            this.Controls.Add(this.picLampada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picLampada;
        private Button btnAcender;
        private Button btnApagar;
        private Button btnAciona;
    }
}