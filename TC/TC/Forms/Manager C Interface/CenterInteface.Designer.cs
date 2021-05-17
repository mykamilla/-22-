
namespace TC
{
    partial class CenterInteface
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
            System.Windows.Forms.Label iD_АрендыLabel;
            System.Windows.Forms.Label iD_СотрудникLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label начало_АрендыLabel;
            System.Windows.Forms.Label окончание_АрендыLabel;
            System.Windows.Forms.Label павильонаLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label тЦLabel;
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.iD_АрендыTextBox = new System.Windows.Forms.TextBox();
            this.iD_СотрудникTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.павильонаTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.тЦTextBox = new System.Windows.Forms.TextBox();
            this.начало_арендыtextBox1 = new System.Windows.Forms.TextBox();
            this.окончание_арендыtextBox2 = new System.Windows.Forms.TextBox();
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
            // iD_АрендыLabel
            // 
            iD_АрендыLabel.AutoSize = true;
            iD_АрендыLabel.Location = new System.Drawing.Point(44, 68);
            iD_АрендыLabel.Name = "iD_АрендыLabel";
            iD_АрендыLabel.Size = new System.Drawing.Size(65, 13);
            iD_АрендыLabel.TabIndex = 23;
            iD_АрендыLabel.Text = "ID Аренды:";
            // 
            // iD_СотрудникLabel
            // 
            iD_СотрудникLabel.AutoSize = true;
            iD_СотрудникLabel.Location = new System.Drawing.Point(44, 96);
            iD_СотрудникLabel.Name = "iD_СотрудникLabel";
            iD_СотрудникLabel.Size = new System.Drawing.Size(81, 13);
            iD_СотрудникLabel.TabIndex = 25;
            iD_СотрудникLabel.Text = "ID Сотрудник:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(44, 124);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 27;
            адресLabel.Text = "Адрес:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(44, 152);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(61, 13);
            названиеLabel.TabIndex = 29;
            названиеLabel.Text = "Название:";
            // 
            // начало_АрендыLabel
            // 
            начало_АрендыLabel.AutoSize = true;
            начало_АрендыLabel.Location = new System.Drawing.Point(44, 181);
            начало_АрендыLabel.Name = "начало_АрендыLabel";
            начало_АрендыLabel.Size = new System.Drawing.Size(93, 13);
            начало_АрендыLabel.TabIndex = 31;
            начало_АрендыLabel.Text = "Начало Аренды:";
            // 
            // окончание_АрендыLabel
            // 
            окончание_АрендыLabel.AutoSize = true;
            окончание_АрендыLabel.Location = new System.Drawing.Point(44, 209);
            окончание_АрендыLabel.Name = "окончание_АрендыLabel";
            окончание_АрендыLabel.Size = new System.Drawing.Size(114, 13);
            окончание_АрендыLabel.TabIndex = 33;
            окончание_АрендыLabel.Text = "Окончание Аренды:";
            // 
            // павильонаLabel
            // 
            павильонаLabel.AutoSize = true;
            павильонаLabel.Location = new System.Drawing.Point(44, 236);
            павильонаLabel.Name = "павильонаLabel";
            павильонаLabel.Size = new System.Drawing.Size(69, 13);
            павильонаLabel.TabIndex = 35;
            павильонаLabel.Text = "Павильона:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(44, 264);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 37;
            статусLabel.Text = "Статус:";
            // 
            // тЦLabel
            // 
            тЦLabel.AutoSize = true;
            тЦLabel.Location = new System.Drawing.Point(44, 292);
            тЦLabel.Name = "тЦLabel";
            тЦLabel.Size = new System.Drawing.Size(25, 13);
            тЦLabel.TabIndex = 39;
            тЦLabel.Text = "ТЦ:";
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataSource = typeof(TC.Аренда);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iD_АрендыTextBox
            // 
            this.iD_АрендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID_Аренды", true));
            this.iD_АрендыTextBox.Location = new System.Drawing.Point(164, 65);
            this.iD_АрендыTextBox.Name = "iD_АрендыTextBox";
            this.iD_АрендыTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_АрендыTextBox.TabIndex = 24;
            // 
            // iD_СотрудникTextBox
            // 
            this.iD_СотрудникTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID_Сотрудник", true));
            this.iD_СотрудникTextBox.Location = new System.Drawing.Point(164, 93);
            this.iD_СотрудникTextBox.Name = "iD_СотрудникTextBox";
            this.iD_СотрудникTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_СотрудникTextBox.TabIndex = 26;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(164, 121);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 22);
            this.адресTextBox.TabIndex = 28;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(164, 149);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(200, 22);
            this.названиеTextBox.TabIndex = 30;
            // 
            // павильонаTextBox
            // 
            this.павильонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Павильона", true));
            this.павильонаTextBox.Location = new System.Drawing.Point(164, 233);
            this.павильонаTextBox.Name = "павильонаTextBox";
            this.павильонаTextBox.Size = new System.Drawing.Size(200, 22);
            this.павильонаTextBox.TabIndex = 36;
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(164, 261);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(200, 22);
            this.статусTextBox.TabIndex = 38;
            // 
            // тЦTextBox
            // 
            this.тЦTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ТЦ", true));
            this.тЦTextBox.Location = new System.Drawing.Point(164, 289);
            this.тЦTextBox.Name = "тЦTextBox";
            this.тЦTextBox.Size = new System.Drawing.Size(200, 22);
            this.тЦTextBox.TabIndex = 40;
            // 
            // начало_арендыtextBox1
            // 
            this.начало_арендыtextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Название", true));
            this.начало_арендыtextBox1.Location = new System.Drawing.Point(164, 178);
            this.начало_арендыtextBox1.Name = "начало_арендыtextBox1";
            this.начало_арендыtextBox1.Size = new System.Drawing.Size(200, 22);
            this.начало_арендыtextBox1.TabIndex = 41;
            // 
            // окончание_арендыtextBox2
            // 
            this.окончание_арендыtextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Название", true));
            this.окончание_арендыtextBox2.Location = new System.Drawing.Point(164, 206);
            this.окончание_арендыtextBox2.Name = "окончание_арендыtextBox2";
            this.окончание_арендыtextBox2.Size = new System.Drawing.Size(200, 22);
            this.окончание_арендыtextBox2.TabIndex = 42;
            // 
            // CenterInteface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.окончание_арендыtextBox2);
            this.Controls.Add(this.начало_арендыtextBox1);
            this.Controls.Add(iD_АрендыLabel);
            this.Controls.Add(this.iD_АрендыTextBox);
            this.Controls.Add(iD_СотрудникLabel);
            this.Controls.Add(this.iD_СотрудникTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(начало_АрендыLabel);
            this.Controls.Add(окончание_АрендыLabel);
            this.Controls.Add(павильонаLabel);
            this.Controls.Add(this.павильонаTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусTextBox);
            this.Controls.Add(тЦLabel);
            this.Controls.Add(this.тЦTextBox);
            this.Controls.Add(this.button1);
            this.Name = "CenterInteface";
            this.Text = "CenterInteface";
            this.Load += new System.EventHandler(this.CenterInteface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource арендаBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iD_АрендыTextBox;
        private System.Windows.Forms.TextBox iD_СотрудникTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox павильонаTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.TextBox тЦTextBox;
        private System.Windows.Forms.TextBox начало_арендыtextBox1;
        private System.Windows.Forms.TextBox окончание_арендыtextBox2;
    }
}