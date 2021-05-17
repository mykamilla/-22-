
namespace TC
{
    partial class CenterList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАрендатораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.павильонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окончаниеАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАрендыDataGridViewTextBoxColumn,
            this.iDАрендатораDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.тЦDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.iDСотрудникDataGridViewTextBoxColumn,
            this.павильонаDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.началоАрендыDataGridViewTextBoxColumn,
            this.окончаниеАрендыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.арендаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDАрендыDataGridViewTextBoxColumn
            // 
            this.iDАрендыDataGridViewTextBoxColumn.DataPropertyName = "ID_Аренды";
            this.iDАрендыDataGridViewTextBoxColumn.HeaderText = "ID_Аренды";
            this.iDАрендыDataGridViewTextBoxColumn.Name = "iDАрендыDataGridViewTextBoxColumn";
            this.iDАрендыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // iDАрендатораDataGridViewTextBoxColumn
            // 
            this.iDАрендатораDataGridViewTextBoxColumn.DataPropertyName = "ID_Арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.HeaderText = "ID_Арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.Name = "iDАрендатораDataGridViewTextBoxColumn";
            this.iDАрендатораDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // тЦDataGridViewTextBoxColumn
            // 
            this.тЦDataGridViewTextBoxColumn.DataPropertyName = "ТЦ";
            this.тЦDataGridViewTextBoxColumn.HeaderText = "ТЦ";
            this.тЦDataGridViewTextBoxColumn.Name = "тЦDataGridViewTextBoxColumn";
            this.тЦDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // iDСотрудникDataGridViewTextBoxColumn
            // 
            this.iDСотрудникDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудник";
            this.iDСотрудникDataGridViewTextBoxColumn.HeaderText = "ID_Сотрудник";
            this.iDСотрудникDataGridViewTextBoxColumn.Name = "iDСотрудникDataGridViewTextBoxColumn";
            this.iDСотрудникDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // павильонаDataGridViewTextBoxColumn
            // 
            this.павильонаDataGridViewTextBoxColumn.DataPropertyName = "Павильона";
            this.павильонаDataGridViewTextBoxColumn.HeaderText = "Павильона";
            this.павильонаDataGridViewTextBoxColumn.Name = "павильонаDataGridViewTextBoxColumn";
            this.павильонаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // началоАрендыDataGridViewTextBoxColumn
            // 
            this.началоАрендыDataGridViewTextBoxColumn.DataPropertyName = "Начало_Аренды";
            this.началоАрендыDataGridViewTextBoxColumn.HeaderText = "Начало_Аренды";
            this.началоАрендыDataGridViewTextBoxColumn.Name = "началоАрендыDataGridViewTextBoxColumn";
            this.началоАрендыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // окончаниеАрендыDataGridViewTextBoxColumn
            // 
            this.окончаниеАрендыDataGridViewTextBoxColumn.DataPropertyName = "Окончание_Аренды";
            this.окончаниеАрендыDataGridViewTextBoxColumn.HeaderText = "Окончание_Аренды";
            this.окончаниеАрендыDataGridViewTextBoxColumn.Name = "окончаниеАрендыDataGridViewTextBoxColumn";
            this.окончаниеАрендыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataSource = typeof(TC.Аренда);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CenterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CenterList";
            this.Text = "CenterList";
            this.Load += new System.EventHandler(this.CenterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource арендаBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАрендатораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn павильонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окончаниеАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}