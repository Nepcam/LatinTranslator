namespace LatinTranslator
{
    partial class FormLatinTranslator
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
            this.buttonLatinSinister = new System.Windows.Forms.Button();
            this.buttonLatinMedium = new System.Windows.Forms.Button();
            this.buttonLatinDexter = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLatinSinister
            // 
            this.buttonLatinSinister.Location = new System.Drawing.Point(170, 361);
            this.buttonLatinSinister.Name = "buttonLatinSinister";
            this.buttonLatinSinister.Size = new System.Drawing.Size(75, 23);
            this.buttonLatinSinister.TabIndex = 0;
            this.buttonLatinSinister.Text = "Sinister";
            this.buttonLatinSinister.UseVisualStyleBackColor = true;
            this.buttonLatinSinister.Click += new System.EventHandler(this.buttonLatinSinister_Click);
            // 
            // buttonLatinMedium
            // 
            this.buttonLatinMedium.Location = new System.Drawing.Point(328, 361);
            this.buttonLatinMedium.Name = "buttonLatinMedium";
            this.buttonLatinMedium.Size = new System.Drawing.Size(75, 23);
            this.buttonLatinMedium.TabIndex = 1;
            this.buttonLatinMedium.Text = "Medium";
            this.buttonLatinMedium.UseVisualStyleBackColor = true;
            this.buttonLatinMedium.Click += new System.EventHandler(this.buttonLatinMedium_Click);
            // 
            // buttonLatinDexter
            // 
            this.buttonLatinDexter.Location = new System.Drawing.Point(482, 361);
            this.buttonLatinDexter.Name = "buttonLatinDexter";
            this.buttonLatinDexter.Size = new System.Drawing.Size(75, 23);
            this.buttonLatinDexter.TabIndex = 2;
            this.buttonLatinDexter.Text = "Dexter";
            this.buttonLatinDexter.UseVisualStyleBackColor = true;
            this.buttonLatinDexter.Click += new System.EventHandler(this.buttonLatinDexter_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(289, 172);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 3;
            // 
            // FormLatinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 422);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonLatinDexter);
            this.Controls.Add(this.buttonLatinMedium);
            this.Controls.Add(this.buttonLatinSinister);
            this.Name = "FormLatinTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLatinSinister;
        private System.Windows.Forms.Button buttonLatinMedium;
        private System.Windows.Forms.Button buttonLatinDexter;
        private System.Windows.Forms.Label labelOutput;
    }
}

