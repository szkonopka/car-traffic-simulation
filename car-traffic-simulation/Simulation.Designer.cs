namespace car_traffic_simulation
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.road = new System.Windows.Forms.PictureBox();
            this.redrawer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // road
            // 
            this.road.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("road.BackgroundImage")));
            this.road.Location = new System.Drawing.Point(-11, 138);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(800, 241);
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // redrawer
            // 
            this.redrawer.Enabled = true;
            this.redrawer.Interval = 1;
            this.redrawer.Tick += new System.EventHandler(this.Redrawer_Tick);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.road);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Simulation_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.Timer redrawer;
    }
}