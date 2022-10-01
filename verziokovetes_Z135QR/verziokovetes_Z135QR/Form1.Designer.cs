namespace verziokovetes_Z135QR
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(13, 33);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(246, 303);
            this.listUsers.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(275, 33);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(35, 13);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "label1";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(275, 64);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(35, 13);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "label2";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(334, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(158, 20);
            this.lblLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(334, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(158, 20);
            this.lblFirstName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(278, 137);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(214, 31);
            this.btn_torles.TabIndex = 6;
            this.btn_torles.Text = "Törlés";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.btn_torles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.TextBox lblLastName;
        private System.Windows.Forms.TextBox lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_torles;
    }
}

