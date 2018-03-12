using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество студентов: ");
            int size_list = Convert.ToInt32(Console.ReadLine());
            // с помощью конструктора с параметрами создаем объект класса car_list 
            // (сразу устанавливаем емкость списка внутри класса) 
            ProductList car_list = new ProductList(size_list);
            // заполнение данными 
            for (int i = 0; i < size_list; i++)
            {
                car_list.AddItem();
            }
            Console.Clear();
            // используем индексатор 
            // car_list[i] - возвращает целый объект класса Car 
            // используем метод Print(), который мы реализовали в классе Car 
            // для вывода значений объекта класса 
            for (int i = 0; i < size_list; i++)
            {
                car_list[i].Print();
            }
            Console.ReadKey();

        }
    }
}
