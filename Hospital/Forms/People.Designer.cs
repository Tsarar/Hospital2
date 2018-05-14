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
            this.dgwPeople = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeople)).BeginInit();
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
            this.dgwPeople.Size = new System.Drawing.Size(723, 395);
            this.dgwPeople.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Location = new System.Drawing.Point(497, 7);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(185, 25);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.Text = "Поиск...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // SearchDelButton
            // 
            this.SearchDelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchDelButton.FlatAppearance.BorderSize = 0;
            this.SearchDelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchDelButton.Image = global::Hospital.Properties.Resources.searchingIcon;
            this.SearchDelButton.Location = new System.Drawing.Point(688, 7);
            this.SearchDelButton.Name = "SearchDelButton";
            this.SearchDelButton.Size = new System.Drawing.Size(33, 26);
            this.SearchDelButton.TabIndex = 2;
            this.SearchDelButton.UseVisualStyleBackColor = true;
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(749, 448);
            this.Controls.Add(this.SearchDelButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.dgwPeople);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "People";
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPeople;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchDelButton;
    }
}