using System;
using System.Reflection;

namespace Alqoritms
{

    public class Tasks
    {
        public void CallTask(int TaskNum)
        {
            string methodName = "Task_" + TaskNum;

            MethodInfo method = this.GetType().GetMethod(methodName,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            method.Invoke(this, null);
        }

        public bool IsPositiveNum(int num)
        {
            return num > 0;
        }

        public void Task_1()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (!IsPositiveNum(age))
                {
                    Console.WriteLine("Age must be a positive number!");
                    Task_1();
                    return;
                }

                Console.WriteLine("Your age is " + age);

                if (age >= 65 && age <= 125)
                {
                    Console.WriteLine("You are pensioner :)");
                }
                else
                {
                    Console.WriteLine("You are not pensioner!");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number!");
                Task_1();
            }
        }
        public void Task_2()
        {

        }
        public void Task_3()
        {

        }
        public void Task_4()
        {

        }
        public void Task_5()
        {

        }
        public void Task_6()
        {

        }
        public void Task_7()
        {

        }
        public void Task_8()
        {

        }
        public void Task_9()
        {

        }
        public void Task_10()
        {

        }
        public void Task_11()
        {

        }
        public void Task_12()
        {

        }
        public void Task_13()
        {

        }
        public void Task_14()
        {

        }
        public void Task_15()
        {

        }
        public void Task_16()
        {

        }
        public void Task_17()
        {

        }
        public void Task_18()
        {

        }
        public void Task_19()
        {

        }
        public void Task_20()
        {

        }
    }
}