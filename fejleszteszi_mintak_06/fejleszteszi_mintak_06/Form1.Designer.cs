
namespace fejleszteszi_mintak_06
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ball = new System.Windows.Forms.Button();
            this.button_car = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.szinesgomb_1 = new System.Windows.Forms.Button();
            this.button_present = new System.Windows.Forms.Button();
            this.szinesgomb_2 = new System.Windows.Forms.Button();
            this.szinesgomb_3 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.szinesgomb_3);
            this.mainPanel.Controls.Add(this.szinesgomb_2);
            this.mainPanel.Controls.Add(this.button_present);
            this.mainPanel.Controls.Add(this.szinesgomb_1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.button_ball);
            this.mainPanel.Controls.Add(this.button_car);
            this.mainPanel.Location = new System.Drawing.Point(1, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(870, 532);
            this.mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ComingNext: ";
            // 
            // button_ball
            // 
            this.button_ball.Location = new System.Drawing.Point(112, 58);
            this.button_ball.Name = "button_ball";
            this.button_ball.Size = new System.Drawing.Size(75, 23);
            this.button_ball.TabIndex = 1;
            this.button_ball.Text = "Ball";
            this.button_ball.UseVisualStyleBackColor = true;
            this.button_ball.Click += new System.EventHandler(this.button_ball_Click);
            // 
            // button_car
            // 
            this.button_car.Location = new System.Drawing.Point(11, 58);
            this.button_car.Name = "button_car";
            this.button_car.Size = new System.Drawing.Size(75, 23);
            this.button_car.TabIndex = 0;
            this.button_car.Text = "Car";
            this.button_car.UseVisualStyleBackColor = true;
            this.button_car.Click += new System.EventHandler(this.button_car_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // szinesgomb_1
            // 
            this.szinesgomb_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.szinesgomb_1.Location = new System.Drawing.Point(112, 87);
            this.szinesgomb_1.Name = "szinesgomb_1";
            this.szinesgomb_1.Size = new System.Drawing.Size(75, 23);
            this.szinesgomb_1.TabIndex = 3;
            this.szinesgomb_1.UseVisualStyleBackColor = false;
            this.szinesgomb_1.Click += new System.EventHandler(this.szinesgomb_1_Click);
            // 
            // button_present
            // 
            this.button_present.Location = new System.Drawing.Point(206, 57);
            this.button_present.Name = "button_present";
            this.button_present.Size = new System.Drawing.Size(75, 23);
            this.button_present.TabIndex = 4;
            this.button_present.Text = "Present";
            this.button_present.UseVisualStyleBackColor = true;
            // 
            // szinesgomb_2
            // 
            this.szinesgomb_2.BackColor = System.Drawing.Color.Red;
            this.szinesgomb_2.Location = new System.Drawing.Point(206, 86);
            this.szinesgomb_2.Name = "szinesgomb_2";
            this.szinesgomb_2.Size = new System.Drawing.Size(75, 23);
            this.szinesgomb_2.TabIndex = 5;
            this.szinesgomb_2.UseVisualStyleBackColor = false;
            // 
            // szinesgomb_3
            // 
            this.szinesgomb_3.BackColor = System.Drawing.Color.Yellow;
            this.szinesgomb_3.Location = new System.Drawing.Point(206, 116);
            this.szinesgomb_3.Name = "szinesgomb_3";
            this.szinesgomb_3.Size = new System.Drawing.Size(75, 23);
            this.szinesgomb_3.TabIndex = 6;
            this.szinesgomb_3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 528);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ball;
        private System.Windows.Forms.Button button_car;
        private System.Windows.Forms.Button szinesgomb_1;
        private System.Windows.Forms.Button szinesgomb_3;
        private System.Windows.Forms.Button szinesgomb_2;
        private System.Windows.Forms.Button button_present;
    }
}

