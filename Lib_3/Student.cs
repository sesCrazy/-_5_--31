using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_3
{
    public class Student : Man
    {
        int grade;

        public Student(string firstName, int age, int weight, int height, string gender, int grade, string department, string group)
        {
            FirstName = firstName;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            Grade = grade;
            Department = department;
            Group = group;
        }
        public Student()
        {
            FirstName = "Иван";
            Age = 18;
            Weight = 60;
            Height = 170;
            Gender = "Мужской";
            Grade = 1;
            Department = "Программирование";
            Group = "п-11";
        }

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    grade = value;
                }
                else
                {
                    MessageBox.Show("Курс должен быть 1, 2, 3, 4 или 5");
                }
            }
        }
        public string Department { get; set; }
        public string Group { get; set; }

        public void ChangeAge(int age)
        {
            Age = age;
        }
        public void ToNextGrade()
        {
            if (Grade + 1 <= 5) Grade++;
            else
            {
                MessageBox.Show("Текущий курс последний.");
            }
        }
        public void ChangeGroup(string group)
        {
            Group = group;
        }
        public new string GetString()
        {
            // метод формирования строки с информацией о студенте
            string str = $"Имя: {FirstName} Возраст: {Age} Вес: {Weight} Рост: {Height} Пол: {Gender} Факультет: {Department} Курс: {Grade} Группа: {Group}";
            return str;

        }
        public new string GetStringForMB()
        {
            // метод формирования строки для MessegeBox с отступами на след. строчку
            string str = $"\nИмя: {FirstName}\nВозраст: {Age}\nВес: {Weight}\nРост: {Height}\nПол: {Gender}\nФакультет: {Department}\nКурс: {Grade}\nГруппа: {Group}";
            return str;
        }
    }
}
