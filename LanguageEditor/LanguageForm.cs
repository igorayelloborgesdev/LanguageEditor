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
            string path = saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!isFileLoaded)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml("<languages></languages>");
                    XmlElement newElem = doc.CreateElement("language");
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
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(path);
                    XmlElement newelem = xmldoc.CreateElement("language");
                    XmlElement elemEng = xmldoc.CreateElement("english");
                    XmlElement elemPort = xmldoc.CreateElement("portuguese");
                    elemEng.InnerText = EnglishKey.Text;
                    elemPort.InnerText = PortugueseKey.Text;
                    newelem.AppendChild(elemEng);
                    newelem.AppendChild(elemPort);
                    xmldoc.DocumentElement.InsertAfter(newelem, xmldoc.DocumentElement.LastChild);
                    xmldoc.PreserveWhitespace = true;
                    xmldoc.Save(path);
                }
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
                }
            }
            catch {
                isFileLoaded = false;
                MessageBox.Show("ERROR. Could not load File");
            }
            
        }
    }
}
