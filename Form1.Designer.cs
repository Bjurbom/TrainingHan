namespace TrainingHangul
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
            this.loadIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadIn
            // 
            this.loadIn.Location = new System.Drawing.Point(304, 191);
            this.loadIn.Name = "loadIn";
            this.loadIn.Size = new System.Drawing.Size(108, 35);
            this.loadIn.TabIndex = 1;
            this.loadIn.Text = "Load In";
            this.loadIn.UseVisualStyleBackColor = true;
            this.loadIn.Click += new System.EventHandler(this.loadIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 398);
            this.Controls.Add(this.loadIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadIn;
    }
}

