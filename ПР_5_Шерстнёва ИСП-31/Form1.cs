using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_3;

namespace ПР_5_Шерстнёва_ИСП_31
{
    public partial class Form1 : Form
    {
        Lib_3.Man man = new Man();
        Lib_3.Man man2 = new Man();

        Lib_3.Student student = new Student();

        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №7, Вариант 3.\n" +
                "Шерстнёва Евгения ИСП-31\n" +
                "Использовать класс Man (человек), с полями: имя, возраст, пол и вес. " +
                "Создать производный класс Student, имеющий поля факультет, курс, группа. " +
                "Определить методы изменения возраста, веса, перехода на следующий курс, перевода в другую группу.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void изменитьСтудента_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbAge.Text, out int age) &&
                Int32.TryParse(tbHeight.Text, out int height) &&
                Int32.TryParse(tbWeight.Text, out int weight) &&
                Int32.TryParse(tbGrade.Text, out int grade))
            {
                student.SetParams(tbName.Text);
                student.Gender = cbGen.SelectedItem.ToString();
                student.SetParams(age, weight, height);
                student.Department = tbDepartment.Text;
                student.Grade = grade;
                student.Group = tbGroup.Text;
            }
            else
            {
                MessageBox.Show("Возраст, вес, рост и курс должны быть целыми числами");
            }
        }

        private void оСтуденте_Click(object sender, EventArgs e)
        {

            MessageBox.Show(student.GetStringForMB());
        }

        private void изменитьВозрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbChangeAge.Text, out int age)) student.Age = age;
            else MessageBox.Show("Возраст должен быть целым числом");
        }

        private void изменитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            student.ChangeGroup(tbChangeGroup.Text);
        }

        private void наСледКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student.ToNextGrade();
        }
    }
}
