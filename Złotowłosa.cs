using System;

namespace klasy.Złotowłosa
{
    public class Złotowłosa
    {
        public string złotowłosa;

        public void Mówi(string treść)
        {
            Console.WriteLine(złotowłosa + " mówi: " + treść);
        }
    }
    public class Czynności
    {
        public void Zjada()
        {
            Console.WriteLine(" mlask mlask, mmmm pycha!");
        }
        public void Siada()
        {
            Console.WriteLine(" trzask..., ałaa");
        }
        public void Zasypia()
        {
            Console.WriteLine("aaaaa... dobranoc");
        }
    }

} 
