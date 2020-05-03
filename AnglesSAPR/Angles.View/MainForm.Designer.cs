namespace Angles.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.parametersGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfHolesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thicknessTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.savePlaneButton = new System.Windows.Forms.Button();
            this.firstPlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.secondPlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.parametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parametersGroupBox
            // 
            this.parametersGroupBox.Controls.Add(this.numberOfHolesTextBox);
            this.parametersGroupBox.Controls.Add(this.label7);
            this.parametersGroupBox.Controls.Add(this.lengthTextBox);
            this.parametersGroupBox.Controls.Add(this.label6);
            this.parametersGroupBox.Controls.Add(this.distanceTextBox);
            this.parametersGroupBox.Controls.Add(this.label5);
            this.parametersGroupBox.Controls.Add(this.thicknessTextBox);
            this.parametersGroupBox.Controls.Add(this.label4);
            this.parametersGroupBox.Controls.Add(this.diameterTextBox);
            this.parametersGroupBox.Controls.Add(this.label3);
            this.parametersGroupBox.Controls.Add(this.widthTextBox);
            this.parametersGroupBox.Controls.Add(this.label2);
            this.parametersGroupBox.Controls.Add(this.heightTextBox);
            this.parametersGroupBox.Controls.Add(this.label1);
            this.parametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.parametersGroupBox.Name = "parametersGroupBox";
            this.parametersGroupBox.Size = new System.Drawing.Size(238, 377);
            this.parametersGroupBox.TabIndex = 0;
            this.parametersGroupBox.TabStop = false;
            this.parametersGroupBox.Text = "Параметры уголка";
            // 
            // numberOfHolesTextBox
            // 
            this.numberOfHolesTextBox.Location = new System.Drawing.Point(7, 346);
            this.numberOfHolesTextBox.Name = "numberOfHolesTextBox";
            this.numberOfHolesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfHolesTextBox.TabIndex = 13;
            this.numberOfHolesTextBox.Text = "4";
            this.numberOfHolesTextBox.TextChanged += new System.EventHandler(this.numberOfHolesTextBox_TextChanged);
            this.numberOfHolesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество отверстий N";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(7, 236);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 9;
            this.lengthTextBox.Text = "10";
            this.lengthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.lengthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Расстояние от грани, прилежащей к другой плоскости, до центра ближайшего отверсти" +
    "я";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(7, 307);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 11;
            this.distanceTextBox.Text = "30";
            this.distanceTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.distanceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Расстояние от крайней грани до центра первого отверстия(если количество отверстий" +
    " больше 1)";
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.Location = new System.Drawing.Point(7, 169);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(100, 20);
            this.thicknessTextBox.TabIndex = 7;
            this.thicknessTextBox.Text = "5";
            this.thicknessTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.thicknessTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Толщина уголка T";
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.Location = new System.Drawing.Point(7, 125);
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.diameterTextBox.TabIndex = 5;
            this.diameterTextBox.Text = "5";
            this.diameterTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.diameterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Диаметр отверстий D";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(7, 81);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.Text = "20";
            this.widthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина уголка W";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(7, 37);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "200";
            this.heightTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.heightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота уголка H";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(12, 464);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 1;
            this.buildButton.Text = "Построить уголок";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // savePlaneButton
            // 
            this.savePlaneButton.Location = new System.Drawing.Point(12, 435);
            this.savePlaneButton.Name = "savePlaneButton";
            this.savePlaneButton.Size = new System.Drawing.Size(208, 23);
            this.savePlaneButton.TabIndex = 2;
            this.savePlaneButton.Text = "Сохранить параметры плоскости";
            this.savePlaneButton.UseVisualStyleBackColor = true;
            this.savePlaneButton.Click += new System.EventHandler(this.savePlaneButton_Click);
            // 
            // firstPlaneRadioButton
            // 
            this.firstPlaneRadioButton.AutoSize = true;
            this.firstPlaneRadioButton.Checked = true;
            this.firstPlaneRadioButton.Location = new System.Drawing.Point(12, 412);
            this.firstPlaneRadioButton.Name = "firstPlaneRadioButton";
            this.firstPlaneRadioButton.Size = new System.Drawing.Size(96, 17);
            this.firstPlaneRadioButton.TabIndex = 3;
            this.firstPlaneRadioButton.TabStop = true;
            this.firstPlaneRadioButton.Text = "Плоскость #1";
            this.firstPlaneRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondPlaneRadioButton
            // 
            this.secondPlaneRadioButton.AutoSize = true;
            this.secondPlaneRadioButton.Location = new System.Drawing.Point(135, 412);
            this.secondPlaneRadioButton.Name = "secondPlaneRadioButton";
            this.secondPlaneRadioButton.Size = new System.Drawing.Size(96, 17);
            this.secondPlaneRadioButton.TabIndex = 4;
            this.secondPlaneRadioButton.Text = "Плоскость #2";
            this.secondPlaneRadioButton.UseVisualStyleBackColor = true;
            this.secondPlaneRadioButton.CheckedChanged += new System.EventHandler(this.secondPlaneRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Выбор плоскости уголка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 493);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secondPlaneRadioButton);
            this.Controls.Add(this.firstPlaneRadioButton);
            this.Controls.Add(this.savePlaneButton);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.parametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AnglesSAPR";
            this.parametersGroupBox.ResumeLayout(false);
            this.parametersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox parametersGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thicknessTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diameterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox numberOfHolesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Button savePlaneButton;
        private System.Windows.Forms.RadioButton firstPlaneRadioButton;
        private System.Windows.Forms.RadioButton secondPlaneRadioButton;
        private System.Windows.Forms.Label label8;
    }
}

