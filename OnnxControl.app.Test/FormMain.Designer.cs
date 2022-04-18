namespace OnnxControl.app.Test
{
    partial class FormMain
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
            this.btnLoadMnist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadMnist
            // 
            this.btnLoadMnist.Location = new System.Drawing.Point(33, 33);
            this.btnLoadMnist.Name = "btnLoadMnist";
            this.btnLoadMnist.Size = new System.Drawing.Size(142, 23);
            this.btnLoadMnist.TabIndex = 0;
            this.btnLoadMnist.Text = "Load MNIST";
            this.btnLoadMnist.UseVisualStyleBackColor = true;
            this.btnLoadMnist.Click += new System.EventHandler(this.btnLoadMnist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadMnist);
            this.Name = "Form1";
            this.Text = "OnnxControl Test Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMnist;
    }
}

