namespace SoundSharp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblVoorraad = new Label();
            lstbxStock = new ListBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 37);
            btnAdd.Margin = new Padding(2, 4, 2, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(300, 77);
            btnEdit.Margin = new Padding(2, 4, 2, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 35);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Aanpassen";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(300, 117);
            btnDelete.Margin = new Padding(2, 4, 2, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblVoorraad
            // 
            lblVoorraad.AutoSize = true;
            lblVoorraad.Location = new Point(12, 10);
            lblVoorraad.Margin = new Padding(2, 0, 2, 0);
            lblVoorraad.Name = "lblVoorraad";
            lblVoorraad.Size = new Size(85, 25);
            lblVoorraad.TabIndex = 3;
            lblVoorraad.Text = "Voorraad";
            lblVoorraad.Click += lblVoorraad_Click;
            // 
            // lstbxStock
            // 
            lstbxStock.BackColor = SystemColors.GradientInactiveCaption;
            lstbxStock.FormattingEnabled = true;
            lstbxStock.ItemHeight = 25;
            lstbxStock.Location = new Point(12, 37);
            lstbxStock.Margin = new Padding(2, 4, 2, 4);
            lstbxStock.Name = "lstbxStock";
            lstbxStock.Size = new Size(282, 404);
            lstbxStock.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(419, 450);
            Controls.Add(lstbxStock);
            Controls.Add(lblVoorraad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "frmMain";
            Text = "SoundSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblVoorraad;
        private ListBox lstbxStock;
    }
}
