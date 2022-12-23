namespace car
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_xe = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vong = new Guna.UI.WinForms.GunaCircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_xe)).BeginInit();
            this.vong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_xe
            // 
            this.pictureBox_xe.Image = global::car.Properties.Resources.image_2022_12_12_214046446;
            this.pictureBox_xe.Location = new System.Drawing.Point(78, 83);
            this.pictureBox_xe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox_xe.Name = "pictureBox_xe";
            this.pictureBox_xe.Size = new System.Drawing.Size(250, 201);
            this.pictureBox_xe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_xe.TabIndex = 0;
            this.pictureBox_xe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cữa Hàng Xe Ô Tô";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vong
            // 
            this.vong.AnimationSpeed = 0.6F;
            this.vong.BackColor = System.Drawing.Color.Crimson;
            this.vong.BaseColor = System.Drawing.Color.Transparent;
            this.vong.Controls.Add(this.pictureBox_xe);
            this.vong.IdleColor = System.Drawing.Color.Transparent;
            this.vong.IdleOffset = 20;
            this.vong.IdleThickness = 15;
            this.vong.Image = null;
            this.vong.ImageSize = new System.Drawing.Size(52, 52);
            this.vong.Location = new System.Drawing.Point(292, 119);
            this.vong.Name = "vong";
            this.vong.ProgressMaxColor = System.Drawing.Color.White;
            this.vong.ProgressMinColor = System.Drawing.Color.White;
            this.vong.ProgressOffset = 20;
            this.vong.ProgressThickness = 15;
            this.vong.Size = new System.Drawing.Size(406, 372);
            this.vong.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vong);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_xe)).EndInit();
            this.vong.ResumeLayout(false);
            this.vong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_xe;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleProgressBar vong;
    }
}

