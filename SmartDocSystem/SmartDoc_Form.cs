using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartDocSystem
{
    public partial class SmartDocSystem : Form
    {
        public SmartDocSystem()
        {
            InitializeComponent();
            //GroupBox fieldgrp = CreateGroupBox();
            //this.mainLayoutPanel.Controls.Add(fieldgrp);
        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            GroupBox fieldgrp = CreateGroupBox();
            this.mainLayoutPanel.Controls.Add(fieldgrp);

        }

        private GroupBox CreateGroupBox()
        {
            GroupBox newGrpBox = new GroupBox();
            CheckBox RequiredChkbx = new CheckBox();
            Label DatatypeLbl = new Label();
            ComboBox DataTypeDDbx = new ComboBox();
            TextBox DBFieldNameTxtbx = new TextBox();
            Label DBFieldNamelbl = new Label();
            TextBox DisplayNameTxtbx = new TextBox();
            Label DisplayFieldNamelbl = new Label();

            // 
            // checkBox1
            // 
            RequiredChkbx.AutoSize = true;
            RequiredChkbx.Location = new System.Drawing.Point(550, 37);
            RequiredChkbx.Name = "RequiredChkbx";
            RequiredChkbx.Size = new System.Drawing.Size(122, 21);
            RequiredChkbx.TabIndex = 6;
            RequiredChkbx.Text = "Required";
            RequiredChkbx.UseVisualStyleBackColor = true;


            // 
            // label2
            // 
            DatatypeLbl.AutoSize = true;
            DatatypeLbl.Location = new System.Drawing.Point(330, 41);
            DatatypeLbl.Name = "DatatypeLbl";
            DatatypeLbl.Size = new System.Drawing.Size(69, 17);
            DatatypeLbl.TabIndex = 0;
            DatatypeLbl.Text = "Datatype";
            // 
            // comboBox2
            // 
            DataTypeDDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DataTypeDDbx.FormattingEnabled = true;
            DataTypeDDbx.Items.AddRange(new object[] {
            "String",
            "Integer"});
            DataTypeDDbx.Location = new System.Drawing.Point(383, 39);
            DataTypeDDbx.Name = "DataTypeDDbx";
            DataTypeDDbx.Size = new System.Drawing.Size(105, 24);
            DataTypeDDbx.TabIndex = 5;
            // 
            // textBox2
            // 
            DBFieldNameTxtbx.Location = new System.Drawing.Point(100, 34);
            DBFieldNameTxtbx.Name = "DBFieldNameTxtbx";
            DBFieldNameTxtbx.Size = new System.Drawing.Size(215, 22);
            DBFieldNameTxtbx.TabIndex = 3;
            // 
            // label3
            // 
            DBFieldNamelbl.AutoSize = true;
            DBFieldNamelbl.Location = new System.Drawing.Point(12, 37);
            DBFieldNamelbl.Name = "DBFieldNamelbl";
            DBFieldNamelbl.Size = new System.Drawing.Size(79, 17);
            DBFieldNamelbl.TabIndex = 0;
            DBFieldNamelbl.Text = "Database Name";

            // 
            // DisplayFieldNamelbl
            // 
            DisplayFieldNamelbl.AutoSize = true;
            DisplayFieldNamelbl.Location = new System.Drawing.Point(12, 65);
            DisplayFieldNamelbl.Name = "DisplayFieldNamelbl";
            DisplayFieldNamelbl.Size = new System.Drawing.Size(79, 17);
            DisplayFieldNamelbl.TabIndex = 0;
            DisplayFieldNamelbl.Text = "Display Name";
            // 
            // DisplayNameTxtbx
            // 
            DisplayNameTxtbx.Location = new System.Drawing.Point(100, 64);
            DisplayNameTxtbx.Name = "DisplayNameTxtbx";
            DisplayNameTxtbx.Size = new System.Drawing.Size(215, 22);
            DisplayNameTxtbx.TabIndex = 4;

            // 
            // FieldGrp
            // 
            newGrpBox.Controls.Add(DatatypeLbl);
            newGrpBox.Controls.Add(DataTypeDDbx);
            newGrpBox.Controls.Add(DBFieldNameTxtbx);
            newGrpBox.Controls.Add(DBFieldNamelbl);
            newGrpBox.Controls.Add(RequiredChkbx);
            newGrpBox.Controls.Add(DisplayNameTxtbx);
            newGrpBox.Controls.Add(DisplayFieldNamelbl);
            newGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            newGrpBox.Location = new System.Drawing.Point(3, 77);
            newGrpBox.Name = "FieldGrp";
            newGrpBox.Size = new System.Drawing.Size(670, 100);
            newGrpBox.TabIndex = 0;
            newGrpBox.TabStop = false;
            newGrpBox.Text = "Field";
            return newGrpBox;
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            // Validate that form has been fully filled out
            bool isFilledOut = true;

            // Gather field values
            var DBNameTxtbxArr = this.Controls.Find("DBNameTxtbx", true);
            var TableNameTxtbxArr = this.Controls.Find("TableNameTxtbx", true);
            var URLTxtbxArr = this.Controls.Find("URLtxtbx", true);
            var DisplayNameTxtbxArr = this.Controls.Find("DisplayNameTxtbx", true);
            var DBFieldNameTxtbxArr = this.Controls.Find("DBFieldNameTxtbx", true);
            var DataTypeDDbxArr = this.Controls.Find("DataTypeDDbx", true);
            var IsRequiredChkbxArr = this.Controls.Find("RequiredChkbx", true);

            foreach (var elem in DBNameTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }

            foreach (var elem in DisplayNameTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in URLTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in TableNameTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in DataTypeDDbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in DBFieldNameTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }

            if (isFilledOut)
            {
                // Make smart doc
                List<Field> fields = new List<Field>();
                for (int i = 0; i < DisplayNameTxtbxArr.Length; i++)
                {
                    Field field = new Field();
                    field.DisplayName = DisplayNameTxtbxArr[i].Text;
                    field.DataType = DataTypeDDbxArr[i].Text;
                    field.FieldName = DBFieldNameTxtbxArr[i].Text;
                    field.IsRequired = ((CheckBox)IsRequiredChkbxArr[i]).Checked;
                    fields.Add(field);

                }
                SmartDocConfig smartDocConfig = new SmartDocConfig(fields, DBNameTxtbxArr[0].Text, TableNameTxtbxArr[0].Text);
                SmartDoc.MakeSmartDoc(smartDocConfig);

            }
            else
            {
                MessageBox.Show("You DID NOT correctly filled out the form!");
            }
        }



        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SmartDocSystem_Load(object sender, EventArgs e)
        {

        }
    }


    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
