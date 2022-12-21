namespace ADONet_dataset
{
    partial class MainNav
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NomerBox = new System.Windows.Forms.TextBox();
            this.NamaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlamatBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.phonebookDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(21, 335);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 35);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(101, 335);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(66, 35);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(173, 335);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(81, 35);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IdBox
            // 
            this.IdBox.AllowDrop = true;
            this.IdBox.Location = new System.Drawing.Point(83, 86);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(178, 22);
            this.IdBox.TabIndex = 4;
            this.IdBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NomerBox
            // 
            this.NomerBox.Location = new System.Drawing.Point(83, 186);
            this.NomerBox.Name = "NomerBox";
            this.NomerBox.Size = new System.Drawing.Size(178, 22);
            this.NomerBox.TabIndex = 5;
            // 
            // NamaBox
            // 
            this.NamaBox.Location = new System.Drawing.Point(83, 133);
            this.NamaBox.Name = "NamaBox";
            this.NamaBox.Size = new System.Drawing.Size(178, 22);
            this.NamaBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "No. Telp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alamat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AlamatBox
            // 
            this.AlamatBox.Location = new System.Drawing.Point(83, 229);
            this.AlamatBox.Name = "AlamatBox";
            this.AlamatBox.Size = new System.Drawing.Size(178, 22);
            this.AlamatBox.TabIndex = 10;
            this.AlamatBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(537, 29);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(81, 35);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(679, 29);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(81, 35);
            this.ShowAllBtn.TabIndex = 13;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(296, 35);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(235, 22);
            this.SearchBox.TabIndex = 14;
            // 
            // phonebookDGV
            // 
            this.phonebookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phonebookDGV.Location = new System.Drawing.Point(296, 70);
            this.phonebookDGV.Name = "phonebookDGV";
            this.phonebookDGV.RowHeadersWidth = 51;
            this.phonebookDGV.RowTemplate.Height = 24;
            this.phonebookDGV.Size = new System.Drawing.Size(464, 327);
            this.phonebookDGV.TabIndex = 15;
            this.phonebookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 423);
            this.Controls.Add(this.phonebookDGV);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlamatBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamaBox);
            this.Controls.Add(this.NomerBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "MainNav";
            this.Text = "Phoneboook";
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NomerBox;
        private System.Windows.Forms.TextBox NamaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlamatBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView phonebookDGV;
    }
}

