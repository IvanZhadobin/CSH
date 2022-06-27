
namespace CSharp4_view
{
    partial class Form1
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
            this.objectFieldsListBox = new System.Windows.Forms.ListBox();
            this.methodsFieldsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MethodsComboBox = new System.Windows.Forms.ComboBox();
            this.CreateObjButton = new System.Windows.Forms.Button();
            this.InputFieldsButton = new System.Windows.Forms.Button();
            this.RunMethodButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // objectFieldsListBox
            // 
            this.objectFieldsListBox.FormattingEnabled = true;
            this.objectFieldsListBox.ItemHeight = 20;
            this.objectFieldsListBox.Location = new System.Drawing.Point(28, 40);
            this.objectFieldsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectFieldsListBox.Name = "objectFieldsListBox";
            this.objectFieldsListBox.Size = new System.Drawing.Size(332, 204);
            this.objectFieldsListBox.TabIndex = 12;
            this.objectFieldsListBox.SelectedIndexChanged += new System.EventHandler(this.objectFieldsListBox_SelectedIndexChanged);
            // 
            // methodsFieldsListBox
            // 
            this.methodsFieldsListBox.FormattingEnabled = true;
            this.methodsFieldsListBox.ItemHeight = 20;
            this.methodsFieldsListBox.Location = new System.Drawing.Point(438, 40);
            this.methodsFieldsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.methodsFieldsListBox.Name = "methodsFieldsListBox";
            this.methodsFieldsListBox.Size = new System.Drawing.Size(332, 204);
            this.methodsFieldsListBox.TabIndex = 13;
            this.methodsFieldsListBox.SelectedIndexChanged += new System.EventHandler(this.methodsFieldsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Поля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Параметры";
            // 
            // ObjComboBox
            // 
            this.ObjComboBox.FormattingEnabled = true;
            this.ObjComboBox.Location = new System.Drawing.Point(28, 288);
            this.ObjComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObjComboBox.Name = "ObjComboBox";
            this.ObjComboBox.Size = new System.Drawing.Size(180, 28);
            this.ObjComboBox.TabIndex = 16;
            this.ObjComboBox.SelectedIndexChanged += new System.EventHandler(this.ObjComboBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Помещение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MethodsComboBox
            // 
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(28, 353);
            this.MethodsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(180, 28);
            this.MethodsComboBox.TabIndex = 18;
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged_1);
            // 
            // CreateObjButton
            // 
            this.CreateObjButton.Location = new System.Drawing.Point(263, 296);
            this.CreateObjButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateObjButton.Name = "CreateObjButton";
            this.CreateObjButton.Size = new System.Drawing.Size(110, 40);
            this.CreateObjButton.TabIndex = 19;
            this.CreateObjButton.Text = "создать";
            this.CreateObjButton.UseVisualStyleBackColor = true;
            this.CreateObjButton.Click += new System.EventHandler(this.CreateObjButton_Click_1);
            // 
            // InputFieldsButton
            // 
            this.InputFieldsButton.Location = new System.Drawing.Point(402, 296);
            this.InputFieldsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputFieldsButton.Name = "InputFieldsButton";
            this.InputFieldsButton.Size = new System.Drawing.Size(110, 40);
            this.InputFieldsButton.TabIndex = 20;
            this.InputFieldsButton.Text = "ввод данных";
            this.InputFieldsButton.UseVisualStyleBackColor = true;
            this.InputFieldsButton.Click += new System.EventHandler(this.InputFieldsButton_Click_1);
            // 
            // RunMethodButton
            // 
            this.RunMethodButton.Location = new System.Drawing.Point(263, 346);
            this.RunMethodButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RunMethodButton.Name = "RunMethodButton";
            this.RunMethodButton.Size = new System.Drawing.Size(249, 40);
            this.RunMethodButton.TabIndex = 21;
            this.RunMethodButton.Text = "выполнить";
            this.RunMethodButton.UseVisualStyleBackColor = true;
            this.RunMethodButton.Click += new System.EventHandler(this.RunMethodButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Метод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunMethodButton);
            this.Controls.Add(this.InputFieldsButton);
            this.Controls.Add(this.CreateObjButton);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.methodsFieldsListBox);
            this.Controls.Add(this.objectFieldsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       

        private System.Windows.Forms.ListBox objectFieldsListBox;
        private System.Windows.Forms.ListBox methodsFieldsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ObjComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.Button CreateObjButton;
        private System.Windows.Forms.Button InputFieldsButton;
        private System.Windows.Forms.Button RunMethodButton;
        private System.Windows.Forms.Label label2;
    }
}

