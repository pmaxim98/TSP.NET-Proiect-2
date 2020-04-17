using System;
using System.ServiceModel;
using System.ServiceModel.Description;

using MyPhotosObjectWCF;

namespace MyPhotosHostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WCF Server");

            ServiceHost host = new ServiceHost(typeof(MyPhotosService), new Uri("http://localhost:8000/PC"));

            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("Address: {0} \nBinding: {1}\nContract: {2}\n", se.Address, se.Binding.Name, se.Contract.Name);

            host.Open();
            Console.WriteLine("Waiting for connections! Press 'Enter' to close.");
            Console.ReadKey();
            host.Close();
        }
    }
}
