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
            btnAdd.Location = new Point(174, 3);
            btnAdd.Margin = new Padding(2, 4, 2, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(236, 52);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(414, 3);
            btnEdit.Margin = new Padding(2, 4, 2, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(236, 52);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Aanpassen";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(654, 3);
            btnDelete.Margin = new Padding(2, 4, 2, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(236, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblVoorraad
            // 
            lblVoorraad.AutoSize = true;
            lblVoorraad.Location = new Point(11, 34);
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
            lstbxStock.Location = new Point(11, 63);
            lstbxStock.Margin = new Padding(2, 4, 2, 4);
            lstbxStock.Name = "lstbxStock";
            lstbxStock.Size = new Size(879, 379);
            lstbxStock.TabIndex = 4;
            lstbxStock.SelectedIndexChanged += lstbxStock_SelectedIndexChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(901, 450);
            Controls.Add(lstbxStock);
            Controls.Add(lblVoorraad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "frmMain";
            Text = "SoundSharp";
            Load += frmMain_Load_1;
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
