namespace final_1
{
    partial class RentGame
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
            this.gameRentalDataSet = new final_1.GameRentalDataSet();
            this.gameRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new final_1.GameRentalDataSetTableAdapters.gameTableAdapter();
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamemonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentvalueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameRentalDataSet
            // 
            this.gameRentalDataSet.DataSetName = "GameRentalDataSet";
            this.gameRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameRentalDataSetBindingSource
            // 
            this.gameRentalDataSetBindingSource.DataSource = this.gameRentalDataSet;
            this.gameRentalDataSetBindingSource.Position = 0;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "game";
            this.gameBindingSource.DataSource = this.gameRentalDataSetBindingSource;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "game";
            this.gameBindingSource1.DataSource = this.gameRentalDataSetBindingSource;
            // 
            // gameBindingSource2
            // 
            this.gameBindingSource2.DataMember = "game";
            this.gameBindingSource2.DataSource = this.gameRentalDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamenameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.gameyearDataGridViewTextBoxColumn,
            this.gamemonthDataGridViewTextBoxColumn,
            this.rentvalueDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 201);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "game_name";
            this.gamenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            this.gamenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gamenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameyearDataGridViewTextBoxColumn
            // 
            this.gameyearDataGridViewTextBoxColumn.DataPropertyName = "game_year";
            this.gameyearDataGridViewTextBoxColumn.HeaderText = "game_year";
            this.gameyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameyearDataGridViewTextBoxColumn.Name = "gameyearDataGridViewTextBoxColumn";
            this.gameyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.gameyearDataGridViewTextBoxColumn.Width = 125;
            // 
            // gamemonthDataGridViewTextBoxColumn
            // 
            this.gamemonthDataGridViewTextBoxColumn.DataPropertyName = "game_month";
            this.gamemonthDataGridViewTextBoxColumn.HeaderText = "game_month";
            this.gamemonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gamemonthDataGridViewTextBoxColumn.Name = "gamemonthDataGridViewTextBoxColumn";
            this.gamemonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentvalueDataGridViewCheckBoxColumn
            // 
            this.rentvalueDataGridViewCheckBoxColumn.DataPropertyName = "Rent_value";
            this.rentvalueDataGridViewCheckBoxColumn.HeaderText = "Rent_value";
            this.rentvalueDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rentvalueDataGridViewCheckBoxColumn.Name = "rentvalueDataGridViewCheckBoxColumn";
            this.rentvalueDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rentvalueDataGridViewCheckBoxColumn.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Catogery";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(721, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 41);
            this.button5.TabIndex = 13;
            this.button5.Text = "Year";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 41);
            this.button6.TabIndex = 14;
            this.button6.Text = "Vendor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(733, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 40);
            this.button7.TabIndex = 19;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RentGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 398);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RentGame";
            this.Text = "RentGame";
            this.Load += new System.EventHandler(this.RentGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GameRentalDataSet gameRentalDataSet;
        private System.Windows.Forms.BindingSource gameRentalDataSetBindingSource;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private GameRentalDataSetTableAdapters.gameTableAdapter gameTableAdapter;
        private System.Windows.Forms.BindingSource gameBindingSource1;
        private System.Windows.Forms.BindingSource gameBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamemonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rentvalueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
    }
}