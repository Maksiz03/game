
namespace age
{
    partial class Form11
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
            System.Windows.Forms.Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            button2.Location = new System.Drawing.Point(24, 586);
            button2.Name = "button2";
            button2.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            button2.Size = new System.Drawing.Size(65, 81);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(1194, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(65, 81);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::age.Resource1.фон_3;
            this.ClientSize = new System.Drawing.Size(1268, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(button2);
            this.Name = "Form11";
            this.Text = "Office2010Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}