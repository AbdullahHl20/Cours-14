namespace First_Windows_Forms_Application
{
    partial class frmMain
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
            this.btnShowPartOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPartOne
            // 
            this.btnShowPartOne.Location = new System.Drawing.Point(42, 25);
            this.btnShowPartOne.Name = "btnShowPartOne";
            this.btnShowPartOne.Size = new System.Drawing.Size(112, 85);
            this.btnShowPartOne.TabIndex = 0;
            this.btnShowPartOne.Text = "Show From One";
            this.btnShowPartOne.UseVisualStyleBackColor = true;
            this.btnShowPartOne.Click += new System.EventHandler(this.btnShowPartOne_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.btnShowPartOne);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPartOne;
    }
}