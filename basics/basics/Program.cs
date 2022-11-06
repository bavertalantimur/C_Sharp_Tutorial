namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string message="Hello";
            Console.WriteLine(message);
            Property p = new Property();
            p.StudentId = 6;
            Console.WriteLine(p.StudentId);

            StudentObject student= new StudentObject();
            student.FirstName = "Baver";
            student.LastName = "Talantimur";
            student.GetFullName();




        }

    }
}

