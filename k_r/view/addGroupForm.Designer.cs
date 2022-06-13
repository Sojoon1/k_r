
namespace k_r.view
{
    partial class addGroupForm
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
            System.Windows.Forms.Label iD_РасписанияLabel;
            System.Windows.Forms.Label количествоСлушателейLabel;
            System.Windows.Forms.Label названиеГруппыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addGroupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_РасписанияComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоСлушателейTextBox = new System.Windows.Forms.TextBox();
            this.названиеГруппыTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_РасписанияLabel = new System.Windows.Forms.Label();
            количествоСлушателейLabel = new System.Windows.Forms.Label();
            названиеГруппыLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_РасписанияLabel
            // 
            iD_РасписанияLabel.AutoSize = true;
            iD_РасписанияLabel.Location = new System.Drawing.Point(53, 96);
            iD_РасписанияLabel.Name = "iD_РасписанияLabel";
            iD_РасписанияLabel.Size = new System.Drawing.Size(142, 21);
            iD_РасписанияLabel.TabIndex = 4;
            iD_РасписанияLabel.Text = "ID Расписания:";
            // 
            // количествоСлушателейLabel
            // 
            количествоСлушателейLabel.AutoSize = true;
            количествоСлушателейLabel.Location = new System.Drawing.Point(53, 131);
            количествоСлушателейLabel.Name = "количествоСлушателейLabel";
            количествоСлушателейLabel.Size = new System.Drawing.Size(223, 21);
            количествоСлушателейLabel.TabIndex = 8;
            количествоСлушателейLabel.Text = "Количество Слушателей:";
            // 
            // названиеГруппыLabel
            // 
            названиеГруппыLabel.AutoSize = true;
            названиеГруппыLabel.Location = new System.Drawing.Point(53, 165);
            названиеГруппыLabel.Name = "названиеГруппыLabel";
            названиеГруппыLabel.Size = new System.Drawing.Size(161, 21);
            названиеГруппыLabel.TabIndex = 10;
            названиеГруппыLabel.Text = "Название Группы:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_РасписанияLabel);
            this.panel1.Controls.Add(this.iD_РасписанияComboBox);
            this.panel1.Controls.Add(количествоСлушателейLabel);
            this.panel1.Controls.Add(this.количествоСлушателейTextBox);
            this.panel1.Controls.Add(названиеГруппыLabel);
            this.panel1.Controls.Add(this.названиеГруппыTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 395);
            this.panel1.TabIndex = 4;
            // 
            // iD_РасписанияComboBox
            // 
            this.iD_РасписанияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "ID_Расписания", true));
            this.iD_РасписанияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "ID_Расписания", true));
            this.iD_РасписанияComboBox.DataSource = this.scheduleBindingSource;
            this.iD_РасписанияComboBox.DisplayMember = "ID_Группы";
            this.iD_РасписанияComboBox.FormattingEnabled = true;
            this.iD_РасписанияComboBox.Location = new System.Drawing.Point(282, 93);
            this.iD_РасписанияComboBox.Name = "iD_РасписанияComboBox";
            this.iD_РасписанияComboBox.Size = new System.Drawing.Size(121, 29);
            this.iD_РасписанияComboBox.TabIndex = 5;
            this.iD_РасписанияComboBox.ValueMember = "ID";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(k_r.EF.Schedule);
            // 
            // количествоСлушателейTextBox
            // 
            this.количествоСлушателейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "КоличествоСлушателей", true));
            this.количествоСлушателейTextBox.Location = new System.Drawing.Point(282, 128);
            this.количествоСлушателейTextBox.Name = "количествоСлушателейTextBox";
            this.количествоСлушателейTextBox.Size = new System.Drawing.Size(121, 28);
            this.количествоСлушателейTextBox.TabIndex = 9;
            // 
            // названиеГруппыTextBox
            // 
            this.названиеГруппыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "НазваниеГруппы", true));
            this.названиеГруппыTextBox.Location = new System.Drawing.Point(282, 162);
            this.названиеГруппыTextBox.Name = "названиеГруппыTextBox";
            this.названиеГруппыTextBox.Size = new System.Drawing.Size(121, 28);
            this.названиеГруппыTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(28, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(320, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(565, 408);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addGroupForm";
            this.Text = "Добавить группу";
            this.Load += new System.EventHandler(this.addGroupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.ComboBox iD_РасписанияComboBox;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.TextBox количествоСлушателейTextBox;
        private System.Windows.Forms.TextBox названиеГруппыTextBox;
    }
}