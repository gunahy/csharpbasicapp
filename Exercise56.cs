using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicApp
{
    internal class Exercise56
    {

        /*
          * Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж) GetPerson():
          * Имя string Name;
          * Фамилия string Lastname;
          * Возраст int Age;
          * Наличие питомца HasPet;
          * 
          * Если питомец есть, то запросить количество питомцев int PetCount;
          * Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры) string[] GetPetsName(int PetCount);
          * Запросить количество любимых цветов int FavColorsCount;
          * Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры) string[] GetFavColors(int FavColors);
          * Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
          * Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
          * Корректный ввод: ввод числа типа int больше 0.
          * Метод, который принимает кортеж из предыдущего шага и показывает на экран данные void DataToString().
         */
        public static void Run()
        {
            var person = GetPerson();
            DisplayPerson(person);
        }
        static (string Name, string Lastname, int Age, bool HasPet, string[] Pets, string[] FavColors) GetPerson()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();

            int age = GetValidInt("Введите возраст: ");

            Console.Write("Есть ли у вас питомец? (да/Нет): ");
            bool hasPet = Console.ReadLine().ToLower() == "да";
            string[] pets = Array.Empty<string>();
            if (hasPet)
            {
                int petCount = GetValidInt("Сколько у вас питомцев?: ");
                pets = GetPetNames(petCount);
            }
            int colorCount = GetValidInt("Сколько у вас любимых цветов?: ");
            string[] favColors = GetFavColors(colorCount);

            return (name, lastname, age, hasPet, pets, favColors);
        }

        static int GetValidInt(string prompt)
        {
            int result;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out result) || result <= 0)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число больше 0.");
                }
            } while (result <= 0);

            return result;
        }

        static string[] GetPetNames(int count)
        {
            string[] petNames = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите имя питомца {i + 1}: ");
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }

        static string[] GetFavColors(int count)
        {
            string[] colors = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите ваш любимый цвет {i + 1}: ");
                colors[i] = Console.ReadLine();
            }
            return colors;
        }


        static void DisplayPerson((string Name, string Lastname, int Age, bool HasPet, string[] Pets, string[] FavColors) person)
        {
            Console.WriteLine($"\nИмя: {person.Name}");
            Console.WriteLine($"Фамилия: {person.Lastname}");
            Console.WriteLine($"Возраст: {person.Age}");

            if (person.HasPet)
            {
                Console.WriteLine("Ваши питомцы:");
                foreach (var pet in person.Pets)
                {
                    Console.WriteLine($"- {pet}");
                }
            }
            else
            {
                Console.WriteLine("Питомцев нет.");
            }

            Console.WriteLine("Любимые цвета:");
            foreach (var color in person.FavColors)
            {
                Console.WriteLine($"- {color}");
            }

            Console.ReadKey();
        }

    }
}
