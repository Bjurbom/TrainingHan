namespace TrainingHangul
{
    partial class trainging
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadIn
            // 
            this.loadIn.Location = new System.Drawing.Point(355, 188);
            this.loadIn.Name = "loadIn";
            this.loadIn.Size = new System.Drawing.Size(108, 35);
            this.loadIn.TabIndex = 0;
            this.loadIn.Text = "Load In";
            this.loadIn.UseVisualStyleBackColor = true;
            this.loadIn.Click += new System.EventHandler(this.loadIn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // trainging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadIn);
            this.Name = "trainging";
            this.Text = "trainging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadIn;
        private System.Windows.Forms.Button button2;
    }
}