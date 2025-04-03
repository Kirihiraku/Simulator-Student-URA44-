using System;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        private int energy = 50;
        private int hunger = 10;
        private int happiness = 50;
        private int knowledge = 20;
        private decimal money = 100;
        private string schedule = "Понедельник: Лекции по математике\nВторник: Лабораторная работа по физике";
        private string notifications = "Внимание: Скоро экзамен по программированию!";
        private int course = 3;

        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Обновляем параметры, чтобы гарантировать, что они находятся в допустимом диапазоне
            energy = Math.Max(0, Math.Min(100, energy));
            hunger = Math.Max(0, Math.Min(100, hunger));
            happiness = Math.Max(0, Math.Min(100, happiness));
            knowledge = Math.Max(0, Math.Min(100, knowledge));

            // Обновляем прогресс бары
            progressBarEnergy.Value = energy;
            progressBarHunger.Value = hunger;
            progressBarHappiness.Value = happiness;
            progressBarKnowledge.Value = knowledge;

            // Обновляем текстовые поля
            textBoxMoney.Text = money.ToString();
            textBoxSchedule.Text = schedule;
            textBoxNotifications.Text = notifications;
            textBoxCourse.Text = course.ToString();

            // Проверка на смерть с разными сообщениями
            if (energy <= 0)
            {
                MessageBox.Show("Вы умерли от истощения!");
                DisableButtons();
            }
            else if (hunger >= 100)
            {
                MessageBox.Show("Вы умерли от голода!");
                DisableButtons();
            }
            else if (happiness >= 100)
            {
                MessageBox.Show("Вы умерли от передозировки счастья!");
                DisableButtons();
            }
            else if (knowledge <= 0)
            {
                MessageBox.Show("Вы умерли от недостатка знаний!");
                DisableButtons();
            }
            else if (knowledge >= 100)
            {
                MessageBox.Show("Вы умерли от достатка знаний!");
                DisableButtons();
            }
            else if (energy >= 100)
            {
                MessageBox.Show("Вы умерли от переизбытка энергии!");
                DisableButtons();
            }
            else if (happiness == 100)
            {
                MessageBox.Show("Вы умерли от депрессии!");
                DisableButtons();
            }
            else if (hunger <= 0)
            {
                MessageBox.Show("Вы умерли от своего веса!");
                DisableButtons();
            }
        }

        private void DisableButtons()
        {
            buttonStudy.Enabled = false;
            buttonRelax.Enabled = false;
            buttonEat.Enabled = false;
            buttonWork.Enabled = false;
            buttonRestart.Enabled = true; // Включаем кнопку перезапуска
        }

        private void buttonStudy_Click(object sender, EventArgs e)
        {
            // Логика для "Учиться"
            knowledge += 10;
            energy -= 10;
            hunger += 15;
            happiness -= 10;
            UpdateUI();
            MessageBox.Show("Вы учились!");
        }

        private void buttonRelax_Click(object sender, EventArgs e)
        {
            // Логика для "Отдыхать"
            energy += 25;
            happiness += 25;
            hunger += 10;
            UpdateUI();
            MessageBox.Show("Вы отдохнули!");
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            // Логика для "Поесть"
            hunger -= 20;
            money -= 50; // Предположим, что еда стоит денег
            UpdateUI();
            MessageBox.Show("Вы поели!");
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            // Логика для "Работать"
            money += 50;
            energy -= 10;
            happiness -= 10;
            hunger += 25;
            UpdateUI();
            MessageBox.Show("Вы поработали!");
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            // Сброс значений
            energy = 50;
            hunger = 10;
            happiness = 50;
            knowledge = 20;
            money = 100;
            schedule = "Понедельник: Лекции по математике\nВторник: Лабораторная работа по физике";
            notifications = "Внимание: Скоро экзамен по программированию!";
            course = 3;

            UpdateUI();

            // Включаем все кнопки снова
            buttonStudy.Enabled = true;
            buttonRelax.Enabled = true;
            buttonEat.Enabled = true;
            buttonWork.Enabled = true;
            buttonRestart.Enabled = false; // Отключаем кнопку перезапуска
        }
    }
}
