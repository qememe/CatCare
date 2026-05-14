namespace CAT__проект
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.GroupBox();
            this.go = new System.Windows.Forms.GroupBox();
            this.Eat = new System.Windows.Forms.Button();
            this.gladil = new System.Windows.Forms.Button();
            this.rodisa = new System.Windows.Forms.Label();
            this.vosrast = new System.Windows.Forms.Label();
            this.s_vami = new System.Windows.Forms.Label();
            this.corm = new System.Windows.Forms.Label();
            this.gladit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.info.SuspendLayout();
            this.go.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(68, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Барсик";
            // 
            // info
            // 
            this.info.Controls.Add(this.s_vami);
            this.info.Controls.Add(this.vosrast);
            this.info.Controls.Add(this.rodisa);
            this.info.Location = new System.Drawing.Point(24, 180);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(336, 143);
            this.info.TabIndex = 2;
            this.info.TabStop = false;
            this.info.Text = "О коте";
            // 
            // go
            // 
            this.go.Controls.Add(this.gladit);
            this.go.Controls.Add(this.corm);
            this.go.Location = new System.Drawing.Point(24, 329);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(336, 76);
            this.go.TabIndex = 3;
            this.go.TabStop = false;
            this.go.Text = "Действия";
            // 
            // Eat
            // 
            this.Eat.Location = new System.Drawing.Point(37, 426);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(75, 23);
            this.Eat.TabIndex = 0;
            this.Eat.Text = "Кормил";
            this.Eat.UseVisualStyleBackColor = true;
            // 
            // gladil
            // 
            this.gladil.Location = new System.Drawing.Point(256, 426);
            this.gladil.Name = "gladil";
            this.gladil.Size = new System.Drawing.Size(75, 23);
            this.gladil.TabIndex = 4;
            this.gladil.Text = "Гладил";
            this.gladil.UseVisualStyleBackColor = true;
            // 
            // rodisa
            // 
            this.rodisa.AutoSize = true;
            this.rodisa.Location = new System.Drawing.Point(44, 31);
            this.rodisa.Name = "rodisa";
            this.rodisa.Size = new System.Drawing.Size(50, 13);
            this.rodisa.TabIndex = 0;
            this.rodisa.Text = "Родился";
            // 
            // vosrast
            // 
            this.vosrast.AutoSize = true;
            this.vosrast.Location = new System.Drawing.Point(44, 58);
            this.vosrast.Name = "vosrast";
            this.vosrast.Size = new System.Drawing.Size(55, 13);
            this.vosrast.TabIndex = 1;
            this.vosrast.Text = "Возрасат";
            // 
            // s_vami
            // 
            this.s_vami.AutoSize = true;
            this.s_vami.Location = new System.Drawing.Point(44, 82);
            this.s_vami.Name = "s_vami";
            this.s_vami.Size = new System.Drawing.Size(43, 13);
            this.s_vami.TabIndex = 2;
            this.s_vami.Text = "С вами";
            // 
            // corm
            // 
            this.corm.AutoSize = true;
            this.corm.Location = new System.Drawing.Point(53, 35);
            this.corm.Name = "corm";
            this.corm.Size = new System.Drawing.Size(51, 13);
            this.corm.TabIndex = 3;
            this.corm.Text = "Кормить";
            // 
            // gladit
            // 
            this.gladit.AutoSize = true;
            this.gladit.Location = new System.Drawing.Point(229, 35);
            this.gladit.Name = "gladit";
            this.gladit.Size = new System.Drawing.Size(48, 13);
            this.gladit.TabIndex = 4;
            this.gladit.Text = "Гладить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.gladil);
            this.Controls.Add(this.Eat);
            this.Controls.Add(this.name);
            this.Controls.Add(this.go);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.go.ResumeLayout(false);
            this.go.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Label vosrast;
        private System.Windows.Forms.Label rodisa;
        private System.Windows.Forms.GroupBox go;
        private System.Windows.Forms.Button Eat;
        private System.Windows.Forms.Button gladil;
        private System.Windows.Forms.Label s_vami;
        private System.Windows.Forms.Label gladit;
        private System.Windows.Forms.Label corm;
    }
}

