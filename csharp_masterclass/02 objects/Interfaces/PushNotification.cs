using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PushNotification: INotification
    {

        private string sender;
        private string message;
        private string date;

        public string Sender { get => this.sender; set => this.sender = value; }
        public string Message { get => this.message; set => this.message = value; }
        public string Date { get => this.date; set => this.date = value; }

        public PushNotification(string sender, string message, string date)
        {
            Sender = sender;
            Message = message;
            Date = date; 
        }
        public void showNotification()
        {
            Console.WriteLine(Message);
        }

        public string showDateNow()
        {
            return Date;
        }
    }
}
