using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PushNotification message = new PushNotification("Janobourian", "Hello my friend, I need your help with a problem in GCP", "25/10/2022");
            Console.WriteLine("The date is: {0}", message.showDateNow());
            message.showNotification();
            Console.ReadLine();
        }
    }
}
