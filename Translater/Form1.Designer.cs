namespace Translater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Updatetimer = new System.Windows.Forms.Timer(this.components);
            this.Startbutton = new System.Windows.Forms.Button();
            this.Presstimer = new System.Windows.Forms.Timer(this.components);
            this.Translatebut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Restartbut = new System.Windows.Forms.Button();
            this.Splitscroll = new System.Windows.Forms.TrackBar();
            this.Timespacescroll = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splitscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timespacescroll)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatetimer
            // 
            this.Updatetimer.Enabled = true;
            this.Updatetimer.Interval = 50;
            this.Updatetimer.Tick += new System.EventHandler(this.Updatetimer_Tick);
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Startbutton.Location = new System.Drawing.Point(12, 12);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(120, 38);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Старт";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            this.Startbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Startbutton_KeyDown);
            this.Startbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Startbutton_KeyUp);
            // 
            // Presstimer
            // 
            this.Presstimer.Interval = 50;
            this.Presstimer.Tick += new System.EventHandler(this.Presstimer_Tick);
            // 
            // Translatebut
            // 
            this.Translatebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Translatebut.Location = new System.Drawing.Point(214, 12);
            this.Translatebut.Name = "Translatebut";
            this.Translatebut.Size = new System.Drawing.Size(120, 37);
            this.Translatebut.TabIndex = 1;
            this.Translatebut.Text = "Перевод";
            this.Translatebut.UseVisualStyleBackColor = true;
            this.Translatebut.Click += new System.EventHandler(this.Translatebut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 68);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(159, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 18);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время";
            // 
            // Restartbut
            // 
            this.Restartbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restartbut.Location = new System.Drawing.Point(214, 127);
            this.Restartbut.Name = "Restartbut";
            this.Restartbut.Size = new System.Drawing.Size(120, 23);
            this.Restartbut.TabIndex = 6;
            this.Restartbut.Text = "Перезапустить";
            this.Restartbut.UseVisualStyleBackColor = true;
            this.Restartbut.Click += new System.EventHandler(this.Restartbut_Click);
            // 
            // Splitscroll
            // 
            this.Splitscroll.Location = new System.Drawing.Point(12, 156);
            this.Splitscroll.Minimum = 1;
            this.Splitscroll.Name = "Splitscroll";
            this.Splitscroll.Size = new System.Drawing.Size(146, 45);
            this.Splitscroll.TabIndex = 7;
            this.Splitscroll.Value = 1;
            this.Splitscroll.Scroll += new System.EventHandler(this.Splitscroll_Scroll);
            // 
            // Timespacescroll
            // 
            this.Timespacescroll.Location = new System.Drawing.Point(167, 156);
            this.Timespacescroll.Maximum = 5;
            this.Timespacescroll.Minimum = 1;
            this.Timespacescroll.Name = "Timespacescroll";
            this.Timespacescroll.Size = new System.Drawing.Size(167, 45);
            this.Timespacescroll.TabIndex = 8;
            this.Timespacescroll.Value = 1;
            this.Timespacescroll.Scroll += new System.EventHandler(this.Timespacescroll_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Время точки: 0.3 сек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Время между символами: 2 сек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Timespacescroll);
            this.Controls.Add(this.Splitscroll);
            this.Controls.Add(this.Restartbut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Translatebut);
            this.Controls.Add(this.Startbutton);
            this.Name = "Form1";
            this.Text = "Переводчик";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splitscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timespacescroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Updatetimer;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Timer Presstimer;
        private System.Windows.Forms.Button Translatebut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restartbut;
        private System.Windows.Forms.TrackBar Splitscroll;
        private System.Windows.Forms.TrackBar Timespacescroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

