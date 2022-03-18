
namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.original_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.O_R_Band = new System.Windows.Forms.PictureBox();
            this.O_G_Band = new System.Windows.Forms.PictureBox();
            this.O_B_Band = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.O_PhotoWH = new System.Windows.Forms.Label();
            this.H_R_img = new System.Windows.Forms.PictureBox();
            this.H_G_img = new System.Windows.Forms.PictureBox();
            this.H_B_img = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.O_R_Band2 = new System.Windows.Forms.PictureBox();
            this.O_G_Band2 = new System.Windows.Forms.PictureBox();
            this.O_B_Band2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.H_R_img2 = new System.Windows.Forms.PictureBox();
            this.H_G_img2 = new System.Windows.Forms.PictureBox();
            this.H_B_img2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.undo_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.White;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OpenButton.Location = new System.Drawing.Point(37, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 30);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // original_img
            // 
            this.original_img.BackColor = System.Drawing.SystemColors.ControlDark;
            this.original_img.Location = new System.Drawing.Point(33, 69);
            this.original_img.Name = "original_img";
            this.original_img.Size = new System.Drawing.Size(372, 357);
            this.original_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.original_img.TabIndex = 2;
            this.original_img.TabStop = false;
            this.original_img.Click += new System.EventHandler(this.original_img_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // O_R_Band
            // 
            this.O_R_Band.BackColor = System.Drawing.Color.White;
            this.O_R_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_R_Band.Location = new System.Drawing.Point(33, 475);
            this.O_R_Band.Name = "O_R_Band";
            this.O_R_Band.Size = new System.Drawing.Size(120, 115);
            this.O_R_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_R_Band.TabIndex = 4;
            this.O_R_Band.TabStop = false;
            // 
            // O_G_Band
            // 
            this.O_G_Band.BackColor = System.Drawing.Color.White;
            this.O_G_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_G_Band.Location = new System.Drawing.Point(159, 475);
            this.O_G_Band.Name = "O_G_Band";
            this.O_G_Band.Size = new System.Drawing.Size(120, 115);
            this.O_G_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_G_Band.TabIndex = 4;
            this.O_G_Band.TabStop = false;
            // 
            // O_B_Band
            // 
            this.O_B_Band.BackColor = System.Drawing.Color.White;
            this.O_B_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_B_Band.Location = new System.Drawing.Point(285, 475);
            this.O_B_Band.Name = "O_B_Band";
            this.O_B_Band.Size = new System.Drawing.Size(120, 115);
            this.O_B_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_B_Band.TabIndex = 4;
            this.O_B_Band.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(81, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(207, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(333, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // O_PhotoWH
            // 
            this.O_PhotoWH.AutoSize = true;
            this.O_PhotoWH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.O_PhotoWH.Location = new System.Drawing.Point(320, 47);
            this.O_PhotoWH.Name = "O_PhotoWH";
            this.O_PhotoWH.Size = new System.Drawing.Size(39, 19);
            this.O_PhotoWH.TabIndex = 6;
            this.O_PhotoWH.Text = "0x0";
            // 
            // H_R_img
            // 
            this.H_R_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_R_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_R_img.Location = new System.Drawing.Point(32, 648);
            this.H_R_img.Name = "H_R_img";
            this.H_R_img.Size = new System.Drawing.Size(120, 115);
            this.H_R_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_R_img.TabIndex = 4;
            this.H_R_img.TabStop = false;
            // 
            // H_G_img
            // 
            this.H_G_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_G_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_G_img.Location = new System.Drawing.Point(159, 648);
            this.H_G_img.Name = "H_G_img";
            this.H_G_img.Size = new System.Drawing.Size(120, 115);
            this.H_G_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_G_img.TabIndex = 4;
            this.H_G_img.TabStop = false;
            // 
            // H_B_img
            // 
            this.H_B_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_B_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_B_img.Location = new System.Drawing.Point(285, 648);
            this.H_B_img.Name = "H_B_img";
            this.H_B_img.Size = new System.Drawing.Size(120, 115);
            this.H_B_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_B_img.TabIndex = 4;
            this.H_B_img.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(32, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "直方圖";
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.save_but.Location = new System.Drawing.Point(310, 12);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(83, 32);
            this.save_but.TabIndex = 8;
            this.save_but.Text = "save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(456, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 357);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(465, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Result Image";
            // 
            // O_R_Band2
            // 
            this.O_R_Band2.BackColor = System.Drawing.Color.White;
            this.O_R_Band2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_R_Band2.Location = new System.Drawing.Point(436, 475);
            this.O_R_Band2.Name = "O_R_Band2";
            this.O_R_Band2.Size = new System.Drawing.Size(120, 115);
            this.O_R_Band2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_R_Band2.TabIndex = 4;
            this.O_R_Band2.TabStop = false;
            // 
            // O_G_Band2
            // 
            this.O_G_Band2.BackColor = System.Drawing.Color.White;
            this.O_G_Band2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_G_Band2.Location = new System.Drawing.Point(562, 475);
            this.O_G_Band2.Name = "O_G_Band2";
            this.O_G_Band2.Size = new System.Drawing.Size(120, 115);
            this.O_G_Band2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_G_Band2.TabIndex = 4;
            this.O_G_Band2.TabStop = false;
            // 
            // O_B_Band2
            // 
            this.O_B_Band2.BackColor = System.Drawing.Color.White;
            this.O_B_Band2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_B_Band2.Location = new System.Drawing.Point(688, 475);
            this.O_B_Band2.Name = "O_B_Band2";
            this.O_B_Band2.Size = new System.Drawing.Size(120, 115);
            this.O_B_Band2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_B_Band2.TabIndex = 4;
            this.O_B_Band2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(484, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "R";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(610, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(736, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "B";
            // 
            // H_R_img2
            // 
            this.H_R_img2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_R_img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_R_img2.Location = new System.Drawing.Point(435, 648);
            this.H_R_img2.Name = "H_R_img2";
            this.H_R_img2.Size = new System.Drawing.Size(120, 115);
            this.H_R_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_R_img2.TabIndex = 4;
            this.H_R_img2.TabStop = false;
            // 
            // H_G_img2
            // 
            this.H_G_img2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_G_img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_G_img2.Location = new System.Drawing.Point(562, 648);
            this.H_G_img2.Name = "H_G_img2";
            this.H_G_img2.Size = new System.Drawing.Size(120, 115);
            this.H_G_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_G_img2.TabIndex = 4;
            this.H_G_img2.TabStop = false;
            // 
            // H_B_img2
            // 
            this.H_B_img2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_B_img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_B_img2.Location = new System.Drawing.Point(688, 648);
            this.H_B_img2.Name = "H_B_img2";
            this.H_B_img2.Size = new System.Drawing.Size(120, 115);
            this.H_B_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_B_img2.TabIndex = 4;
            this.H_B_img2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(441, 626);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "直方圖";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(870, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 130);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(8, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Grayscale";
            // 
            // undo_but
            // 
            this.undo_but.BackColor = System.Drawing.Color.Silver;
            this.undo_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.undo_but.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.undo_but.Location = new System.Drawing.Point(870, 23);
            this.undo_but.Name = "undo_but";
            this.undo_but.Size = new System.Drawing.Size(86, 30);
            this.undo_but.TabIndex = 0;
            this.undo_but.Text = "undo";
            this.undo_but.UseVisualStyleBackColor = false;
            this.undo_but.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1216, 792);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.O_PhotoWH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.H_B_img2);
            this.Controls.Add(this.H_B_img);
            this.Controls.Add(this.O_B_Band2);
            this.Controls.Add(this.O_B_Band);
            this.Controls.Add(this.H_G_img2);
            this.Controls.Add(this.O_G_Band2);
            this.Controls.Add(this.H_G_img);
            this.Controls.Add(this.O_G_Band);
            this.Controls.Add(this.H_R_img2);
            this.Controls.Add(this.O_R_Band2);
            this.Controls.Add(this.H_R_img);
            this.Controls.Add(this.O_R_Band);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.original_img);
            this.Controls.Add(this.undo_but);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox original_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox O_R_Band;
        private System.Windows.Forms.PictureBox O_G_Band;
        private System.Windows.Forms.PictureBox O_B_Band;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label O_PhotoWH;
        private System.Windows.Forms.PictureBox H_R_img;
        private System.Windows.Forms.PictureBox H_G_img;
        private System.Windows.Forms.PictureBox H_B_img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox O_R_Band2;
        private System.Windows.Forms.PictureBox O_G_Band2;
        private System.Windows.Forms.PictureBox O_B_Band2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox H_R_img2;
        private System.Windows.Forms.PictureBox H_G_img2;
        private System.Windows.Forms.PictureBox H_B_img2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button undo_but;
    }
}

