namespace OOP_LAB_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputWindow = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateObjectBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CommercialRadioBtn = new System.Windows.Forms.RadioButton();
            this.MilitaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CodeIATAInput = new System.Windows.Forms.TextBox();
            this.MaintananceCostInput = new System.Windows.Forms.NumericUpDown();
            this.EmployeeNumberInput = new System.Windows.Forms.NumericUpDown();
            this.PlanesNumberInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearObjectsListBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PrintObjectsBtn = new System.Windows.Forms.Button();
            this.ClearOutputBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintananceCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesNumberInput)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputWindow.Location = new System.Drawing.Point(6, 22);
            this.OutputWindow.Multiline = true;
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(500, 398);
            this.OutputWindow.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.OutputWindow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окно вывода";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CreateObjectBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CommercialRadioBtn);
            this.groupBox2.Controls.Add(this.MilitaryRadioBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NameInput);
            this.groupBox2.Controls.Add(this.CodeIATAInput);
            this.groupBox2.Controls.Add(this.MaintananceCostInput);
            this.groupBox2.Controls.Add(this.EmployeeNumberInput);
            this.groupBox2.Controls.Add(this.PlanesNumberInput);
            this.groupBox2.Location = new System.Drawing.Point(544, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание аэропорта";
            // 
            // CreateObjectBtn
            // 
            this.CreateObjectBtn.Location = new System.Drawing.Point(6, 215);
            this.CreateObjectBtn.Name = "CreateObjectBtn";
            this.CreateObjectBtn.Size = new System.Drawing.Size(167, 32);
            this.CreateObjectBtn.TabIndex = 13;
            this.CreateObjectBtn.Text = "Создать";
            this.CreateObjectBtn.UseVisualStyleBackColor = true;
            this.CreateObjectBtn.Click += new System.EventHandler(this.CreateObjectBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип";
            // 
            // CommercialRadioBtn
            // 
            this.CommercialRadioBtn.AutoSize = true;
            this.CommercialRadioBtn.Checked = true;
            this.CommercialRadioBtn.Location = new System.Drawing.Point(255, 203);
            this.CommercialRadioBtn.Name = "CommercialRadioBtn";
            this.CommercialRadioBtn.Size = new System.Drawing.Size(109, 19);
            this.CommercialRadioBtn.TabIndex = 11;
            this.CommercialRadioBtn.TabStop = true;
            this.CommercialRadioBtn.Text = "Коммерческий";
            this.CommercialRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MilitaryRadioBtn
            // 
            this.MilitaryRadioBtn.AutoSize = true;
            this.MilitaryRadioBtn.Location = new System.Drawing.Point(255, 228);
            this.MilitaryRadioBtn.Name = "MilitaryRadioBtn";
            this.MilitaryRadioBtn.Size = new System.Drawing.Size(75, 19);
            this.MilitaryRadioBtn.TabIndex = 10;
            this.MilitaryRadioBtn.Text = "Военный";
            this.MilitaryRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Код ИАТА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ежемесячная стоимость обслуживания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество самолетов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество сотрудников";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(244, 22);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(120, 23);
            this.NameInput.TabIndex = 4;
            // 
            // CodeIATAInput
            // 
            this.CodeIATAInput.Location = new System.Drawing.Point(244, 138);
            this.CodeIATAInput.Name = "CodeIATAInput";
            this.CodeIATAInput.Size = new System.Drawing.Size(120, 23);
            this.CodeIATAInput.TabIndex = 3;
            // 
            // MaintananceCostInput
            // 
            this.MaintananceCostInput.DecimalPlaces = 2;
            this.MaintananceCostInput.Location = new System.Drawing.Point(244, 109);
            this.MaintananceCostInput.Name = "MaintananceCostInput";
            this.MaintananceCostInput.Size = new System.Drawing.Size(120, 23);
            this.MaintananceCostInput.TabIndex = 2;
            // 
            // EmployeeNumberInput
            // 
            this.EmployeeNumberInput.Location = new System.Drawing.Point(244, 51);
            this.EmployeeNumberInput.Name = "EmployeeNumberInput";
            this.EmployeeNumberInput.Size = new System.Drawing.Size(120, 23);
            this.EmployeeNumberInput.TabIndex = 1;
            // 
            // PlanesNumberInput
            // 
            this.PlanesNumberInput.Location = new System.Drawing.Point(244, 80);
            this.PlanesNumberInput.Name = "PlanesNumberInput";
            this.PlanesNumberInput.Size = new System.Drawing.Size(120, 23);
            this.PlanesNumberInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ClearObjectsListBtn);
            this.groupBox3.Controls.Add(this.ExitBtn);
            this.groupBox3.Location = new System.Drawing.Point(544, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Разное";
            // 
            // ClearObjectsListBtn
            // 
            this.ClearObjectsListBtn.Location = new System.Drawing.Point(6, 22);
            this.ClearObjectsListBtn.Name = "ClearObjectsListBtn";
            this.ClearObjectsListBtn.Size = new System.Drawing.Size(167, 32);
            this.ClearObjectsListBtn.TabIndex = 1;
            this.ClearObjectsListBtn.Text = "Очистить список объектов";
            this.ClearObjectsListBtn.UseVisualStyleBackColor = true;
            this.ClearObjectsListBtn.Click += new System.EventHandler(this.ClearObjectsListBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(215, 22);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(167, 32);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.PrintObjectsBtn);
            this.groupBox4.Controls.Add(this.ClearOutputBtn);
            this.groupBox4.Location = new System.Drawing.Point(544, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Окно вывода";
            // 
            // PrintObjectsBtn
            // 
            this.PrintObjectsBtn.Location = new System.Drawing.Point(6, 62);
            this.PrintObjectsBtn.Name = "PrintObjectsBtn";
            this.PrintObjectsBtn.Size = new System.Drawing.Size(167, 32);
            this.PrintObjectsBtn.TabIndex = 1;
            this.PrintObjectsBtn.Text = "Вывести объекты";
            this.PrintObjectsBtn.UseVisualStyleBackColor = true;
            this.PrintObjectsBtn.Click += new System.EventHandler(this.PrintObjectsBtn_Click);
            // 
            // ClearOutputBtn
            // 
            this.ClearOutputBtn.Location = new System.Drawing.Point(6, 22);
            this.ClearOutputBtn.Name = "ClearOutputBtn";
            this.ClearOutputBtn.Size = new System.Drawing.Size(167, 32);
            this.ClearOutputBtn.TabIndex = 0;
            this.ClearOutputBtn.Text = "Очистить окно";
            this.ClearOutputBtn.UseVisualStyleBackColor = true;
            this.ClearOutputBtn.Click += new System.EventHandler(this.ClearOutputBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "21ВП2 Семичев Левин";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintananceCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesNumberInput)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox OutputWindow;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown PlanesNumberInput;
        private NumericUpDown MaintananceCostInput;
        private NumericUpDown EmployeeNumberInput;
        private TextBox CodeIATAInput;
        private TextBox NameInput;
        private Label label2;
        private Label label1;
        private Button CreateObjectBtn;
        private Label label6;
        private RadioButton CommercialRadioBtn;
        private RadioButton MilitaryRadioBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Button ClearObjectsListBtn;
        private Button ExitBtn;
        private GroupBox groupBox4;
        private Button PrintObjectsBtn;
        private Button ClearOutputBtn;
    }
}