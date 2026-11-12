namespace Forro_Week06_Work5
{
    partial class ucProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbItemDetails = new System.Windows.Forms.GroupBox();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.gbItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbItemDetails
            // 
            this.gbItemDetails.Controls.Add(this.cmbAmount);
            this.gbItemDetails.Controls.Add(this.txtAmount);
            this.gbItemDetails.Controls.Add(this.txtDescription);
            this.gbItemDetails.Controls.Add(this.lblAmount);
            this.gbItemDetails.Controls.Add(this.lblDescription);
            this.gbItemDetails.Location = new System.Drawing.Point(73, 49);
            this.gbItemDetails.Name = "gbItemDetails";
            this.gbItemDetails.Size = new System.Drawing.Size(568, 79);
            this.gbItemDetails.TabIndex = 0;
            this.gbItemDetails.TabStop = false;
            this.gbItemDetails.Text = "Item Details";
            // 
            // cmbAmount
            // 
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Location = new System.Drawing.Point(281, 49);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(121, 21);
            this.cmbAmount.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(134, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(131, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(408, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(38, 52);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(38, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(659, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(659, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(73, 134);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(672, 251);
            this.lbxItems.TabIndex = 4;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // lblPrompt
            // 
            this.lblPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPrompt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(0, 410);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(820, 36);
            this.lblPrompt.TabIndex = 5;
            this.lblPrompt.Text = "Prompt";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbItemDetails);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(820, 446);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.gbItemDetails.ResumeLayout(false);
            this.gbItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemDetails;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lblPrompt;
    }
}
