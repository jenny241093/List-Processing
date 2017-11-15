namespace Engine.cs
{
    using System;

    using InPut;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, InputProvider.ReadLine()));
        }
    }
}
