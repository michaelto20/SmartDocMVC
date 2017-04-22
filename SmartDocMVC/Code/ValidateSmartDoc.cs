using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDocMVC.Model;
using SmartDocMVC.Data;


namespace SmartDocMVC.Code
{
    public class ValidateSmartDoc
    {
        public static Student ParseSmartDoc(string smartDocFileName)
        {
            
            try
            {
                // Read a docx file and parse it.
                string doc1 = "";
                string doc2 = "";

                // Get Smart Doc path from uploads folder
                var sdfname = HttpContext.Current.Server.MapPath("~/App_Data/Upload/") + smartDocFileName;

                // Get SmartDoc values
                Parser sdParser = new Parser(sdfname);
                XDocument xdoc = sdParser.ReadCustomXmlDoc();
                doc2 = sdParser.GetXML(xdoc.ToString());

                // Test database
                //SmartDocSystem.Student st = new SmartDocSystem.Student();

                // Get Smart Doc Template Name
                sdParser.GetTemplateName(xdoc);

                // Get fields from template
                doc1 = sdParser.GetXML();



                if (doc1.Equals(doc2))
                {

                    List<FieldAttribute> fieldAttributes = sdParser.GetFields();
                    List<FieldValue> fieldValues = sdParser.GetValues(xdoc.ToString());

                    if (CompareXML(fieldValues, fieldAttributes))
                    {
                        return Preview(fieldValues);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
            //return "Could not validate your document.";
        }

        public static bool CompareXML(List<FieldValue> fieldValues, List<FieldAttribute> fieldAttributes)
        {
            for (int i = 0; i < fieldValues.Count; i++)
            {
                if (fieldValues[i].Name.Equals(fieldAttributes[i].FieldName))
                {
                    if (fieldAttributes[i].IsRequired && String.IsNullOrWhiteSpace(fieldValues[i].Value))
                    {
                        return false;
                    }
                    int num;
                    if (fieldAttributes[i].DataType.Equals("Integer") && !int.TryParse(fieldValues[i].Value, out num))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static Student Preview(List<FieldValue> fieldValues)
        {
            //string text = "";

            //for (int i = 0; i < fieldValues.Count && i < 3; i++)
            //{
            //   text = text + fieldValues[i].Name + ": " + fieldValues[i].Value + "\\n";
            //}
            //return text;
            return new Student(fieldValues[0].Value,fieldValues[1].Value,Convert.ToInt32(fieldValues[2].Value));
        }
    }
}
