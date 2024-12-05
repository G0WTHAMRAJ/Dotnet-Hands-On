using System;


namespace SampleProject
{
    internal class Overloading
    {
        public string Make { get; set; }
        public string Model { get; set; }

  
        public Overloading(string make, string model)
        {
            Make = make;
            Model = model;
        }

       
        public void Start()
        {
            Console.WriteLine($"The car {Make} {Model} is starting with a key.");
        }

        public void Start(string keyType)
        {
            Console.WriteLine("Only one argument");
            Console.WriteLine($"The car {Make} {Model} is starting with a {keyType} key.");
        }

        public void Start(bool remoteStart, string keyType)
        {
            if (remoteStart)
            {
                Console.WriteLine("Two argument");
                Console.WriteLine($"The car {Make} {Model} is starting remotely using a {keyType} key.");
            }
            else
            {
                Console.WriteLine($"The car {Make} {Model} is starting manually using a {keyType} key.");
            }
        }
    }
}
