namespace Reader_2._0
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SpanishLg = new System.Windows.Forms.Button();
            this.NormalLg = new System.Windows.Forms.Button();
            this.GermanyLg = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Rules = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 470);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // SpanishLg
            // 
            this.SpanishLg.Location = new System.Drawing.Point(12, 333);
            this.SpanishLg.Name = "SpanishLg";
            this.SpanishLg.Size = new System.Drawing.Size(143, 30);
            this.SpanishLg.TabIndex = 1;
            this.SpanishLg.Text = "Spanish";
            this.SpanishLg.UseVisualStyleBackColor = true;
            this.SpanishLg.Click += new System.EventHandler(this.SpanishLg_Click);
            // 
            // NormalLg
            // 
            this.NormalLg.Location = new System.Drawing.Point(613, 333);
            this.NormalLg.Name = "NormalLg";
            this.NormalLg.Size = new System.Drawing.Size(143, 30);
            this.NormalLg.TabIndex = 2;
            this.NormalLg.Text = "English/Portuguese";
            this.NormalLg.UseVisualStyleBackColor = true;
            this.NormalLg.Click += new System.EventHandler(this.NormalLg_Click);
            // 
            // GermanyLg
            // 
            this.GermanyLg.Location = new System.Drawing.Point(1132, 333);
            this.GermanyLg.Name = "GermanyLg";
            this.GermanyLg.Size = new System.Drawing.Size(143, 30);
            this.GermanyLg.TabIndex = 3;
            this.GermanyLg.Text = "Germany";
            this.GermanyLg.UseVisualStyleBackColor = true;
            this.GermanyLg.Click += new System.EventHandler(this.GermanyLg_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1263, 302);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.Location = new System.Drawing.Point(610, 420);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(0, 13);
            this.Rules.TabIndex = 5;
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(610, 781);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(0, 13);
            this.Average.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Word Filter";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sort by Sequence";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 812);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GermanyLg);
            this.Controls.Add(this.NormalLg);
            this.Controls.Add(this.SpanishLg);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "CustomTextReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SpanishLg;
        private System.Windows.Forms.Button NormalLg;
        private System.Windows.Forms.Button GermanyLg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

