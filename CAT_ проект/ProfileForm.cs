using System;
using System.Windows.Forms;

namespace CAT__проект
{
    public class ProfileForm : Form
    {
        TextBox nameTextBox = new TextBox();
        DateTimePicker birthdayPicker = new DateTimePicker();
        DateTimePicker homeDayPicker = new DateTimePicker();
        Button saveButton = new Button();
        Button cancelButton = new Button();

        public string CatName
        {
            get { return nameTextBox.Text; }
        }

        public DateTime Birthday
        {
            get { return birthdayPicker.Value.Date; }
        }

        public DateTime HomeDay
        {
            get { return homeDayPicker.Value.Date; }
        }

        public ProfileForm(string catName, DateTime birthday, DateTime homeDay)
        {
            Text = "Профиль кота";
            Width = 320;
            Height = 230;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            Label nameLabel = new Label();
            nameLabel.Text = "Имя питомца";
            nameLabel.Left = 20;
            nameLabel.Top = 20;
            nameLabel.Width = 120;

            nameTextBox.Left = 150;
            nameTextBox.Top = 17;
            nameTextBox.Width = 130;
            nameTextBox.Text = catName;

            Label birthdayLabel = new Label();
            birthdayLabel.Text = "Когда родился";
            birthdayLabel.Left = 20;
            birthdayLabel.Top = 60;
            birthdayLabel.Width = 120;

            birthdayPicker.Left = 150;
            birthdayPicker.Top = 57;
            birthdayPicker.Width = 130;
            birthdayPicker.Format = DateTimePickerFormat.Short;
            birthdayPicker.MaxDate = DateTime.Today;
            birthdayPicker.Value = birthday;

            Label homeDayLabel = new Label();
            homeDayLabel.Text = "С какого дня с вами";
            homeDayLabel.Left = 20;
            homeDayLabel.Top = 100;
            homeDayLabel.Width = 120;

            homeDayPicker.Left = 150;
            homeDayPicker.Top = 97;
            homeDayPicker.Width = 130;
            homeDayPicker.Format = DateTimePickerFormat.Short;
            homeDayPicker.MaxDate = DateTime.Today;
            homeDayPicker.Value = homeDay;

            saveButton.Text = "Сохранить";
            saveButton.Left = 65;
            saveButton.Top = 145;
            saveButton.Width = 90;
            saveButton.Click += SaveButton_Click;

            cancelButton.Text = "Отмена";
            cancelButton.Left = 165;
            cancelButton.Top = 145;
            cancelButton.Width = 90;
            cancelButton.DialogResult = DialogResult.Cancel;

            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(birthdayLabel);
            Controls.Add(birthdayPicker);
            Controls.Add(homeDayLabel);
            Controls.Add(homeDayPicker);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Введите имя питомца");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
