namespace Browser_App
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            webSiteButton = new Button();
            gmailButton = new Button();
            youtubeButton = new Button();
            twitterButton = new Button();
            instagramButton = new Button();
            githubButton = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(1590, 674);
            webView21.Source = new Uri("https://www.alperbugradev.com/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Controls.Add(webSiteButton);
            panel1.Controls.Add(gmailButton);
            panel1.Controls.Add(youtubeButton);
            panel1.Controls.Add(twitterButton);
            panel1.Controls.Add(instagramButton);
            panel1.Controls.Add(githubButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 549);
            panel1.Name = "panel1";
            panel1.Size = new Size(1590, 125);
            panel1.TabIndex = 2;
            // 
            // webSiteButton
            // 
            webSiteButton.Image = SocailMedia_Resource.globe_solid_full__1_;
            webSiteButton.ImageAlign = ContentAlignment.MiddleRight;
            webSiteButton.Location = new Point(25, 40);
            webSiteButton.Name = "webSiteButton";
            webSiteButton.Size = new Size(145, 40);
            webSiteButton.TabIndex = 5;
            webSiteButton.Text = "WEB Site";
            webSiteButton.TextAlign = ContentAlignment.MiddleLeft;
            webSiteButton.UseVisualStyleBackColor = true;
            webSiteButton.Click += webSiteButton_Click;
            // 
            // gmailButton
            // 
            gmailButton.Cursor = Cursors.Hand;
            gmailButton.Image = SocailMedia_Resource.envelope_solid_full__1_;
            gmailButton.ImageAlign = ContentAlignment.MiddleRight;
            gmailButton.Location = new Point(191, 40);
            gmailButton.Name = "gmailButton";
            gmailButton.Size = new Size(145, 40);
            gmailButton.TabIndex = 4;
            gmailButton.Text = "Gmail";
            gmailButton.TextAlign = ContentAlignment.MiddleLeft;
            gmailButton.UseVisualStyleBackColor = true;
            gmailButton.Click += gmailButton_Click;
            // 
            // youtubeButton
            // 
            youtubeButton.Cursor = Cursors.Hand;
            youtubeButton.Image = SocailMedia_Resource.youtube_brands_solid_full;
            youtubeButton.ImageAlign = ContentAlignment.MiddleRight;
            youtubeButton.Location = new Point(853, 40);
            youtubeButton.Name = "youtubeButton";
            youtubeButton.Size = new Size(145, 40);
            youtubeButton.TabIndex = 3;
            youtubeButton.Text = "Youtube";
            youtubeButton.TextAlign = ContentAlignment.MiddleLeft;
            youtubeButton.UseVisualStyleBackColor = true;
            youtubeButton.Click += youtubeButton_Click;
            // 
            // twitterButton
            // 
            twitterButton.Cursor = Cursors.Hand;
            twitterButton.Image = SocailMedia_Resource.x_twitter_brands_solid_full;
            twitterButton.ImageAlign = ContentAlignment.MiddleRight;
            twitterButton.Location = new Point(687, 40);
            twitterButton.Name = "twitterButton";
            twitterButton.Size = new Size(145, 40);
            twitterButton.TabIndex = 2;
            twitterButton.Text = "X(Twitter)";
            twitterButton.TextAlign = ContentAlignment.MiddleLeft;
            twitterButton.UseVisualStyleBackColor = true;
            twitterButton.Click += twitterButton_Click;
            // 
            // instagramButton
            // 
            instagramButton.Cursor = Cursors.Hand;
            instagramButton.Image = SocailMedia_Resource.instagram_brands_solid_full;
            instagramButton.ImageAlign = ContentAlignment.MiddleRight;
            instagramButton.Location = new Point(518, 40);
            instagramButton.Name = "instagramButton";
            instagramButton.Size = new Size(145, 40);
            instagramButton.TabIndex = 1;
            instagramButton.Text = "Instagram";
            instagramButton.TextAlign = ContentAlignment.MiddleLeft;
            instagramButton.UseVisualStyleBackColor = true;
            instagramButton.Click += button2_Click;
            // 
            // githubButton
            // 
            githubButton.Cursor = Cursors.Hand;
            githubButton.Image = SocailMedia_Resource.github_brands_solid_full__1_;
            githubButton.ImageAlign = ContentAlignment.MiddleRight;
            githubButton.Location = new Point(357, 40);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(145, 40);
            githubButton.TabIndex = 0;
            githubButton.Text = "GitHub";
            githubButton.TextAlign = ContentAlignment.MiddleLeft;
            githubButton.UseVisualStyleBackColor = true;
            githubButton.Click += githubButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 674);
            Controls.Add(panel1);
            Controls.Add(webView21);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browser App";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Panel panel1;
        private Button youtubeButton;
        private Button twitterButton;
        private Button instagramButton;
        private Button githubButton;
        private Button gmailButton;
        private Button webSiteButton;
    }
}
