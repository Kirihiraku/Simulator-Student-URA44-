using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        private int energy = 100;
        private int hunger = 0;
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
            progressBarEnergy.Value = energy;
            progressBarHunger.Value = hunger;
            progressBarHappiness.Value = happiness;
            progressBarKnowledge.Value = knowledge;
            textBoxMoney.Text = money.ToString();
            textBoxSchedule.Text = schedule;
            textBoxNotifications.Text = notifications;
            textBoxCourse.Text = course.ToString();

            // Ensure progress bar values are within valid range
            energy = Math.Max(0, Math.Min(100, energy));
            hunger = Math.Max(0, Math.Min(100, hunger));
            happiness = Math.Max(0, Math.Min(100, happiness));
            knowledge = Math.Max(0, Math.Min(100, knowledge));
        }

        private void buttonStudy_Click(object sender, EventArgs e)
        {
            // Логика для "Учиться"
            knowledge += 10;
            energy -= 10;
            hunger += 5;
            happiness -= 15;
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
            MessageBox.Show("Вы были взломаны Саней!");
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            // Логика для "Поесть"
            hunger -= 30;
            money -= 10; // Предположим, что еда стоит денег
            UpdateUI();
            MessageBox.Show("Вы были взломаны негром Арсеном!");
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            // Логика для "Работать"
            money += 50;
            energy -= 10;
            happiness -= 5;
            UpdateUI();
            MessageBox.Show("Вы поработали!");
        }
    }
}