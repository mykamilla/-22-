
namespace TC
{
    partial class AddCenter
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
            System.Windows.Forms.Label iD_АрендатораLabel;
            System.Windows.Forms.Label iD_АрендыLabel;
            System.Windows.Forms.Label iD_СотрудникLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label начало_АрендыLabel;
            System.Windows.Forms.Label окончание_АрендыLabel;
            System.Windows.Forms.Label павильонаLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label тЦLabel;
            this.iD_АрендатораTextBox = new System.Windows.Forms.TextBox();
            this.iD_АрендыTextBox = new System.Windows.Forms.TextBox();
            this.iD_СотрудникTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.начало_АрендыTextBox = new System.Windows.Forms.TextBox();
            this.окончание_АрендыTextBox = new System.Windows.Forms.TextBox();
            this.павильонаTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.тЦTextBox = new System.Windows.Forms.TextBox();
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_АрендатораLabel = new System.Windows.Forms.Label();
            iD_АрендыLabel = new System.Windows.Forms.Label();
            iD_СотрудникLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            начало_АрендыLabel = new System.Windows.Forms.Label();
            окончание_АрендыLabel = new System.Windows.Forms.Label();
            павильонаLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            тЦLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_АрендатораLabel
            // 
            iD_АрендатораLabel.AutoSize = true;
            iD_АрендатораLabel.Location = new System.Drawing.Point(36, 76);
            iD_АрендатораLabel.Name = "iD_АрендатораLabel";
            iD_АрендатораLabel.Size = new System.Drawing.Size(88, 13);
            iD_АрендатораLabel.TabIndex = 1;
            iD_АрендатораLabel.Text = "ID Арендатора:";
            // 
            // iD_АрендатораTextBox
            // 
            this.iD_АрендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID_Арендатора", true));
            this.iD_АрендатораTextBox.Location = new System.Drawing.Point(156, 73);
            this.iD_АрендатораTextBox.Name = "iD_АрендатораTextBox";
            this.iD_АрендатораTextBox.Size = new System.Drawing.Size(190, 22);
            this.iD_АрендатораTextBox.TabIndex = 2;
            // 
            // iD_АрендыLabel
            // 
            iD_АрендыLabel.AutoSize = true;
            iD_АрендыLabel.Location = new System.Drawing.Point(36, 104);
            iD_АрендыLabel.Name = "iD_АрендыLabel";
            iD_АрендыLabel.Size = new System.Drawing.Size(65, 13);
            iD_АрендыLabel.TabIndex = 3;
            iD_АрендыLabel.Text = "ID Аренды:";
            // 
            // iD_АрендыTextBox
            // 
            this.iD_АрендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID_Аренды", true));
            this.iD_АрендыTextBox.Location = new System.Drawing.Point(156, 101);
            this.iD_АрендыTextBox.Name = "iD_АрендыTextBox";
            this.iD_АрендыTextBox.Size = new System.Drawing.Size(190, 22);
            this.iD_АрендыTextBox.TabIndex = 4;
            // 
            // iD_СотрудникLabel
            // 
            iD_СотрудникLabel.AutoSize = true;
            iD_СотрудникLabel.Location = new System.Drawing.Point(36, 132);
            iD_СотрудникLabel.Name = "iD_СотрудникLabel";
            iD_СотрудникLabel.Size = new System.Drawing.Size(81, 13);
            iD_СотрудникLabel.TabIndex = 5;
            iD_СотрудникLabel.Text = "ID Сотрудник:";
            // 
            // iD_СотрудникTextBox
            // 
            this.iD_СотрудникTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID_Сотрудник", true));
            this.iD_СотрудникTextBox.Location = new System.Drawing.Point(156, 129);
            this.iD_СотрудникTextBox.Name = "iD_СотрудникTextBox";
            this.iD_СотрудникTextBox.Size = new System.Drawing.Size(190, 22);
            this.iD_СотрудникTextBox.TabIndex = 6;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(36, 160);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(156, 157);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(190, 22);
            this.адресTextBox.TabIndex = 8;
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(36, 188);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(61, 13);
            названиеLabel.TabIndex = 9;
            названиеLabel.Text = "Название:";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(156, 185);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(190, 22);
            this.названиеTextBox.TabIndex = 10;
            // 
            // начало_АрендыLabel
            // 
            начало_АрендыLabel.AutoSize = true;
            начало_АрендыLabel.Location = new System.Drawing.Point(36, 216);
            начало_АрендыLabel.Name = "начало_АрендыLabel";
            начало_АрендыLabel.Size = new System.Drawing.Size(93, 13);
            начало_АрендыLabel.TabIndex = 11;
            начало_АрендыLabel.Text = "Начало Аренды:";
            // 
            // начало_АрендыTextBox
            // 
            this.начало_АрендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Начало_Аренды", true));
            this.начало_АрендыTextBox.Location = new System.Drawing.Point(156, 213);
            this.начало_АрендыTextBox.Name = "начало_АрендыTextBox";
            this.начало_АрендыTextBox.Size = new System.Drawing.Size(190, 22);
            this.начало_АрендыTextBox.TabIndex = 12;
            // 
            // окончание_АрендыLabel
            // 
            окончание_АрендыLabel.AutoSize = true;
            окончание_АрендыLabel.Location = new System.Drawing.Point(36, 244);
            окончание_АрендыLabel.Name = "окончание_АрендыLabel";
            окончание_АрендыLabel.Size = new System.Drawing.Size(114, 13);
            окончание_АрендыLabel.TabIndex = 13;
            окончание_АрендыLabel.Text = "Окончание Аренды:";
            // 
            // окончание_АрендыTextBox
            // 
            this.окончание_АрендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Окончание_Аренды", true));
            this.окончание_АрендыTextBox.Location = new System.Drawing.Point(156, 241);
            this.окончание_АрендыTextBox.Name = "окончание_АрендыTextBox";
            this.окончание_АрендыTextBox.Size = new System.Drawing.Size(190, 22);
            this.окончание_АрендыTextBox.TabIndex = 14;
            // 
            // павильонаLabel
            // 
            павильонаLabel.AutoSize = true;
            павильонаLabel.Location = new System.Drawing.Point(36, 272);
            павильонаLabel.Name = "павильонаLabel";
            павильонаLabel.Size = new System.Drawing.Size(69, 13);
            павильонаLabel.TabIndex = 15;
            павильонаLabel.Text = "Павильона:";
            // 
            // павильонаTextBox
            // 
            this.павильонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Павильона", true));
            this.павильонаTextBox.Location = new System.Drawing.Point(156, 269);
            this.павильонаTextBox.Name = "павильонаTextBox";
            this.павильонаTextBox.Size = new System.Drawing.Size(190, 22);
            this.павильонаTextBox.TabIndex = 16;
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(36, 300);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 17;
            статусLabel.Text = "Статус:";
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(156, 297);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(190, 22);
            this.статусTextBox.TabIndex = 18;
            // 
            // тЦLabel
            // 
            тЦLabel.AutoSize = true;
            тЦLabel.Location = new System.Drawing.Point(36, 328);
            тЦLabel.Name = "тЦLabel";
            тЦLabel.Size = new System.Drawing.Size(25, 13);
            тЦLabel.TabIndex = 19;
            тЦLabel.Text = "ТЦ:";
            // 
            // тЦTextBox
            // 
            this.тЦTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ТЦ", true));
            this.тЦTextBox.Location = new System.Drawing.Point(156, 325);
            this.тЦTextBox.Name = "тЦTextBox";
            this.тЦTextBox.Size = new System.Drawing.Size(190, 22);
            this.тЦTextBox.TabIndex = 20;
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataSource = typeof(TC.Аренда);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_АрендатораLabel);
            this.Controls.Add(this.iD_АрендатораTextBox);
            this.Controls.Add(iD_АрендыLabel);
            this.Controls.Add(this.iD_АрендыTextBox);
            this.Controls.Add(iD_СотрудникLabel);
            this.Controls.Add(this.iD_СотрудникTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(начало_АрендыLabel);
            this.Controls.Add(this.начало_АрендыTextBox);
            this.Controls.Add(окончание_АрендыLabel);
            this.Controls.Add(this.окончание_АрендыTextBox);
            this.Controls.Add(павильонаLabel);
            this.Controls.Add(this.павильонаTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусTextBox);
            this.Controls.Add(тЦLabel);
            this.Controls.Add(this.тЦTextBox);
            this.Name = "AddCenter";
            this.Text = "AddCenter";
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource арендаBindingSource;
        private System.Windows.Forms.TextBox iD_АрендатораTextBox;
        private System.Windows.Forms.TextBox iD_АрендыTextBox;
        private System.Windows.Forms.TextBox iD_СотрудникTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox начало_АрендыTextBox;
        private System.Windows.Forms.TextBox окончание_АрендыTextBox;
        private System.Windows.Forms.TextBox павильонаTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.TextBox тЦTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}