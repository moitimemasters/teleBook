namespace TelephoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_add_edit = new System.Windows.Forms.Label();
            this.name_ae_box = new System.Windows.Forms.TextBox();
            this.number_ae_box = new System.Windows.Forms.TextBox();
            this.name_s_box = new System.Windows.Forms.TextBox();
            this.number_s_box = new System.Windows.Forms.TextBox();
            this.number_add_edit = new System.Windows.Forms.Label();
            this.name_search = new System.Windows.Forms.Label();
            this.number_search = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(25, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // name_add_edit
            // 
            this.name_add_edit.AutoSize = true;
            this.name_add_edit.Location = new System.Drawing.Point(25, 27);
            this.name_add_edit.Name = "name_add_edit";
            this.name_add_edit.Size = new System.Drawing.Size(29, 13);
            this.name_add_edit.TabIndex = 1;
            this.name_add_edit.Text = "Имя";
            // 
            // name_ae_box
            // 
            this.name_ae_box.Location = new System.Drawing.Point(81, 27);
            this.name_ae_box.Name = "name_ae_box";
            this.name_ae_box.Size = new System.Drawing.Size(174, 20);
            this.name_ae_box.TabIndex = 2;
            // 
            // number_ae_box
            // 
            this.number_ae_box.Location = new System.Drawing.Point(81, 58);
            this.number_ae_box.Name = "number_ae_box";
            this.number_ae_box.Size = new System.Drawing.Size(108, 20);
            this.number_ae_box.TabIndex = 3;
            // 
            // name_s_box
            // 
            this.name_s_box.Location = new System.Drawing.Point(367, 27);
            this.name_s_box.Name = "name_s_box";
            this.name_s_box.Size = new System.Drawing.Size(181, 20);
            this.name_s_box.TabIndex = 4;
            this.name_s_box.TextChanged += new System.EventHandler(this.name_s_box_TextChanged);
            // 
            // number_s_box
            // 
            this.number_s_box.Location = new System.Drawing.Point(367, 58);
            this.number_s_box.Name = "number_s_box";
            this.number_s_box.Size = new System.Drawing.Size(115, 20);
            this.number_s_box.TabIndex = 5;
            this.number_s_box.TextChanged += new System.EventHandler(this.number_s_box_TextChanged);
            // 
            // number_add_edit
            // 
            this.number_add_edit.AutoSize = true;
            this.number_add_edit.Location = new System.Drawing.Point(25, 61);
            this.number_add_edit.Name = "number_add_edit";
            this.number_add_edit.Size = new System.Drawing.Size(41, 13);
            this.number_add_edit.TabIndex = 6;
            this.number_add_edit.Text = "Номер";
            // 
            // name_search
            // 
            this.name_search.AutoSize = true;
            this.name_search.Location = new System.Drawing.Point(261, 30);
            this.name_search.Name = "name_search";
            this.name_search.Size = new System.Drawing.Size(92, 13);
            this.name_search.TabIndex = 7;
            this.name_search.Text = "Поиск по имени:";
            // 
            // number_search
            // 
            this.number_search.AutoSize = true;
            this.number_search.Location = new System.Drawing.Point(261, 61);
            this.number_search.Name = "number_search";
            this.number_search.Size = new System.Drawing.Size(100, 13);
            this.number_search.TabIndex = 8;
            this.number_search.Text = "Поиск по номеру: ";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(25, 111);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(106, 111);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.number_search);
            this.Controls.Add(this.name_search);
            this.Controls.Add(this.number_add_edit);
            this.Controls.Add(this.number_s_box);
            this.Controls.Add(this.name_s_box);
            this.Controls.Add(this.number_ae_box);
            this.Controls.Add(this.name_ae_box);
            this.Controls.Add(this.name_add_edit);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Телефонная Книга";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label name_add_edit;
        private System.Windows.Forms.TextBox name_ae_box;
        private System.Windows.Forms.TextBox number_ae_box;
        private System.Windows.Forms.TextBox name_s_box;
        private System.Windows.Forms.TextBox number_s_box;
        private System.Windows.Forms.Label number_add_edit;
        private System.Windows.Forms.Label name_search;
        private System.Windows.Forms.Label number_search;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button button3;
    }
}

