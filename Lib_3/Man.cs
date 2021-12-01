using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_3
{
    public class Man
    {
        int age, // возраст
           weight, // вес
           height; // рост
        string gender; // пол

        // конструктор с параметрами
        public Man(string firstName, int age, int weight, int height, string gender)
        {
            FirstName = firstName;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }
        // конструктор без параметров(по умолчанию)
        public Man()
        {
            FirstName = "Екатерина";
            Age = 20;
            Weight = 50;
            Height = 160;
            Gender = "Женский";
        }

        // Имя
        public string FirstName { get; set; }

        // возраст
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    MessageBox.Show("Возраст не может быть отрицательным");
                }
            }
        }

        // вес
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
                else
                {
                    MessageBox.Show("Вес не может быть отрицательным");
                }
            }
        }

        // рост
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    MessageBox.Show("Рост не может быть отрицательным");
                }
            }
        }

        // пол
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == "Мужской" || value == "Женский")
                {
                    gender = value;
                }
                else
                {
                    MessageBox.Show("Пол должен быть \"Мужской\" или \"Женский\"");
                }
            }
        }

        // метод изменения имени
        public void SetParams(string firstName)
        {
            FirstName = firstName;
        }

        // метод изменения параметров человека (абсолютно всех)
        public void SetParams(string firstName, int age, int weight, int height, string gender)
        {
            FirstName = firstName;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }

        // метод изменения параметров человека (возраста, веса, роста)
        public void SetParams(int age, int weight, int height)
        {
            Age = age;
            Weight = weight;
            Height = height;
        }

            // метод формирования строки с информацией о человеке
            public string GetString()
        {
            string str = $"Имя: {FirstName} Возраст: {Age} Вес: {Weight} Рост: {Height} Пол: {Gender}";
            return str;
        }

        // метод формирования строки для MessegeBox с отступами на след. строчку
        public string GetStringForMB()
        {
            string str = $"Имя: {FirstName}\nВозраст: {Age}\nВес: {Weight}\nРост: {Height}\nПол: {Gender}";
            return str;
        }

        // увеличение возраста на 1 год
        public static Man operator ++(Man man)
        {
            man.Age += 1;
            return man;
        }
        // сравнение >
        public static bool operator >(Man man, Man man2)
        {
            return man.Weight > man2.Weight;
        }
        // сравнение <
        public static bool operator <(Man man, Man man2)
        {
            return man.Weight < man2.Weight;
        }

    }
}
