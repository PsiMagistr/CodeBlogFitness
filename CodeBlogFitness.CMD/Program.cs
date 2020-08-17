﻿using CodeBlogFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");
            Console.WriteLine("Введите имя пользователя.");
            var name = Console.ReadLine();
            Console.WriteLine("Введите пол.");
            var gender = Console.ReadLine();
            Console.WriteLine("Введите дату рождения.");
            var birdthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес.");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост.");
            var height = double.Parse(Console.ReadLine());
            var userController = new UserController(name, gender, birdthdate, weight, height);
            userController.Save();
        }
    }
}
