using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunosAMS = new string[5] {
                "Dani",
                "Lucas",
                "Mari",
                "Bruno",
                "Maju" };


            Console.WriteLine(alunosAMS[3]);

            alunosAMS[3] = "Ramon";

            Console.WriteLine("");

            Console.WriteLine($"Novo valor no index 3 -> {alunosAMS[3]}");

            Console.WriteLine("");

            Console.WriteLine("ForEach");

            Console.WriteLine("");

            foreach (string aluno in alunosAMS)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("");

            Console.WriteLine("For");

            Console.WriteLine("");

            for (int i = 0; i < alunosAMS.Length; i++)
            {
                Console.WriteLine(alunosAMS[i]);
            }
            Console.WriteLine("");
        }
    }
}