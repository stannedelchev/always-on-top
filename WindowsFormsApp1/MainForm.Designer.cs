namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.ListBoxWindows = new System.Windows.Forms.ListBox();
            this.buttonTopmost = new System.Windows.Forms.Button();
            this.buttonNonTopmost = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxWindows
            // 
            this.ListBoxWindows.DisplayMember = "Title";
            this.ListBoxWindows.FormattingEnabled = true;
            this.ListBoxWindows.Location = new System.Drawing.Point(12, 12);
            this.ListBoxWindows.Name = "ListBoxWindows";
            this.ListBoxWindows.Size = new System.Drawing.Size(455, 407);
            this.ListBoxWindows.Sorted = true;
            this.ListBoxWindows.TabIndex = 0;
            // 
            // buttonTopmost
            // 
            this.buttonTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTopmost.Location = new System.Drawing.Point(478, 11);
            this.buttonTopmost.Name = "buttonTopmost";
            this.buttonTopmost.Size = new System.Drawing.Size(184, 88);
            this.buttonTopmost.TabIndex = 1;
            this.buttonTopmost.Text = "Make TopMost";
            this.buttonTopmost.UseVisualStyleBackColor = true;
            this.buttonTopmost.Click += new System.EventHandler(this.OnButtonTopMostClicked);
            // 
            // buttonNonTopmost
            // 
            this.buttonNonTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNonTopmost.Location = new System.Drawing.Point(478, 105);
            this.buttonNonTopmost.Name = "buttonNonTopmost";
            this.buttonNonTopmost.Size = new System.Drawing.Size(184, 95);
            this.buttonNonTopmost.TabIndex = 2;
            this.buttonNonTopmost.Text = "Make NonTopMost";
            this.buttonNonTopmost.UseVisualStyleBackColor = true;
            this.buttonNonTopmost.Click += new System.EventHandler(this.OnButtonNonTopmostClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(478, 382);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(184, 35);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh Windows List";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.OnButtonRefreshClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 429);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNonTopmost);
            this.Controls.Add(this.buttonTopmost);
            this.Controls.Add(this.ListBoxWindows);
            this.Name = "MainForm";
            this.Text = "Set TopMost Window";
            this.Load += new System.EventHandler(this.OnMainFormLoaded);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTopmost;
        private System.Windows.Forms.Button buttonNonTopmost;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.ListBox ListBoxWindows;
    }
}

