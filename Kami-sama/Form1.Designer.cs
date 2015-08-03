namespace Kami_sama
{
    partial class Kami
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
            this.panelbtn = new System.Windows.Forms.Panel();
            this.buttonGodMode = new System.Windows.Forms.Button();
            this.linkQVDK = new System.Windows.Forms.LinkLabel();
            this.panelbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbtn
            // 
            this.panelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtn.AutoSize = true;
            this.panelbtn.Controls.Add(this.buttonGodMode);
            this.panelbtn.Location = new System.Drawing.Point(0, -1);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(284, 122);
            this.panelbtn.TabIndex = 0;
            // 
            // buttonGodMode
            // 
            this.buttonGodMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGodMode.Location = new System.Drawing.Point(0, 0);
            this.buttonGodMode.Name = "buttonGodMode";
            this.buttonGodMode.Size = new System.Drawing.Size(284, 122);
            this.buttonGodMode.TabIndex = 0;
            this.buttonGodMode.Text = "Activer le God Mode";
            this.buttonGodMode.UseVisualStyleBackColor = true;
            this.buttonGodMode.Click += new System.EventHandler(this.buttonGodMode_Click);
            // 
            // linkQVDK
            // 
            this.linkQVDK.AutoSize = true;
            this.linkQVDK.Location = new System.Drawing.Point(67, 139);
            this.linkQVDK.Name = "linkQVDK";
            this.linkQVDK.Size = new System.Drawing.Size(157, 13);
            this.linkQVDK.TabIndex = 1;
            this.linkQVDK.TabStop = true;
            this.linkQVDK.Text = "http://qvandekadsye.legtux.org";
            this.linkQVDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Kami
            // 
            this.Icon = Properties.Resources.IconKami;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.linkQVDK);
            this.Controls.Add(this.panelbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kami";
            this.Text = "Kami-sama";
            this.panelbtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Button buttonGodMode;
        private System.Windows.Forms.LinkLabel linkQVDK;
    }
}

