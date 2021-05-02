
namespace Note_App
{
    partial class CumButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CumButton));
            this.cumbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cumbttn
            // 
            this.cumbttn.BackColor = System.Drawing.SystemColors.WindowText;
            this.cumbttn.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cumbttn.ForeColor = System.Drawing.Color.DarkRed;
            this.cumbttn.Location = new System.Drawing.Point(182, 184);
            this.cumbttn.Name = "cumbttn";
            this.cumbttn.Size = new System.Drawing.Size(347, 94);
            this.cumbttn.TabIndex = 0;
            this.cumbttn.Text = "CUM BUTTON";
            this.cumbttn.UseVisualStyleBackColor = false;
            this.cumbttn.Click += new System.EventHandler(this.cumbttn_Click);
            // 
            // CumButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(727, 536);
            this.Controls.Add(this.cumbttn);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CumButton";
            this.Text = "CumButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cumbttn;
    }
}

