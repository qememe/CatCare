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
            this.catPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.fedButton = new System.Windows.Forms.Button();
            this.pettedButton = new System.Windows.Forms.Button();
            this.catBirthdayLabel = new System.Windows.Forms.Label();
            this.catAgeLabel = new System.Windows.Forms.Label();
            this.withOwnerLabel = new System.Windows.Forms.Label();
            this.nextFeedLabel = new System.Windows.Forms.Label();
            this.nextPetLabel = new System.Windows.Forms.Label();
            this.petIntervalTextBox = new System.Windows.Forms.TextBox();
            this.feedIntervalTextBox = new System.Windows.Forms.TextBox();
            this.minutesRadioButton = new System.Windows.Forms.RadioButton();
            this.daysRadioButton = new System.Windows.Forms.RadioButton();
            this.hoursRadioButton = new System.Windows.Forms.RadioButton();
            this.editProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catPhotoPictureBox)).BeginInit();
            this.catInfoGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // catPhotoPictureBox
            //
            this.catPhotoPictureBox.Location = new System.Drawing.Point(228, 12);
            this.catPhotoPictureBox.Name = "catPhotoPictureBox";
            this.catPhotoPictureBox.Size = new System.Drawing.Size(132, 120);
            this.catPhotoPictureBox.TabIndex = 0;
            this.catPhotoPictureBox.TabStop = false;
            //
            // catNameLabel
            //
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.Location = new System.Drawing.Point(68, 82);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(44, 13);
            this.catNameLabel.TabIndex = 1;
            this.catNameLabel.Text = "Барсик";
            //
            // catInfoGroupBox
            //
            this.catInfoGroupBox.Controls.Add(this.hoursRadioButton);
            this.catInfoGroupBox.Controls.Add(this.daysRadioButton);
            this.catInfoGroupBox.Controls.Add(this.minutesRadioButton);
            this.catInfoGroupBox.Controls.Add(this.withOwnerLabel);
            this.catInfoGroupBox.Controls.Add(this.catAgeLabel);
            this.catInfoGroupBox.Controls.Add(this.catBirthdayLabel);
            this.catInfoGroupBox.Location = new System.Drawing.Point(24, 180);
            this.catInfoGroupBox.Name = "catInfoGroupBox";
            this.catInfoGroupBox.Size = new System.Drawing.Size(336, 143);
            this.catInfoGroupBox.TabIndex = 2;
            this.catInfoGroupBox.TabStop = false;
            this.catInfoGroupBox.Text = "О коте";
            //
            // actionsGroupBox
            //
            this.actionsGroupBox.Controls.Add(this.petIntervalTextBox);
            this.actionsGroupBox.Controls.Add(this.feedIntervalTextBox);
            this.actionsGroupBox.Controls.Add(this.nextPetLabel);
            this.actionsGroupBox.Controls.Add(this.nextFeedLabel);
            this.actionsGroupBox.Location = new System.Drawing.Point(24, 329);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(336, 76);
            this.actionsGroupBox.TabIndex = 3;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Действия";
            //
            // fedButton
            //
            this.fedButton.Location = new System.Drawing.Point(37, 426);
            this.fedButton.Name = "fedButton";
            this.fedButton.Size = new System.Drawing.Size(75, 23);
            this.fedButton.TabIndex = 0;
            this.fedButton.Text = "Кормил";
            this.fedButton.UseVisualStyleBackColor = true;
            //
            // pettedButton
            //
            this.pettedButton.Location = new System.Drawing.Point(256, 426);
            this.pettedButton.Name = "pettedButton";
            this.pettedButton.Size = new System.Drawing.Size(75, 23);
            this.pettedButton.TabIndex = 4;
            this.pettedButton.Text = "Гладил";
            this.pettedButton.UseVisualStyleBackColor = true;
            //
            // catBirthdayLabel
            //
            this.catBirthdayLabel.AutoSize = true;
            this.catBirthdayLabel.Location = new System.Drawing.Point(44, 31);
            this.catBirthdayLabel.Name = "catBirthdayLabel";
            this.catBirthdayLabel.Size = new System.Drawing.Size(50, 13);
            this.catBirthdayLabel.TabIndex = 0;
            this.catBirthdayLabel.Text = "Родился";
            //
            // catAgeLabel
            //
            this.catAgeLabel.AutoSize = true;
            this.catAgeLabel.Location = new System.Drawing.Point(44, 58);
            this.catAgeLabel.Name = "catAgeLabel";
            this.catAgeLabel.Size = new System.Drawing.Size(55, 13);
            this.catAgeLabel.TabIndex = 1;
            this.catAgeLabel.Text = "Возраст";
            //
            // withOwnerLabel
            //
            this.withOwnerLabel.AutoSize = true;
            this.withOwnerLabel.Location = new System.Drawing.Point(44, 82);
            this.withOwnerLabel.Name = "withOwnerLabel";
            this.withOwnerLabel.Size = new System.Drawing.Size(43, 13);
            this.withOwnerLabel.TabIndex = 2;
            this.withOwnerLabel.Text = "С вами";
            //
            // nextFeedLabel
            //
            this.nextFeedLabel.AutoSize = true;
            this.nextFeedLabel.Location = new System.Drawing.Point(44, 42);
            this.nextFeedLabel.Name = "nextFeedLabel";
            this.nextFeedLabel.Size = new System.Drawing.Size(51, 13);
            this.nextFeedLabel.TabIndex = 3;
            this.nextFeedLabel.Text = "Кормить";
            //
            // nextPetLabel
            //
            this.nextPetLabel.AutoSize = true;
            this.nextPetLabel.Location = new System.Drawing.Point(229, 42);
            this.nextPetLabel.Name = "nextPetLabel";
            this.nextPetLabel.Size = new System.Drawing.Size(48, 13);
            this.nextPetLabel.TabIndex = 4;
            this.nextPetLabel.Text = "Гладить";
            //
            // petIntervalTextBox
            //
            this.petIntervalTextBox.Location = new System.Drawing.Point(204, 19);
            this.petIntervalTextBox.Name = "petIntervalTextBox";
            this.petIntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.petIntervalTextBox.TabIndex = 3;
            this.petIntervalTextBox.Text = "3";
            //
            // feedIntervalTextBox
            //
            this.feedIntervalTextBox.Location = new System.Drawing.Point(13, 19);
            this.feedIntervalTextBox.Name = "feedIntervalTextBox";
            this.feedIntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.feedIntervalTextBox.TabIndex = 4;
            this.feedIntervalTextBox.Text = "6";
            //
            // minutesRadioButton
            //
            this.minutesRadioButton.AutoSize = true;
            this.minutesRadioButton.Location = new System.Drawing.Point(204, 31);
            this.minutesRadioButton.Name = "minutesRadioButton";
            this.minutesRadioButton.Size = new System.Drawing.Size(76, 17);
            this.minutesRadioButton.TabIndex = 3;
            this.minutesRadioButton.TabStop = true;
            this.minutesRadioButton.Text = "В минутах";
            this.minutesRadioButton.UseVisualStyleBackColor = true;
            //
            // daysRadioButton
            //
            this.daysRadioButton.AutoSize = true;
            this.daysRadioButton.Location = new System.Drawing.Point(204, 58);
            this.daysRadioButton.Name = "daysRadioButton";
            this.daysRadioButton.Size = new System.Drawing.Size(58, 17);
            this.daysRadioButton.TabIndex = 4;
            this.daysRadioButton.TabStop = true;
            this.daysRadioButton.Text = "В днях";
            this.daysRadioButton.UseVisualStyleBackColor = true;
            //
            // hoursRadioButton
            //
            this.hoursRadioButton.AutoSize = true;
            this.hoursRadioButton.Location = new System.Drawing.Point(204, 91);
            this.hoursRadioButton.Name = "hoursRadioButton";
            this.hoursRadioButton.Size = new System.Drawing.Size(63, 17);
            this.hoursRadioButton.TabIndex = 5;
            this.hoursRadioButton.TabStop = true;
            this.hoursRadioButton.Text = "В часах";
            this.hoursRadioButton.UseVisualStyleBackColor = true;
            //
            // editProfileButton
            //
            this.editProfileButton.Location = new System.Drawing.Point(37, 128);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(100, 23);
            this.editProfileButton.TabIndex = 5;
            this.editProfileButton.Text = "Профиль";
            this.editProfileButton.UseVisualStyleBackColor = true;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.pettedButton);
            this.Controls.Add(this.fedButton);
            this.Controls.Add(this.catNameLabel);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.catInfoGroupBox);
            this.Controls.Add(this.catPhotoPictureBox);
            this.Name = "Form1";
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.catPhotoPictureBox)).EndInit();
            this.catInfoGroupBox.ResumeLayout(false);
            this.catInfoGroupBox.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            this.actionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox catPhotoPictureBox;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.GroupBox catInfoGroupBox;
        private System.Windows.Forms.Label catAgeLabel;
        private System.Windows.Forms.Label catBirthdayLabel;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button fedButton;
        private System.Windows.Forms.Button pettedButton;
        private System.Windows.Forms.Label withOwnerLabel;
        private System.Windows.Forms.Label nextPetLabel;
        private System.Windows.Forms.Label nextFeedLabel;
        private System.Windows.Forms.TextBox petIntervalTextBox;
        private System.Windows.Forms.TextBox feedIntervalTextBox;
        private System.Windows.Forms.RadioButton hoursRadioButton;
        private System.Windows.Forms.RadioButton daysRadioButton;
        private System.Windows.Forms.RadioButton minutesRadioButton;
        private System.Windows.Forms.Button editProfileButton;
    }
}
