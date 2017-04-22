using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using DocumentFormat.OpenXml.CustomXmlDataProperties;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;
using System.Xml;
using DocumentFormat.OpenXml;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;


namespace SmartDocSystem
{
    class SmartDoc
    {
        static SmartDocConfig sdConfig;
        static Random rndNum = new Random();
        static string xmlDoc;

        public static void MakeSmartDoc(SmartDocConfig config)
        {
            sdConfig = config;
            xmlDoc = config.DatabaseName + "_" + config.TableName + ".xml";

            // Make XML document, make sure there isn't an existing document of the same 
            // name already
            XDocument xdoc = GetXML();
            string dir = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string xmlPath = Path.Combine(dir, xmlDoc);
            if (File.Exists(xmlPath))
            {
                File.Delete(xmlPath);
            }
            xdoc.Save(xmlPath);

            // Make Word document, make sure there isn't an existing document of the same 
            // name already
            string wordDocPath = Path.Combine(dir, "SmartDocForm.docx");
            if (File.Exists(wordDocPath))
            {
                File.Delete(wordDocPath);
            }
            CreateWordDocument(wordDocPath);

            // Merge XML and Word Documents
            using (WordprocessingDocument mydoc = WordprocessingDocument.Open(wordDocPath, true, new OpenSettings()))
            {
                AddCustomXmlParts(mydoc);
                InsertContentControls(mydoc);
            }
        }

        private static void AddCustomXmlParts(WordprocessingDocument doc)
        {
            int customXmlPartsCount = doc.MainDocumentPart.GetPartsCountOfType<CustomXmlPart>();

            if (customXmlPartsCount == 0)
            {
                CreatePersonCustomXmlPart(doc);
            }
        }

        private static void CreatePersonCustomXmlPart(WordprocessingDocument doc)
        {
            CustomXmlPart customXmlPersonDataSourcePart = doc.MainDocumentPart.AddNewPart<CustomXmlPart>("application/xml", "Rcc1ff99d16794c83");
            customXmlPersonDataSourcePart.FeedData(new StreamReader(xmlDoc).BaseStream);


            CustomXmlPropertiesPart customXmlPersonPropertiesDataSourcePart = customXmlPersonDataSourcePart
                                                                              .AddNewPart<CustomXmlPropertiesPart>("Rd3c4172d526e4b2384ade4b889302c76");

            GenerateCustomXmlPropertiesPart1Content(customXmlPersonPropertiesDataSourcePart);
        }


        private static void GenerateCustomXmlPropertiesPart1Content(CustomXmlPropertiesPart customXmlPersonPropertiesDataSourcePart)
        {
            DataStoreItem dataStoreItem1 = new DataStoreItem() { ItemId = "{88e81a45-98c0-4d79-952a-e8203ce59aac}" };
            customXmlPersonPropertiesDataSourcePart.DataStoreItem = dataStoreItem1;
        }

        private static SdtRun CreateContentControl(Run run, SmartDocConfig sdConfig, int fieldCount)
        {

            int id = rndNum.Next(1, 1000000000);
            SdtId sdtId = new SdtId() { Val = id };
            SdtContentText sdtContentText = new SdtContentText();
            SdtProperties sdtProperties = new SdtProperties();
            SdtContentRun sdtContentRun = new SdtContentRun();
            SdtRun sdtRun = new SdtRun();

            DataBinding dataBinding = new DataBinding()
            {
                XPath = "/" + sdConfig.DatabaseName + "/" + sdConfig.TableName + "/" + sdConfig.Fields[fieldCount].FieldName,
                StoreItemId = "{88e81a45-98c0-4d79-952a-e8203ce59aac}"
            };


            sdtProperties.Append(dataBinding);
            sdtProperties.Append(sdtId);
            sdtProperties.Append(sdtContentText);
            sdtContentRun.Append(run);
            sdtRun.Append(sdtProperties);
            sdtRun.Append(sdtContentRun);
            return sdtRun;
        }

        private static void InsertContentControls(WordprocessingDocument doc)
        {
            List<DocumentFormat.OpenXml.Wordprocessing.Paragraph> paragraphs = new List<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
            for (int i = 0; i < sdConfig.Fields.Count; i++)
            {
                DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = MakeParagraph();
                Run run1 = new Run();
                Text text1 = new Text();
                text1.Text = sdConfig.Fields[i].DisplayName;
                if (sdConfig.Fields[i].IsRequired)
                {
                    text1.Text += "*";
                }


                run1.Append(text1);

                Run run2 = new Run();
                TabChar tabChar1 = new TabChar();

                run2.Append(tabChar1);

                Run run3 = new Run() { RsidRunProperties = "00A54401" };
                Text text2 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text2.Text = " ";

                run3.Append(text2);

                Run run4 = new Run();
                Text text3 = new Text();
                text3.Text = "Answer here";
                run4.Append(text3);

                paragraph.Append(run1);
                paragraph.Append(run2);
                paragraph.Append(run3);
                paragraph.Append(CreateContentControl(run4, sdConfig, i));
                paragraphs.Add(paragraph);
            }

            DocumentFormat.OpenXml.Wordprocessing.Paragraph lastParagraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph() { RsidParagraphAddition = "00C91820", RsidRunAdditionDefault = "00965D95" };
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            lastParagraph.Append(bookmarkStart1);
            lastParagraph.Append(bookmarkEnd1);
            paragraphs.Add(lastParagraph);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidR = "00C91820" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1440, Right = (UInt32Value)1440U, Bottom = 1440, Left = (UInt32Value)1440U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            DocumentFormat.OpenXml.Wordprocessing.Columns columns1 = new DocumentFormat.OpenXml.Wordprocessing.Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            foreach (DocumentFormat.OpenXml.Wordprocessing.Paragraph p in paragraphs)
            {
                doc.MainDocumentPart.Document.Append(p);
            }

            doc.MainDocumentPart.Document.Append(sectionProperties1);
        }

        private static DocumentFormat.OpenXml.Wordprocessing.Paragraph MakeParagraph()
        {
            DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph()
            {
                RsidParagraphMarkRevision = "00A54401",
                RsidParagraphAddition = "00965D95",
                RsidParagraphProperties = "00965D95",
                RsidRunAdditionDefault = "00965D95"
            };

            return paragraph;
        }


        //Make XML document from form fields
        public static XDocument GetXML()
        {

            if (sdConfig != null)
            {
                XDocument xdoc =
                    new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement(sdConfig.DatabaseName,
                        new XAttribute("SDTemplate", xmlDoc),
                            new XElement(sdConfig.TableName,
                                from field in sdConfig.Fields
                                select GetFieldToXML(field).Elements())));
                return xdoc;
            }
            XDocument doc = new XDocument();
            return doc;
        }

        private static XDocument GetFieldToXML(Field field)
        {
            XDocument xdoc =
                new XDocument(
                    new XElement(field.FieldName,
                    new XAttribute("Datatype", field.DataType),
                    new XAttribute("Required", field.IsRequired),
                    new XAttribute("DisplayName", field.DisplayName), "Your Answer here"));
            return xdoc;
        }

        private static void CreateWordDocument(string path)
        {

            //Create an instance for word app
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //Set animation status for word application
            winword.ShowAnimation = false;

            //Set status for word application is to be visible or not.
            winword.Visible = false;

            //Create a missing variable for missing value
            object missing = System.Reflection.Missing.Value;

            //Create a new document
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            document.SaveAs2(path);
            document.Close(ref missing, ref missing, ref missing);
            winword.Quit(ref missing, ref missing, ref missing);
        }


    }
}
