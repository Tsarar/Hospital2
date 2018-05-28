namespace Hospital
{
    partial class People
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwPeople = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDelButton = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.FirstDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPeople
            // 
            this.dgwPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.dgwPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPeople.GridColor = System.Drawing.Color.White;
            this.dgwPeople.Location = new System.Drawing.Point(13, 40);
            this.dgwPeople.Margin = new System.Windows.Forms.Padding(4);
            this.dgwPeople.Name = "dgwPeople";
            this.dgwPeople.Size = new System.Drawing.Size(1240, 395);
            this.dgwPeople.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Location = new System.Drawing.Point(1014, 7);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(185, 25);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.Text = "Поиск...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // SearchDelButton
            // 
            this.SearchDelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchDelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchDelButton.FlatAppearance.BorderSize = 0;
            this.SearchDelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchDelButton.Image = global::Hospital.Properties.Resources.searchingIcon;
            this.SearchDelButton.Location = new System.Drawing.Point(1205, 5);
            this.SearchDelButton.Name = "SearchDelButton";
            this.SearchDelButton.Size = new System.Drawing.Size(33, 26);
            this.SearchDelButton.TabIndex = 2;
            this.SearchDelButton.UseVisualStyleBackColor = true;
            this.SearchDelButton.Click += new System.EventHandler(this.SearchDelButton_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstDateCol,
            this.DocumentCol,
            this.CardCol,
            this.SurNameCol,
            this.NameCol,
            this.SecondNameCol,
            this.PhoneCol,
            this.DistrictCol,
            this.CommentCol,
            this.AuthorCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.Location = new System.Drawing.Point(3, 41);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(1260, 402);
            this.dgvPeople.TabIndex = 3;
            // 
            // FirstDateCol
            // 
            this.FirstDateCol.HeaderText = "Дата первого приема";
            this.FirstDateCol.Name = "FirstDateCol";
            // 
            // DocumentCol
            // 
            this.DocumentCol.HeaderText = "Документ";
            this.DocumentCol.Name = "DocumentCol";
            // 
            // CardCol
            // 
            this.CardCol.HeaderText = "№ карточки";
            this.CardCol.Name = "CardCol";
            // 
            // SurNameCol
            // 
            this.SurNameCol.HeaderText = "Фамилия";
            this.SurNameCol.Name = "SurNameCol";
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Имя";
            this.NameCol.Name = "NameCol";
            // 
            // SecondNameCol
            // 
            this.SecondNameCol.HeaderText = "Отчество";
            this.SecondNameCol.Name = "SecondNameCol";
            // 
            // PhoneCol
            // 
            this.PhoneCol.HeaderText = "Телефон";
            this.PhoneCol.Name = "PhoneCol";
            // 
            // DistrictCol
            // 
            this.DistrictCol.HeaderText = "Район";
            this.DistrictCol.Name = "DistrictCol";
            // 
            // CommentCol
            // 
            this.CommentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CommentCol.HeaderText = "!";
            this.CommentCol.Name = "CommentCol";
            this.CommentCol.Width = 38;
            // 
            // AuthorCol
            // 
            this.AuthorCol.HeaderText = "Автор";
            this.AuthorCol.Name = "AuthorCol";
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1266, 448);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.SearchDelButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.dgwPeople);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "People";
            this.Text = "People";
            this.Load += new System.EventHandler(this.People_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPeople;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchDelButton;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorCol;
    }
}