namespace OpenWeather
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
            this.weatherResults = new System.Windows.Forms.TextBox();
            this.forecast = new System.Windows.Forms.Button();
            this.latitude = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weatherResults
            // 
            this.weatherResults.Location = new System.Drawing.Point(168, 177);
            this.weatherResults.Multiline = true;
            this.weatherResults.Name = "weatherResults";
            this.weatherResults.Size = new System.Drawing.Size(421, 219);
            this.weatherResults.TabIndex = 0;
            // 
            // forecast
            // 
            this.forecast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.forecast.Location = new System.Drawing.Point(298, 417);
            this.forecast.Name = "forecast";
            this.forecast.Size = new System.Drawing.Size(147, 23);
            this.forecast.TabIndex = 1;
            this.forecast.Text = "Get Forecast";
            this.forecast.UseVisualStyleBackColor = true;
            this.forecast.Click += new System.EventHandler(this.forecast_Click);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(168, 79);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(100, 22);
            this.latitude.TabIndex = 2;
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(489, 79);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(100, 22);
            this.longitude.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.forecast);
            this.Controls.Add(this.weatherResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weatherResults;
        private System.Windows.Forms.Button forecast;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox longitude;
    }
}

