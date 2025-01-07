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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMesageBoxForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPartOne
            // 
            this.btnShowPartOne.Location = new System.Drawing.Point(56, 31);
            this.btnShowPartOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowPartOne.Name = "btnShowPartOne";
            this.btnShowPartOne.Size = new System.Drawing.Size(149, 105);
            this.btnShowPartOne.TabIndex = 0;
            this.btnShowPartOne.Text = "Show From One";
            this.btnShowPartOne.UseVisualStyleBackColor = true;
            this.btnShowPartOne.Click += new System.EventHandler(this.btnShowPartOne_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show From As Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMesageBoxForm
            // 
            this.btnMesageBoxForm.Location = new System.Drawing.Point(56, 255);
            this.btnMesageBoxForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMesageBoxForm.Name = "btnMesageBoxForm";
            this.btnMesageBoxForm.Size = new System.Drawing.Size(149, 105);
            this.btnMesageBoxForm.TabIndex = 2;
            this.btnMesageBoxForm.Text = "Show From As Dialog";
            this.btnMesageBoxForm.UseVisualStyleBackColor = true;
            this.btnMesageBoxForm.Click += new System.EventHandler(this.btnMesageBoxForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 105);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Check Box Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 105);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show Text Box ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMesageBoxForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPartOne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPartOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMesageBoxForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}