namespace CSharpEgitimKampi501
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalProductCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxPriceProductName = new System.Windows.Forms.Label();
            this.lblDistinctCategoryCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(102, 40);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 22);
            this.txtProductId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 497);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(102, 328);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(89, 33);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(102, 96);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(102, 155);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyat:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(102, 215);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(100, 22);
            this.txtProductStock.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stok:";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(102, 277);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(100, 22);
            this.txtProductCategory.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategori:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 498);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplam Kitap Sayısı:";
            // 
            // lblTotalProductCount
            // 
            this.lblTotalProductCount.AutoSize = true;
            this.lblTotalProductCount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalProductCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalProductCount.Location = new System.Drawing.Point(313, 572);
            this.lblTotalProductCount.Name = "lblTotalProductCount";
            this.lblTotalProductCount.Size = new System.Drawing.Size(29, 35);
            this.lblTotalProductCount.TabIndex = 16;
            this.lblTotalProductCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(61, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "En Pahalı Kitap:";
            // 
            // lblMaxPriceProductName
            // 
            this.lblMaxPriceProductName.AutoSize = true;
            this.lblMaxPriceProductName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPriceProductName.ForeColor = System.Drawing.Color.Yellow;
            this.lblMaxPriceProductName.Location = new System.Drawing.Point(313, 621);
            this.lblMaxPriceProductName.Name = "lblMaxPriceProductName";
            this.lblMaxPriceProductName.Size = new System.Drawing.Size(29, 35);
            this.lblMaxPriceProductName.TabIndex = 18;
            this.lblMaxPriceProductName.Text = "0";
            // 
            // lblDistinctCategoryCount
            // 
            this.lblDistinctCategoryCount.AutoSize = true;
            this.lblDistinctCategoryCount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistinctCategoryCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblDistinctCategoryCount.Location = new System.Drawing.Point(311, 672);
            this.lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
            this.lblDistinctCategoryCount.Size = new System.Drawing.Size(29, 35);
            this.lblDistinctCategoryCount.TabIndex = 20;
            this.lblDistinctCategoryCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(59, 672);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 35);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kategori Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1242, 746);
            this.Controls.Add(this.lblDistinctCategoryCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMaxPriceProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalProductCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalProductCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxPriceProductName;
        private System.Windows.Forms.Label lblDistinctCategoryCount;
        private System.Windows.Forms.Label label9;
    }
}

