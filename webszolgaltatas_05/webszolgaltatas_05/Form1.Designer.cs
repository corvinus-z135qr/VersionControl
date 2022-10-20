namespace webszolgaltatas_05
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getCurrentExchangeRatesResponseBodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExchangeRatesResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrentExchangeRatesResponseBodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.getExchangeRatesResponseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // getCurrentExchangeRatesResponseBodyBindingSource
            // 
            this.getCurrentExchangeRatesResponseBodyBindingSource.DataSource = typeof(webszolgaltatas_05.MnbServiceReference.GetCurrentExchangeRatesResponseBody);
            // 
            // getExchangeRatesResponseBindingSource
            // 
            this.getExchangeRatesResponseBindingSource.DataSource = typeof(webszolgaltatas_05.MnbServiceReference.GetExchangeRatesResponse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrentExchangeRatesResponseBodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getExchangeRatesResponseBindingSource;
        private System.Windows.Forms.BindingSource getCurrentExchangeRatesResponseBodyBindingSource;
    }
}

