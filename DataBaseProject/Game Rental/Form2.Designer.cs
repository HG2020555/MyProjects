namespace Game_Rental
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesrental7DataSet = new Game_Rental.gamesrental7DataSet();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new Game_Rental.gamesrental7DataSetTableAdapters.vendorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vIDDataGridViewTextBoxColumn,
            this.vnameDataGridViewTextBoxColumn,
            this.vpassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(611, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 181);
            this.dataGridView1.TabIndex = 6;
            // 
            // vIDDataGridViewTextBoxColumn
            // 
            this.vIDDataGridViewTextBoxColumn.DataPropertyName = "VID";
            this.vIDDataGridViewTextBoxColumn.HeaderText = "VID";
            this.vIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vIDDataGridViewTextBoxColumn.Name = "vIDDataGridViewTextBoxColumn";
            this.vIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vnameDataGridViewTextBoxColumn
            // 
            this.vnameDataGridViewTextBoxColumn.DataPropertyName = "Vname";
            this.vnameDataGridViewTextBoxColumn.HeaderText = "Vname";
            this.vnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vnameDataGridViewTextBoxColumn.Name = "vnameDataGridViewTextBoxColumn";
            this.vnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // vpassDataGridViewTextBoxColumn
            // 
            this.vpassDataGridViewTextBoxColumn.DataPropertyName = "Vpass";
            this.vpassDataGridViewTextBoxColumn.HeaderText = "Vpass";
            this.vpassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vpassDataGridViewTextBoxColumn.Name = "vpassDataGridViewTextBoxColumn";
            this.vpassDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorBindingSource1
            // 
            this.vendorBindingSource1.DataMember = "vendor";
            this.vendorBindingSource1.DataSource = this.gamesrental7DataSet;
            // 
            // gamesrental7DataSet
            // 
            this.gamesrental7DataSet.DataSetName = "gamesrental7DataSet";
            this.gamesrental7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "vendor";
            this.vendorBindingSource.DataSource = this.gamesrental7DataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(771, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back to client sign up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1001, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 43);
            this.button5.TabIndex = 11;
            this.button5.Text = "Add a game";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 425);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gamesrental7DataSet gamesrental7DataSet;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private gamesrental7DataSetTableAdapters.vendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendorBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}