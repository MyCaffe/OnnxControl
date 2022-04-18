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
            this.btnLoadInception_v1 = new System.Windows.Forms.Button();
            this.btnLoadInception_v2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadInception_v1
            // 
            this.btnLoadInception_v1.Location = new System.Drawing.Point(33, 33);
            this.btnLoadInception_v1.Name = "btnLoadInception_v1";
            this.btnLoadInception_v1.Size = new System.Drawing.Size(142, 23);
            this.btnLoadInception_v1.TabIndex = 0;
            this.btnLoadInception_v1.Text = "Load Inception V1";
            this.btnLoadInception_v1.UseVisualStyleBackColor = true;
            this.btnLoadInception_v1.Click += new System.EventHandler(this.btnLoadInceptionV1);
            // 
            // btnLoadInception_v2
            // 
            this.btnLoadInception_v2.Location = new System.Drawing.Point(33, 62);
            this.btnLoadInception_v2.Name = "btnLoadInception_v2";
            this.btnLoadInception_v2.Size = new System.Drawing.Size(142, 23);
            this.btnLoadInception_v2.TabIndex = 0;
            this.btnLoadInception_v2.Text = "Load Inception V2";
            this.btnLoadInception_v2.UseVisualStyleBackColor = true;
            this.btnLoadInception_v2.Click += new System.EventHandler(this.btnLoadInceptionV2);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadInception_v2);
            this.Controls.Add(this.btnLoadInception_v1);
            this.Name = "FormMain";
            this.Text = "OnnxControl Test Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadInception_v1;
        private System.Windows.Forms.Button btnLoadInception_v2;
    }
}

