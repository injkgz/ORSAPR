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
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfHolesTextBox = new System.Windows.Forms.TextBox();
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
            this.parametersGroupBox.Size = new System.Drawing.Size(238, 372);
            this.parametersGroupBox.TabIndex = 0;
            this.parametersGroupBox.TabStop = false;
            this.parametersGroupBox.Text = "Параметры уголка";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Расстояние от крайней грани до центра первого отверстия";
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.Location = new System.Drawing.Point(7, 169);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(100, 20);
            this.thicknessTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 152);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота уголка H";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(12, 390);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 1;
            this.buildButton.Text = "Построить уголок";
            this.buildButton.UseVisualStyleBackColor = true;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(10, 224);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Расстояние от грани, прилежащей к другой плоскости, до центра ближайшего отверсти" +
    "я";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(10, 294);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество отверстий N";
            // 
            // numberOfHolesTextBox
            // 
            this.numberOfHolesTextBox.Location = new System.Drawing.Point(10, 338);
            this.numberOfHolesTextBox.Name = "numberOfHolesTextBox";
            this.numberOfHolesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfHolesTextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 419);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.parametersGroupBox);
            this.Name = "MainForm";
            this.Text = "AnglesSAPR";
            this.parametersGroupBox.ResumeLayout(false);
            this.parametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

