
namespace TC
{
    partial class PavilionList
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
            this.павильонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеТЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьзаквмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коофДобавочнойстоимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.павильонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.павильонBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.павильонаDataGridViewTextBoxColumn,
            this.названиеТЦDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.стоимостьзаквмDataGridViewTextBoxColumn,
            this.коофДобавочнойстоимостиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.павильонBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // павильонаDataGridViewTextBoxColumn
            // 
            this.павильонаDataGridViewTextBoxColumn.DataPropertyName = "Павильона";
            this.павильонаDataGridViewTextBoxColumn.HeaderText = "Павильона";
            this.павильонаDataGridViewTextBoxColumn.Name = "павильонаDataGridViewTextBoxColumn";
            // 
            // названиеТЦDataGridViewTextBoxColumn
            // 
            this.названиеТЦDataGridViewTextBoxColumn.DataPropertyName = "Название_ТЦ";
            this.названиеТЦDataGridViewTextBoxColumn.HeaderText = "Название_ТЦ";
            this.названиеТЦDataGridViewTextBoxColumn.Name = "названиеТЦDataGridViewTextBoxColumn";
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // стоимостьзаквмDataGridViewTextBoxColumn
            // 
            this.стоимостьзаквмDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_за_кв_м";
            this.стоимостьзаквмDataGridViewTextBoxColumn.HeaderText = "Стоимость_за_кв_м";
            this.стоимостьзаквмDataGridViewTextBoxColumn.Name = "стоимостьзаквмDataGridViewTextBoxColumn";
            // 
            // коофДобавочнойстоимостиDataGridViewTextBoxColumn
            // 
            this.коофДобавочнойстоимостиDataGridViewTextBoxColumn.DataPropertyName = "Кооф_Добавочной_стоимости";
            this.коофДобавочнойстоимостиDataGridViewTextBoxColumn.HeaderText = "Кооф_Добавочной_стоимости";
            this.коофДобавочнойстоимостиDataGridViewTextBoxColumn.Name = "коофДобавочнойстоимостиDataGridViewTextBoxColumn";
            // 
            // павильонBindingSource
            // 
            this.павильонBindingSource.DataSource = typeof(TC.Павильон);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PavilionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PavilionList";
            this.Text = "ListPavilion";
            this.Load += new System.EventHandler(this.PavilionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.павильонBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn павильонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеТЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьзаквмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коофДобавочнойстоимостиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource павильонBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}