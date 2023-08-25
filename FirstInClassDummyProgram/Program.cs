using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstInClassDummyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pizza pizza = new Pizza();
            
            //Console.WriteLine(pizza.PizzaType);
            //pizza.MakeHawaiian();

            //Console.WriteLine(pizza.PizzaType);

            //Console.ReadLine();

            MessageKeeper messageKeeper = new MessageKeeper();

            messageKeeper.ReadMessage();
            messageKeeper.ReadMessage();
            messageKeeper.ReadMessage();
            messageKeeper.ReadMessage();

            Console.WriteLine(messageKeeper.GetAccessedCount());

            Console.ReadLine();
        }
    }

    class Pizza
    {
        public string PizzaType = "cheese";

        public void MakeHawaiian()
        {
            PizzaType = "hawaiian";
        }
    }

    class MessageKeeper
    {
        string TheMessage = "I will keep your message safe";
        int MessageAccessedCount = 0;

        public void SetMessage(string newMessage)
        {
            TheMessage = newMessage;
        }

        public void ReadMessage()
        {
            MessageAccessedCount++;
            Console.WriteLine(TheMessage);
        }

        public int GetAccessedCount()
        {
            return MessageAccessedCount;
        }
    }
}
