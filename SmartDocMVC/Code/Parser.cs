using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;


using DocumentFormat;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using SmartDocMVC.Models;


namespace SmartDocMVC.Code
{
    public class Parser
    {
        public string Filename { get; set; }
        public XmlDocument doc = new XmlDocument();
        string templateName;

        public Parser(string filename)
        {
            this.Filename = filename;

        }



        public string GetXML(string xdoc = null)
        {
            if (xdoc == null)
            {
                doc.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLTemplates/" + templateName));
            }
            else
            {
                doc.LoadXml(xdoc);
            }

            string text = doc.DocumentElement.Name;
            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {
                text = text + ", " + root.Name.Trim();

                foreach (XmlNode node in root.ChildNodes)
                {
                    text = text + ", " + node.Name.Trim();

                }
            }
            return text;

        }

        public List<FieldValues> GetValues(string xdoc)
        {
            List<FieldValues> fieldValues = new List<FieldValues>();
            doc.LoadXml(xdoc);

            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    string fieldName = node.Attributes["DisplayName"]?.InnerText.Trim();
                    string value = node.InnerText;
                    FieldValues fieldValue = new FieldValues(fieldName, value);
                    fieldValues.Add(fieldValue);
                }
            }


            return fieldValues;

        }

        public List<FieldAttributes> GetFields()
        {
            doc.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLTemplates/" + templateName));
            List<FieldAttributes> fields = new List<FieldAttributes>();

            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {

                foreach (XmlNode node in root.ChildNodes)
                {
                    bool isRequired;
                    string dataType = node.Attributes["Datatype"]?.InnerText;
                    string Required = node.Attributes["Required"]?.InnerText;
                    isRequired = Required.Equals("true");
                    string fieldName = node.Attributes["DisplayName"]?.InnerText.Trim();
                    FieldAttributes field = new FieldAttributes(fieldName, dataType, isRequired);
                    fields.Add(field);
                }
            }
            return fields;

        }




        private XDocument GetCustomXmlPartAsXDocument(MainDocumentPart mainDocumentPart, string aznamespace = "")
        {
            if (mainDocumentPart == null)
            {
                throw new ArgumentNullException("mainDocumentPart");
            }

            XDocument result = null;

            foreach (CustomXmlPart part in mainDocumentPart.CustomXmlParts)
            {
                using (XmlTextReader reader = new XmlTextReader(part.GetStream(FileMode.Open, FileAccess.Read)))
                {
                    reader.MoveToContent();

                    var s = reader.ReadOuterXml();
                    result = XDocument.Parse(s);
                    break;
                }
            }

            return result;
        }


        public XDocument ReadCustomXmlDoc()
        {
            XDocument xdoc = new XDocument();

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(this.Filename, false))
            {
                MainDocumentPart mainPart = wordDoc.MainDocumentPart;
                // Just get the first one with the namespace of interest.
                xdoc = GetCustomXmlPartAsXDocument(mainPart);
            }

            return xdoc;
        }

        public void GetTemplateName(XDocument xdoc)
        {
            string tName = "";
            try
            {
                tName = xdoc.Root.Attribute("SDTemplate").Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            templateName = tName;
        }



    }
}
