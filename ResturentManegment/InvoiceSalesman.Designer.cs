namespace ResturentManegment
{
    partial class InvoiceSalesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceSalesman));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxFoodSearch = new System.Windows.Forms.TextBox();
            this.textFoodPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FoodListDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invoicedataGridView1 = new System.Windows.Forms.DataGridView();
            this.textFoodQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textnettotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.Label();
            this.textsubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FoodListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Search  by Food Name";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(13, 379);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(78, 26);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxFoodSearch
            // 
            this.textBoxFoodSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoodSearch.Location = new System.Drawing.Point(431, 124);
            this.textBoxFoodSearch.Multiline = true;
            this.textBoxFoodSearch.Name = "textBoxFoodSearch";
            this.textBoxFoodSearch.Size = new System.Drawing.Size(244, 29);
            this.textBoxFoodSearch.TabIndex = 39;
            this.textBoxFoodSearch.TextChanged += new System.EventHandler(this.textBoxFoodSearch_TextChanged_1);
            // 
            // textFoodPrice
            // 
            this.textFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoodPrice.Location = new System.Drawing.Point(161, 73);
            this.textFoodPrice.Name = "textFoodPrice";
            this.textFoodPrice.Size = new System.Drawing.Size(100, 22);
            this.textFoodPrice.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Food Price";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(608, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 30);
            this.button4.TabIndex = 36;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(512, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 30);
            this.button3.TabIndex = 35;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FoodListDataGridView
            // 
            this.FoodListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodListDataGridView.Location = new System.Drawing.Point(698, 51);
            this.FoodListDataGridView.Name = "FoodListDataGridView";
            this.FoodListDataGridView.RowHeadersWidth = 51;
            this.FoodListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodListDataGridView.Size = new System.Drawing.Size(333, 174);
            this.FoodListDataGridView.TabIndex = 33;
            this.FoodListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodListDataGridView_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFoodName
            // 
            this.textFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoodName.Location = new System.Drawing.Point(161, 37);
            this.textFoodName.Name = "textFoodName";
            this.textFoodName.Size = new System.Drawing.Size(100, 22);
            this.textFoodName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Food Name";
            // 
            // invoicedataGridView1
            // 
            this.invoicedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicedataGridView1.Location = new System.Drawing.Point(288, 239);
            this.invoicedataGridView1.Name = "invoicedataGridView1";
            this.invoicedataGridView1.RowHeadersWidth = 51;
            this.invoicedataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicedataGridView1.Size = new System.Drawing.Size(743, 166);
            this.invoicedataGridView1.TabIndex = 43;
            this.invoicedataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicedataGridView1_CellClick);
            // 
            // textFoodQuantity
            // 
            this.textFoodQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoodQuantity.Location = new System.Drawing.Point(161, 108);
            this.textFoodQuantity.Name = "textFoodQuantity";
            this.textFoodQuantity.Size = new System.Drawing.Size(100, 22);
            this.textFoodQuantity.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Food Quantity";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(161, 146);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 22);
            this.textTotal.TabIndex = 47;
            this.textTotal.Text = " ";
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textnettotal
            // 
            this.textnettotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnettotal.Location = new System.Drawing.Point(161, 234);
            this.textnettotal.Name = "textnettotal";
            this.textnettotal.Size = new System.Drawing.Size(100, 22);
            this.textnettotal.TabIndex = 51;
            this.textnettotal.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "After discount";
            // 
            // textDiscount
            // 
            this.textDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDiscount.Location = new System.Drawing.Point(161, 188);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(100, 22);
            this.textDiscount.TabIndex = 49;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(14, 193);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(60, 16);
            this.discount.TabIndex = 48;
            this.discount.Text = "Discount";
            // 
            // textsubtotal
            // 
            this.textsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsubtotal.Location = new System.Drawing.Point(161, 275);
            this.textsubtotal.Name = "textsubtotal";
            this.textsubtotal.Size = new System.Drawing.Size(100, 22);
            this.textsubtotal.TabIndex = 53;
            this.textsubtotal.Text = " 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Sub Total";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(185, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 54;
            this.button5.Text = "Paid";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResturentManegment.Properties.Resources.images_p;
            this.pictureBox1.Location = new System.Drawing.Point(999, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(694, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Food list";
            // 
            // InvoiceSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::ResturentManegment.Properties.Resources._71PTJtw_lnL__AC_SX522_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1038, 415);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textsubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textnettotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFoodQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoicedataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxFoodSearch);
            this.Controls.Add(this.textFoodPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FoodListDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFoodName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceSalesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceSalesman";
            this.Load += new System.EventHandler(this.InvoiceSalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxFoodSearch;
        private System.Windows.Forms.TextBox textFoodPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView FoodListDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView invoicedataGridView1;
        private System.Windows.Forms.TextBox textFoodQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textnettotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox textsubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}