
namespace WindowsFormsApp1
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnUpdateById = new System.Windows.Forms.Button();
            this.btnDeleteById = new System.Windows.Forms.Button();
            this.dgvDogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(61, 60);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(177, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(177, 27);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteLast.TabIndex = 7;
            this.btnDeleteLast.Text = "Delete Last";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // btnUpdateById
            // 
            this.btnUpdateById.Location = new System.Drawing.Point(177, 82);
            this.btnUpdateById.Name = "btnUpdateById";
            this.btnUpdateById.Size = new System.Drawing.Size(83, 25);
            this.btnUpdateById.TabIndex = 8;
            this.btnUpdateById.Text = "Update By Id";
            this.btnUpdateById.UseVisualStyleBackColor = true;
            this.btnUpdateById.Click += new System.EventHandler(this.btnUpdateById_Click);
            // 
            // btnDeleteById
            // 
            this.btnDeleteById.Location = new System.Drawing.Point(177, 51);
            this.btnDeleteById.Name = "btnDeleteById";
            this.btnDeleteById.Size = new System.Drawing.Size(83, 25);
            this.btnDeleteById.TabIndex = 8;
            this.btnDeleteById.Text = "Delete By Id";
            this.btnDeleteById.UseVisualStyleBackColor = true;
            this.btnDeleteById.Click += new System.EventHandler(this.btnDeleteById_Click);
            // 
            // dgvDogs
            // 
            this.dgvDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogs.Location = new System.Drawing.Point(266, 3);
            this.dgvDogs.Name = "dgvDogs";
            this.dgvDogs.Size = new System.Drawing.Size(382, 240);
            this.dgvDogs.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.snimka1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 455);
            this.Controls.Add(this.dgvDogs);
            this.Controls.Add(this.btnDeleteById);
            this.Controls.Add(this.btnUpdateById);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnUpdateById;
        private System.Windows.Forms.Button btnDeleteById;
        private System.Windows.Forms.DataGridView dgvDogs;
    }
}

