
namespace k_r.view
{
    partial class addCoursForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label длительностьКурсаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCoursForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.длительностьКурсаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            длительностьКурсаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // длительностьКурсаLabel
            // 
            длительностьКурсаLabel.AutoSize = true;
            длительностьКурсаLabel.Location = new System.Drawing.Point(30, 71);
            длительностьКурсаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            длительностьКурсаLabel.Name = "длительностьКурсаLabel";
            длительностьКурсаLabel.Size = new System.Drawing.Size(187, 21);
            длительностьКурсаLabel.TabIndex = 4;
            длительностьКурсаLabel.Text = "Длительность Курса:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(30, 35);
            названиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(97, 21);
            названиеLabel.TabIndex = 6;
            названиеLabel.Text = "Название:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(30, 109);
            стоимостьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(109, 21);
            стоимостьLabel.TabIndex = 8;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(длительностьКурсаLabel);
            this.panel1.Controls.Add(this.длительностьКурсаTextBox);
            this.panel1.Controls.Add(названиеLabel);
            this.panel1.Controls.Add(this.названиеTextBox);
            this.panel1.Controls.Add(стоимостьLabel);
            this.panel1.Controls.Add(this.стоимостьTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(22, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 301);
            this.panel1.TabIndex = 3;
            // 
            // длительностьКурсаTextBox
            // 
            this.длительностьКурсаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "ДлительностьКурса", true));
            this.длительностьКурсаTextBox.Location = new System.Drawing.Point(224, 67);
            this.длительностьКурсаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.длительностьКурсаTextBox.Name = "длительностьКурсаTextBox";
            this.длительностьКурсаTextBox.Size = new System.Drawing.Size(124, 28);
            this.длительностьКурсаTextBox.TabIndex = 5;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(224, 31);
            this.названиеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(124, 28);
            this.названиеTextBox.TabIndex = 7;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(224, 105);
            this.стоимостьTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(124, 28);
            this.стоимостьTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(22, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(256, 227);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(488, 335);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addCoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить курс";
            this.Load += new System.EventHandler(this.addCoursForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.TextBox длительностьКурсаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
    }
}