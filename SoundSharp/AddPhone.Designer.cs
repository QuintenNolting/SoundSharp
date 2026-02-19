namespace SoundSharp
{
    partial class AddPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhone));
            lblBrand = new Label();
            lblModel = new Label();
            lblSize = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            tbxBrand = new TextBox();
            tbxModel = new TextBox();
            txbSize = new TextBox();
            txbPrice = new TextBox();
            txbStock = new TextBox();
            btnCancel = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(99, 15);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(58, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Brand";
            lblBrand.Click += label1_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(99, 52);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(63, 25);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(99, 89);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(43, 25);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(99, 126);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(99, 163);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 25);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // tbxBrand
            // 
            tbxBrand.Location = new Point(168, 12);
            tbxBrand.Name = "tbxBrand";
            tbxBrand.Size = new Size(150, 31);
            tbxBrand.TabIndex = 5;
            tbxBrand.TextChanged += tbxBrand_TextChanged;
            // 
            // tbxModel
            // 
            tbxModel.Location = new Point(168, 49);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(150, 31);
            tbxModel.TabIndex = 6;
            // 
            // txbSize
            // 
            txbSize.Location = new Point(168, 86);
            txbSize.Name = "txbSize";
            txbSize.Size = new Size(150, 31);
            txbSize.TabIndex = 7;
            // 
            // txbPrice
            // 
            txbPrice.Location = new Point(168, 123);
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(150, 31);
            txbPrice.TabIndex = 8;
            // 
            // txbStock
            // 
            txbStock.Location = new Point(168, 160);
            txbStock.Name = "txbStock";
            txbStock.Size = new Size(150, 31);
            txbStock.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 179);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 197);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(306, 51);
            btnOk.TabIndex = 11;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // AddPhone
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 260);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txbStock);
            Controls.Add(txbPrice);
            Controls.Add(txbSize);
            Controls.Add(tbxModel);
            Controls.Add(tbxBrand);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblSize);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPhone";
            Text = "Add Phone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private Label lblModel;
        private Label lblSize;
        private Label lblPrice;
        private Label lblStock;
        private TextBox tbxBrand;
        private TextBox tbxModel;
        private TextBox txbSize;
        private TextBox txbPrice;
        private TextBox txbStock;
        private Button btnCancel;
        private Button btnOk;
    }
}