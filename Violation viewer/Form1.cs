using System;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Violation_viewer
{
    public partial class UI : Form
    {

        public UI()
        {
            InitializeComponent();

            string folders = Application.StartupPath.ToString();
            SelectFolder.Text = folders;
            FolderSave.Text = folders;
        }


        List<String> ListFiles = new List<String>();

        void ReadFolder(string path)
        {
            ListFiles.AddRange(Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories));
            listName.Items.AddRange(Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories));
        }

        void UI_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void Select_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = SelectFolder.Text;
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {

                SelectFolder.Text = dialog.FileName;
            }
        }

        void SelectFolderSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = FolderSave.Text;
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderSave.Text = dialog.FileName;
            }
        }

        void SaveViolation(string pathXML, string saveFolder)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathXML);

            if (xDoc.SelectSingleNode("//v_type_photo") == null)
            {
                FileInfo fil;

                XmlNodeList violation_check_time = xDoc.GetElementsByTagName("v_time_check");
                string data = violation_check_time[0].InnerText.Remove(violation_check_time[0].InnerText.IndexOf("T"));

                XmlNodeList violation_camera = xDoc.GetElementsByTagName("v_camera");
                XmlNodeList violation_regno = xDoc.GetElementsByTagName("v_regno");
                XmlNodeList violation_pr_viol = xDoc.GetElementsByTagName("v_pr_viol");
                XmlNodeList violation_photo_ts = xDoc.GetElementsByTagName("v_photo_ts");
                XmlNodeList violation_type_photo = xDoc.GetElementsByTagName("v_type_photo");
                XmlNodeList violation_photo_extra = xDoc.GetElementsByTagName("v_photo_extra");

                DirectoryInfo dirInfo = new DirectoryInfo(saveFolder + "\\" + data);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                string fileName = "\\" + data + "\\" + violation_camera[0].InnerText + "_" + violation_pr_viol[0].InnerText + " " + violation_regno[0].InnerText;

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
            else
            {

                MessageBox.Show("123", "67", MessageBoxButtons.OK);
            }
        }

        void ViewerIMG(string pathXML)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathXML);

            XmlNodeList img = xDoc.GetElementsByTagName("v_photo_ts");

            imdBox.SizeMode = PictureBoxSizeMode.CenterImage;
            imdBox.SizeMode = PictureBoxSizeMode.Zoom;

            var bytes = Convert.FromBase64String(img[0].InnerText);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            Image image = Image.FromStream(ms, true);
            ms.Close();
            GC.Collect();

            imdBox.Image = image;
        }

        void UI_DragDrop(object sender, DragEventArgs e)
        {
            //Panel.CreateGraphics().Clear(SystemColors.Control);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(files[0]);

         

        }

        void SaveCurrent_Click(object sender, EventArgs e)
        {

            string pathXML = "D:\\Duplo\\2345678\\О261ХР161_000204_message.xml";

            SaveViolation(pathXML, FolderSave.Text);
        }
    }
}
