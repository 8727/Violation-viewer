using System;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Violation_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D:\\Duplo\\2345678\\В234НВ134_000208_message.xml");

            XmlNodeList girlAddress = xDoc.GetElementsByTagName("v_camera");
            XmlNodeList pic = xDoc.GetElementsByTagName("v_photo_ts");

            this.label1.Text = girlAddress[0].InnerText;

            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            // Convert Base64 to Image
            var bytes = Convert.FromBase64String(pic[0].InnerText);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            Image image = Image.FromStream(ms, true);
            ms.Close();
            GC.Collect();

            pictureBox1.Image = image;

        }

    }
}
