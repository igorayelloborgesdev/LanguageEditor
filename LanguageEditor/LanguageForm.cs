using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LanguageEditor
{
    public partial class LanguageForm : Form
    {
        bool isFileLoaded = false;
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void filepath_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Data Files (*.xml)|*.xml";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.AddExtension = true;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    if (!isFileLoaded)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml("<languages></languages>");
                        XmlElement newElem = doc.CreateElement("language");
                        newElem.SetAttribute("id", "0");
                        XmlElement elemEng = doc.CreateElement("english");
                        XmlElement elem1 = doc.CreateElement("portuguese");
                        elemEng.InnerText = EnglishKey.Text;
                        elem1.InnerText = PortugueseKey.Text;
                        newElem.AppendChild(elemEng);
                        newElem.AppendChild(elem1);
                        doc.DocumentElement.AppendChild(newElem);
                        doc.PreserveWhitespace = true;
                        doc.Save(path);
                    }
                    else
                    {
                        var value = XDocument.Load(path).Descendants("language").Last().Attribute("id").Value;
                        int id = Int32.Parse(value);
                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(path);
                        XmlElement newElem = xmldoc.CreateElement("language");
                        newElem.SetAttribute("id", (id + 1).ToString());
                        XmlElement elemEng = xmldoc.CreateElement("english");
                        XmlElement elemPort = xmldoc.CreateElement("portuguese");
                        elemEng.InnerText = EnglishKey.Text;
                        elemPort.InnerText = PortugueseKey.Text;
                        newElem.AppendChild(elemEng);
                        newElem.AppendChild(elemPort);
                        xmldoc.DocumentElement.InsertAfter(newElem, xmldoc.DocumentElement.LastChild);
                        xmldoc.PreserveWhitespace = true;
                        xmldoc.Save(path);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR. Could not save File");
            }
        }

        private void Loadfile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            try{
                if (result == DialogResult.OK)
                {
                    string strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                    XDocument doc = XDocument.Load(strfilename);
                    isFileLoaded = true;
                    MessageBox.Show("File succesful loaded");
                    fileLoaded.Text = strfilename;
                }
            }
            catch {
                isFileLoaded = false;
                MessageBox.Show("ERROR. Could not load File");
            }
            
        }
    }
}
