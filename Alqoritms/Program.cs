using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using Alqoritms;

namespace Alqoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTasksLoop();
        }
        static void RunTasksLoop()
        {
            Tasks task = new Tasks();
            bool continueTasks = true;

            while (continueTasks == true)
            {
                ChooseTask(task);
                continueTasks = CheckAnotherTaks();
            }

            Console.WriteLine("Bye! Have a greate day ^_^");
        }

        static void ChooseTask(Tasks task)
        {
            try
            {
                Console.WriteLine("Hi! Please choose the task you want to check ^_^");
                int ChoosedTask = Convert.ToInt32(Console.ReadLine());
                task.CallTask(ChoosedTask);
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                ChooseTask(task);
            }
        }
        static bool CheckAnotherTaks()
        {
            Console.WriteLine("Do you want check another task ? :3 \nChoose : Y / N ?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter correct answer!");
                return CheckAnotherTaks();
            }
        }
    }
}
