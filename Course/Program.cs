using Course.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\temp\projetos\interfaces5-csharp\in.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee e in list)
                {
                    Console.WriteLine(e);
                }
            }
        }
        catch (IOException e)
        {   
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}