namespace Game_Rental
{
    partial class Form5
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
            this.txtquery = new System.Windows.Forms.TextBox();
            this.btnquery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gamesrental7DataSet = new Game_Rental.gamesrental7DataSet();
            this.gamesrental7DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtquery
            // 
            this.txtquery.Location = new System.Drawing.Point(0, 3);
            this.txtquery.Multiline = true;
            this.txtquery.Name = "txtquery";
            this.txtquery.Size = new System.Drawing.Size(510, 102);
            this.txtquery.TabIndex = 0;
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(516, 3);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(130, 102);
            this.btnquery.TabIndex = 1;
            this.btnquery.Text = "Execute SQL Query";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.gamesrental7DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 327);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.AutoSizeColumnModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler(this.Fill);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gamesrental7DataSet
            // 
            this.gamesrental7DataSet.DataSetName = "gamesrental7DataSet";
            this.gamesrental7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesrental7DataSetBindingSource
            // 
            this.gamesrental7DataSetBindingSource.DataSource = this.gamesrental7DataSet;
            this.gamesrental7DataSetBindingSource.Position = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.txtquery);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrental7DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtquery;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gamesrental7DataSetBindingSource;
        private gamesrental7DataSet gamesrental7DataSet;
    }
}