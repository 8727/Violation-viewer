using System;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace Violation_viewer
{
    public partial class UI : Form
    {

        public UI()
        {
            InitializeComponent();


        }
        List<String> ListFiles = new List<String>();

        void ReadFolder(string path)
        {
            ListFiles.AddRange(Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories));
            listName.Items.AddRange(Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories));
        }

        void SaveViolation(string pathXML1, string saveFolder1)
        {
            string pathXML = "D:\\Duplo\\2345678\\О261ХР161_000204_message.xml";
            string saveFolder = "D:\\Duplo";


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathXML);

            XmlNodeList violation_check_time = xDoc.GetElementsByTagName("v_time_check");
            string data = violation_check_time[0].InnerText.Remove(violation_check_time[0].InnerText.IndexOf("T"));
            if (true)
            {
                FileInfo fil;

                XmlNodeList violation_camera = xDoc.GetElementsByTagName("v_camera");
                XmlNodeList violation_regno = xDoc.GetElementsByTagName("v_regno");
                XmlNodeList violation_pr_viol = xDoc.GetElementsByTagName("v_pr_viol");
                XmlNodeList violation_photo_ts = xDoc.GetElementsByTagName("v_photo_ts");
                XmlNodeList violation_type_photo = xDoc.GetElementsByTagName("v_type_photo");
                XmlNodeList violation_photo_extra = xDoc.GetElementsByTagName("v_photo_extra");


                string fileName = "\\" + data + "_" + violation_camera[0].InnerText + "_" + violation_pr_viol[0].InnerText + "_" + violation_regno[0].InnerText;

                var bytes = Convert.FromBase64String(violation_photo_ts[0].InnerText);

                fil = new FileInfo(saveFolder + fileName + ".jpg");
                using (Stream sw = fil.OpenWrite())
                {
                    sw.Write(bytes, 0, bytes.Length);
                    sw.Close();
                }

                GC.Collect();

                int index = violation_type_photo.Count;

                while (index > 0)
                {
                    bytes = Convert.FromBase64String(violation_photo_extra[index - 1].InnerText);

                    switch (violation_type_photo[index-1].InnerText)
                    {
                        case "0":
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                        case "1":
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                        case "2":
                            fil = new FileInfo(saveFolder + fileName + "_Video_" + index + ".webm");
                            break;
                        case "3":
                            fil = new FileInfo(saveFolder + fileName + "_Video_" + index + ".mp4");
                            break;
                        case "4":
                            fil = new FileInfo(saveFolder + fileName + "_PDF_" + index + ".pdf");
                            break;
                        case "5":
                            fil = new FileInfo(saveFolder + fileName + "_XML_" + index + ".xml");
                            break;
                        default:
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                    }

                    using (Stream sw = fil.OpenWrite())
                    {
                        sw.Write(bytes, 0, bytes.Length);
                        sw.Close();
                    }
                    GC.Collect();

                    index--;
                }
      
            }

        }
        void Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                SelectFolder.Text = FBD.SelectedPath;
                ReadFolder(FBD.SelectedPath);

            }


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog.Filter = "Firmware(*.xml) | *.xml";
                //openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {



                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(openFileDialog.FileName);

                    XmlNodeList girlAddress = xDoc.GetElementsByTagName("v_camera");
                    XmlNodeList pic = xDoc.GetElementsByTagName("v_photo_ts");

                    //this.label1.Text = girlAddress[0].InnerText;



                    imdBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    imdBox.SizeMode = PictureBoxSizeMode.Zoom;


                    // Convert Base64 to Image
                    var bytes = Convert.FromBase64String(pic[0].InnerText);
                    MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
                    ms.Write(bytes, 0, bytes.Length);
                    Image image = Image.FromStream(ms, true);


                    imdBox.Image = image;

                    string saveFolder = "D:\\Duplo\\" + girlAddress[0].InnerText + "456.jpg";
                    image.Save(saveFolder, ImageFormat.Jpeg);

                    ms.Close();
                    GC.Collect();

                }
            }






        }

        void UI_DragDrop(object sender, DragEventArgs e)
        {
            //Panel.CreateGraphics().Clear(SystemColors.Control);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(files[0]);

            XmlNodeList girlAddress = xDoc.GetElementsByTagName("v_camera");
            XmlNodeList pic = xDoc.GetElementsByTagName("v_photo_ts");

            //this.label1.Text = girlAddress[0].InnerText;

            imdBox.SizeMode = PictureBoxSizeMode.CenterImage;
            imdBox.SizeMode = PictureBoxSizeMode.Zoom;


            // Convert Base64 to Image
            var bytes = Convert.FromBase64String(pic[0].InnerText);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            Image image = Image.FromStream(ms, true);
            ms.Close();
            GC.Collect();

            imdBox.Image = image;

        }

        private void SaveCurrent_Click(object sender, EventArgs e)
        {
            SaveViolation("rty", "rtyu");
        }

        void UI_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

/*            Pen pen = new Pen(Color.Black, 2);
            Graphics g = Panel.CreateGraphics();
            pen.DashPattern = new float[] { 10, 10 };

            g.DrawRectangle(pen, 1, 1, Panel.Width - 4, Panel.Height - 4);*/
        }

/*        void panel1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.Black, 2);
            pen.DashPattern = new float[] { 10, 10 };
            e.Graphics.DrawRectangle(pen, 1, 1, Panel.Width - 4, Panel.Height - 4);
        }*/
    }
}
