namespace Browser_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com/baki.ykr?igsh=eGtjOTdlMnE5bWFq");
        }



        private void gmailButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("abdulbaki.yakar@gmail.com");
            ToolTip tt = new ToolTip();
            tt.SetToolTip(gmailButton, "E-posta adresinizi panoya kopyalamak için týklayýn");


        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://github.com/llYakarll/SuperZone-Full.git");
        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://x.com/bakiykr?t=ls3WisYVtMUSFMWnwRyUlg&s=09");

        }

        private void youtubeButton_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=bGWg3ktf0cw");
        }

       

        private void webSiteButton_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.alperbugradev.com/");
        }
    }
}
