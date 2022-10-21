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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getCurrentExchangeRatesResponseBodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExchangeRatesResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rateDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrentExchangeRatesResponseBodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rateDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 377);
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
            // chartRateData
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea4);
            this.chartRateData.DataSource = this.rateDataBindingSource1;
            legend4.Name = "Legend1";
            this.chartRateData.Legends.Add(legend4);
            this.chartRateData.Location = new System.Drawing.Point(369, 49);
            this.chartRateData.Name = "chartRateData";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRateData.Series.Add(series4);
            this.chartRateData.Size = new System.Drawing.Size(311, 377);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // rateDataBindingSource1
            // 
            this.rateDataBindingSource1.DataSource = typeof(webszolgaltatas_05.Entities.RateData);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // rateDataBindingSource
            // 
            this.rateDataBindingSource.DataSource = typeof(webszolgaltatas_05.Entities.RateData);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCurrentExchangeRatesResponseBodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getExchangeRatesResponseBindingSource;
        private System.Windows.Forms.BindingSource getCurrentExchangeRatesResponseBodyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rateDataBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.BindingSource rateDataBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

