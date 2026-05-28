using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAT__проект
{
    public partial class Form1 : Form
    {
        // Основные данные кота, которые показываются на главном экране.
        string catName = "Барсик";
        DateTime birthday = new DateTime(2024, 3, 10);
        DateTime homeDay = new DateTime(2024, 4, 1);

        // Время последних действий нужно, чтобы посчитать следующий уход.
        DateTime lastEat = DateTime.Now;
        DateTime lastGlad = DateTime.Now;

        // Интервалы по умолчанию: как часто кормить и гладить кота.
        int eatEveryHours = 6;
        int gladEveryHours = 3;

        public Form1()
        {
            InitializeComponent();

            // Начальная настройка формы и полей ввода.
            Text = "CatCare";
            hoursRadioButton.Checked = true;
            feedIntervalTextBox.Text = eatEveryHours.ToString();
            petIntervalTextBox.Text = gladEveryHours.ToString();

            // Привязываем обработчики к кнопкам, полям ввода и переключателям.
            fedButton.Click += FedButton_Click;
            pettedButton.Click += PettedButton_Click;
            feedIntervalTextBox.TextChanged += IntervalTextBox_TextChanged;
            petIntervalTextBox.TextChanged += IntervalTextBox_TextChanged;
            minutesRadioButton.CheckedChanged += TimeModeChanged;
            daysRadioButton.CheckedChanged += TimeModeChanged;
            hoursRadioButton.CheckedChanged += TimeModeChanged;
            editProfileButton.Click += EditProfileButton_Click;
            Shown += Form1_Shown;

            // Сразу показываем текущую информацию о коте и действиях.
            ShowCat();
            ShowActions();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // При первом показе формы открываем окно профиля.
            OpenProfileWindow();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            // Кнопка редактирования открывает то же окно профиля.
            OpenProfileWindow();
        }

        private void OpenProfileWindow()
        {
            // Передаем текущие данные кота в окно профиля.
            ProfileForm profileForm = new ProfileForm(catName, birthday, homeDay);

            // Если пользователь нажал OK, сохраняем новые данные и обновляем экран.
            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                catName = profileForm.CatName;
                birthday = profileForm.Birthday;
                homeDay = profileForm.HomeDay;
                ShowCat();
            }
        }

        private void FedButton_Click(object sender, EventArgs e)
        {
            // Запоминаем, что кота покормили сейчас.
            lastEat = DateTime.Now;
            ShowActions();
            MessageBox.Show("Кот покормлен");
        }

        private void PettedButton_Click(object sender, EventArgs e)
        {
            // Запоминаем, что кота погладили сейчас.
            lastGlad = DateTime.Now;
            ShowActions();
            MessageBox.Show("Кота погладили");
        }

        private void IntervalTextBox_TextChanged(object sender, EventArgs e)
        {
            // Эти переменные получают новые интервалы из текстовых полей.
            int newEatHours;
            int newGladHours;

            // Меняем интервал кормления только если введено положительное число.
            if (int.TryParse(feedIntervalTextBox.Text, out newEatHours) && newEatHours > 0)
            {
                eatEveryHours = newEatHours;
            }

            // Меняем интервал поглаживания только если введено положительное число.
            if (int.TryParse(petIntervalTextBox.Text, out newGladHours) && newGladHours > 0)
            {
                gladEveryHours = newGladHours;
            }

            // После изменения интервалов пересчитываем подсказки на экране.
            ShowActions();
        }

        private void TimeModeChanged(object sender, EventArgs e)
        {
            // При смене единиц времени обновляем все подписи с датами и интервалами.
            ShowCat();
            ShowActions();
        }

        private void ShowCat()
        {
            // Заполняем подписи информацией о коте.
            catNameLabel.Text = catName;
            catBirthdayLabel.Text = "Родился: " + birthday.ToShortDateString();
            catAgeLabel.Text = "Возраст: " + GetDateText(birthday);
            withOwnerLabel.Text = "С вами: " + GetDateText(homeDay);

            // Настраиваем область фотографии кота.
            catPhotoPictureBox.BackColor = Color.LightGray;
            catPhotoPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ShowActions()
        {
            // Считаем, когда нужно снова покормить и погладить кота.
            DateTime nextEat = lastEat.AddHours(eatEveryHours);
            DateTime nextGlad = lastGlad.AddHours(gladEveryHours);

            // Показываем оставшееся время до следующих действий.
            nextFeedLabel.Text = "Кормить через " + GetTimeText(nextEat);
            nextPetLabel.Text = "Гладить через " + GetTimeText(nextGlad);
        }

        private string GetDateText(DateTime date)
        {
            // Считаем, сколько времени прошло с указанной даты.
            TimeSpan time = DateTime.Now - date;

            // Возвращаем результат в выбранных пользователем единицах.
            if (minutesRadioButton.Checked)
            {
                return ((int)time.TotalMinutes).ToString() + " мин.";
            }

            if (daysRadioButton.Checked)
            {
                return ((int)time.TotalDays).ToString() + " дн.";
            }

            return ((int)time.TotalHours).ToString() + " ч.";
        }

        private string GetTimeText(DateTime date)
        {
            // Считаем, сколько времени осталось до указанной даты.
            TimeSpan time = date - DateTime.Now;

            // Если время уже прошло, действие нужно выполнить сейчас.
            if (time.TotalSeconds < 0)
            {
                return "сейчас";
            }

            // Возвращаем оставшееся время в выбранных пользователем единицах.
            if (minutesRadioButton.Checked)
            {
                return ((int)time.TotalMinutes).ToString() + " мин.";
            }

            if (daysRadioButton.Checked)
            {
                return ((int)time.TotalDays).ToString() + " дн.";
            }

            return ((int)time.TotalHours).ToString() + " ч.";
        }
    }
}
