namespace HumanObj
{
    class Human
    {
        public string Name;
        public string Surname;
        public string Gender;
        public string Nationality;
        public int Age;
        public Human(string Name , string Surname , string Gender , string Nationality , int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.Nationality = Nationality;
            this.Age = Age;
        }
        public void GetFullName(){
            Console.WriteLine($"Your full name is {Name}  {Surname}");
        }
        public void ShowBirthYear(){
            int result = 0;
            result = 2025 - Age;
            Console.WriteLine($"Your birth year is {result}");
        }

    }
}