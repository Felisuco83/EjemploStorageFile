
namespace EjemploStorageFile
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
            this.btnleerfile = new System.Windows.Forms.Button();
            this.txtcontenido = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnleerfile
            // 
            this.btnleerfile.Location = new System.Drawing.Point(25, 28);
            this.btnleerfile.Name = "btnleerfile";
            this.btnleerfile.Size = new System.Drawing.Size(175, 103);
            this.btnleerfile.TabIndex = 0;
            this.btnleerfile.Text = "Read Azure File";
            this.btnleerfile.UseVisualStyleBackColor = true;
            this.btnleerfile.Click += new System.EventHandler(this.btnleerfile_Click);
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(241, 28);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(532, 410);
            this.txtcontenido.TabIndex = 1;
            this.txtcontenido.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.btnleerfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnleerfile;
        private System.Windows.Forms.RichTextBox txtcontenido;
    }
}

