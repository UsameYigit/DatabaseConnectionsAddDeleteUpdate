
namespace DatabaseConnectionsAddDeleteUpdate
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
            this.lvShippers = new System.Windows.Forms.ListView();
            this.clmnShipperID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtShipperName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEditingShippingPanel = new System.Windows.Forms.Label();
            this.lblShipperName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShippers
            // 
            this.lvShippers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnShipperID,
            this.clmnCompanyName,
            this.clmnPhone});
            this.lvShippers.FullRowSelect = true;
            this.lvShippers.HideSelection = false;
            this.lvShippers.Location = new System.Drawing.Point(40, 44);
            this.lvShippers.MultiSelect = false;
            this.lvShippers.Name = "lvShippers";
            this.lvShippers.Size = new System.Drawing.Size(267, 279);
            this.lvShippers.TabIndex = 0;
            this.lvShippers.UseCompatibleStateImageBehavior = false;
            this.lvShippers.View = System.Windows.Forms.View.Details;
            // 
            // clmnShipperID
            // 
            this.clmnShipperID.Text = "ShipperID";
            // 
            // clmnCompanyName
            // 
            this.clmnCompanyName.Text = "Company Name";
            // 
            // clmnPhone
            // 
            this.clmnPhone.Text = "Phone";
            // 
            // txtShipperName
            // 
            this.txtShipperName.Location = new System.Drawing.Point(430, 86);
            this.txtShipperName.Name = "txtShipperName";
            this.txtShipperName.Size = new System.Drawing.Size(129, 20);
            this.txtShipperName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(430, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // lblEditingShippingPanel
            // 
            this.lblEditingShippingPanel.AutoSize = true;
            this.lblEditingShippingPanel.Location = new System.Drawing.Point(439, 44);
            this.lblEditingShippingPanel.Name = "lblEditingShippingPanel";
            this.lblEditingShippingPanel.Size = new System.Drawing.Size(108, 13);
            this.lblEditingShippingPanel.TabIndex = 3;
            this.lblEditingShippingPanel.Text = "Editing Shipper Panel";
            // 
            // lblShipperName
            // 
            this.lblShipperName.AutoSize = true;
            this.lblShipperName.Location = new System.Drawing.Point(347, 89);
            this.lblShipperName.Name = "lblShipperName";
            this.lblShipperName.Size = new System.Drawing.Size(77, 13);
            this.lblShipperName.TabIndex = 4;
            this.lblShipperName.Text = "Shipper Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(347, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(430, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 33);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(430, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 352);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblShipperName);
            this.Controls.Add(this.lblEditingShippingPanel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtShipperName);
            this.Controls.Add(this.lvShippers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShippers;
        private System.Windows.Forms.ColumnHeader clmnShipperID;
        private System.Windows.Forms.ColumnHeader clmnCompanyName;
        private System.Windows.Forms.ColumnHeader clmnPhone;
        private System.Windows.Forms.TextBox txtShipperName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEditingShippingPanel;
        private System.Windows.Forms.Label lblShipperName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

