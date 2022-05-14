
namespace ConvertCapitalCaseProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RchTxt_FromText = new System.Windows.Forms.RichTextBox();
            this.RchTxt_ToText = new System.Windows.Forms.RichTextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RchTxt_FromText
            // 
            this.RchTxt_FromText.Location = new System.Drawing.Point(10, 52);
            this.RchTxt_FromText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RchTxt_FromText.Name = "RchTxt_FromText";
            this.RchTxt_FromText.Size = new System.Drawing.Size(606, 230);
            this.RchTxt_FromText.TabIndex = 0;
            this.RchTxt_FromText.Text = "any text as type case";
            // 
            // RchTxt_ToText
            // 
            this.RchTxt_ToText.Location = new System.Drawing.Point(10, 289);
            this.RchTxt_ToText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RchTxt_ToText.Name = "RchTxt_ToText";
            this.RchTxt_ToText.Size = new System.Drawing.Size(606, 234);
            this.RchTxt_ToText.TabIndex = 0;
            this.RchTxt_ToText.Text = "To Captial Case";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(10, 11);
            this.BtnConvert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(203, 36);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "Convert To CapitalCase";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 532);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.RchTxt_ToText);
            this.Controls.Add(this.RchTxt_FromText);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Property";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchTxt_FromText;
        private System.Windows.Forms.RichTextBox RchTxt_ToText;
        private System.Windows.Forms.Button BtnConvert;
    }
}

