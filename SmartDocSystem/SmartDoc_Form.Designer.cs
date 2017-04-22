namespace SmartDocSystem
{
    partial class SmartDocSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.ToolboxTxtbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Plusbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.mainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DBNameTxtbx = new System.Windows.Forms.TextBox();
            this.DBNamelbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TableNameTxtbx = new System.Windows.Forms.TextBox();
            this.TableNamelbl = new System.Windows.Forms.Label();
            this.FieldGrpBx = new System.Windows.Forms.GroupBox();
            this.DisplayNameTxtbx = new System.Windows.Forms.TextBox();
            this.DisplayFieldNamelbl = new System.Windows.Forms.Label();
            this.RequiredChkbx = new System.Windows.Forms.CheckBox();
            this.DataTypeDDbx = new System.Windows.Forms.ComboBox();
            this.Datatypelbl = new System.Windows.Forms.Label();
            this.DBFieldNameTxtbx = new System.Windows.Forms.TextBox();
            this.DBFieldNamelbl = new System.Windows.Forms.Label();
            this.FieldGrp = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.FieldGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Title.Location = new System.Drawing.Point(119, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(958, 49);
            this.Title.TabIndex = 1;
            this.Title.TabStop = false;
            this.Title.Text = "Smart Document System";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolboxTxtbx
            // 
            this.ToolboxTxtbx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToolboxTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolboxTxtbx.Location = new System.Drawing.Point(2, 3);
            this.ToolboxTxtbx.Name = "ToolboxTxtbx";
            this.ToolboxTxtbx.Size = new System.Drawing.Size(63, 15);
            this.ToolboxTxtbx.TabIndex = 0;
            this.ToolboxTxtbx.TabStop = false;
            this.ToolboxTxtbx.Text = "Tool Box";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Plusbtn);
            this.panel1.Controls.Add(this.ToolboxTxtbx);
            this.panel1.Location = new System.Drawing.Point(8, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 162);
            this.panel1.TabIndex = 3;
            // 
            // Plusbtn
            // 
            this.Plusbtn.Image = global::SmartDocSystem.Properties.Resources.plus_circular_mini_button_icon_REV;
            this.Plusbtn.Location = new System.Drawing.Point(8, 32);
            this.Plusbtn.Name = "Plusbtn";
            this.Plusbtn.Size = new System.Drawing.Size(45, 45);
            this.Plusbtn.TabIndex = 0;
            this.Plusbtn.TabStop = false;
            this.Plusbtn.UseVisualStyleBackColor = true;
            this.Plusbtn.Click += new System.EventHandler(this.Plusbtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Createbtn.Location = new System.Drawing.Point(728, 550);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Createbtn.Size = new System.Drawing.Size(138, 33);
            this.Createbtn.TabIndex = 5;
            this.Createbtn.Text = "Create Smart Doc";
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelbtn.Location = new System.Drawing.Point(361, 550);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Cancelbtn.Size = new System.Drawing.Size(75, 33);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoScroll = true;
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainLayoutPanel.Controls.Add(this.groupBox3);
            this.mainLayoutPanel.Controls.Add(this.groupBox2);
            this.mainLayoutPanel.Controls.Add(this.FieldGrpBx);
            this.mainLayoutPanel.Location = new System.Drawing.Point(119, 98);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Size = new System.Drawing.Size(958, 446);
            this.mainLayoutPanel.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DBNameTxtbx);
            this.groupBox3.Controls.Add(this.DBNamelbl);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 68);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // DBNameTxtbx
            // 
            this.DBNameTxtbx.Location = new System.Drawing.Point(120, 23);
            this.DBNameTxtbx.Name = "DBNameTxtbx";
            this.DBNameTxtbx.Size = new System.Drawing.Size(328, 22);
            this.DBNameTxtbx.TabIndex = 1;
            // 
            // DBNamelbl
            // 
            this.DBNamelbl.AutoSize = true;
            this.DBNamelbl.Location = new System.Drawing.Point(3, 24);
            this.DBNamelbl.Name = "DBNamelbl";
            this.DBNamelbl.Size = new System.Drawing.Size(110, 17);
            this.DBNamelbl.TabIndex = 0;
            this.DBNamelbl.Text = "Database Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TableNameTxtbx);
            this.groupBox2.Controls.Add(this.TableNamelbl);
            this.groupBox2.Location = new System.Drawing.Point(468, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // TableNameTxtbx
            // 
            this.TableNameTxtbx.Location = new System.Drawing.Point(99, 24);
            this.TableNameTxtbx.Name = "TableNameTxtbx";
            this.TableNameTxtbx.Size = new System.Drawing.Size(317, 22);
            this.TableNameTxtbx.TabIndex = 2;
            // 
            // TableNamelbl
            // 
            this.TableNamelbl.AutoSize = true;
            this.TableNamelbl.Location = new System.Drawing.Point(7, 28);
            this.TableNamelbl.Name = "TableNamelbl";
            this.TableNamelbl.Size = new System.Drawing.Size(85, 17);
            this.TableNamelbl.TabIndex = 0;
            this.TableNamelbl.Text = "Table Name";
            // 
            // FieldGrpBx
            // 
            this.FieldGrpBx.Controls.Add(this.DisplayNameTxtbx);
            this.FieldGrpBx.Controls.Add(this.DisplayFieldNamelbl);
            this.FieldGrpBx.Controls.Add(this.RequiredChkbx);
            this.FieldGrpBx.Controls.Add(this.DataTypeDDbx);
            this.FieldGrpBx.Controls.Add(this.Datatypelbl);
            this.FieldGrpBx.Controls.Add(this.DBFieldNameTxtbx);
            this.FieldGrpBx.Controls.Add(this.DBFieldNamelbl);
            this.FieldGrpBx.Location = new System.Drawing.Point(3, 77);
            this.FieldGrpBx.Name = "FieldGrpBx";
            this.FieldGrpBx.Size = new System.Drawing.Size(895, 100);
            this.FieldGrpBx.TabIndex = 0;
            this.FieldGrpBx.TabStop = false;
            this.FieldGrpBx.Text = "Field";
            // 
            // DisplayNameTxtbx
            // 
            this.DisplayNameTxtbx.Location = new System.Drawing.Point(133, 64);
            this.DisplayNameTxtbx.Name = "DisplayNameTxtbx";
            this.DisplayNameTxtbx.Size = new System.Drawing.Size(285, 22);
            this.DisplayNameTxtbx.TabIndex = 4;
            // 
            // DisplayFieldNamelbl
            // 
            this.DisplayFieldNamelbl.AutoSize = true;
            this.DisplayFieldNamelbl.Location = new System.Drawing.Point(17, 65);
            this.DisplayFieldNamelbl.Name = "DisplayFieldNamelbl";
            this.DisplayFieldNamelbl.Size = new System.Drawing.Size(95, 17);
            this.DisplayFieldNamelbl.TabIndex = 6;
            this.DisplayFieldNamelbl.Text = "Display Name";
            // 
            // RequiredChkbx
            // 
            this.RequiredChkbx.AutoSize = true;
            this.RequiredChkbx.Location = new System.Drawing.Point(735, 34);
            this.RequiredChkbx.Name = "RequiredChkbx";
            this.RequiredChkbx.Size = new System.Drawing.Size(88, 21);
            this.RequiredChkbx.TabIndex = 6;
            this.RequiredChkbx.Text = "Required";
            this.RequiredChkbx.UseVisualStyleBackColor = true;
            // 
            // DataTypeDDbx
            // 
            this.DataTypeDDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTypeDDbx.FormattingEnabled = true;
            this.DataTypeDDbx.Items.AddRange(new object[] {
            "String",
            "Integer"});
            this.DataTypeDDbx.Location = new System.Drawing.Point(512, 33);
            this.DataTypeDDbx.Name = "DataTypeDDbx";
            this.DataTypeDDbx.Size = new System.Drawing.Size(135, 24);
            this.DataTypeDDbx.TabIndex = 5;
            // 
            // Datatypelbl
            // 
            this.Datatypelbl.AutoSize = true;
            this.Datatypelbl.Location = new System.Drawing.Point(440, 36);
            this.Datatypelbl.Name = "Datatypelbl";
            this.Datatypelbl.Size = new System.Drawing.Size(65, 17);
            this.Datatypelbl.TabIndex = 2;
            this.Datatypelbl.Text = "Datatype";
            // 
            // DBFieldNameTxtbx
            // 
            this.DBFieldNameTxtbx.Location = new System.Drawing.Point(133, 24);
            this.DBFieldNameTxtbx.Name = "DBFieldNameTxtbx";
            this.DBFieldNameTxtbx.Size = new System.Drawing.Size(285, 22);
            this.DBFieldNameTxtbx.TabIndex = 3;
            // 
            // DBFieldNamelbl
            // 
            this.DBFieldNamelbl.AutoSize = true;
            this.DBFieldNamelbl.Location = new System.Drawing.Point(17, 28);
            this.DBFieldNamelbl.Name = "DBFieldNamelbl";
            this.DBFieldNamelbl.Size = new System.Drawing.Size(110, 17);
            this.DBFieldNamelbl.TabIndex = 0;
            this.DBFieldNamelbl.Text = "Database Name";
            // 
            // FieldGrp
            // 
            this.FieldGrp.Location = new System.Drawing.Point(0, 0);
            this.FieldGrp.Name = "FieldGrp";
            this.FieldGrp.Size = new System.Drawing.Size(200, 100);
            this.FieldGrp.TabIndex = 0;
            this.FieldGrp.TabStop = false;
            // 
            // SmartDocSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Name = "SmartDocSystem";
            this.Text = "SmartDocSystem";
            this.Load += new System.EventHandler(this.SmartDocSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FieldGrpBx.ResumeLayout(false);
            this.FieldGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox ToolboxTxtbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Plusbtn;
        private System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.GroupBox FieldGrp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TableNameTxtbx;
        private System.Windows.Forms.Label TableNamelbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DBNameTxtbx;
        private System.Windows.Forms.Label DBNamelbl;
        private System.Windows.Forms.GroupBox FieldGrpBx;
        private System.Windows.Forms.Label DBFieldNamelbl;
        private System.Windows.Forms.CheckBox RequiredChkbx;
        private System.Windows.Forms.ComboBox DataTypeDDbx;
        private System.Windows.Forms.Label Datatypelbl;
        private System.Windows.Forms.TextBox DBFieldNameTxtbx;
        private System.Windows.Forms.Label DisplayFieldNamelbl;
        private System.Windows.Forms.TextBox DisplayNameTxtbx;
    }
}

