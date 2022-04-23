using System;
using EventHandlingEvents;

namespace LA03_04_EventHandlingEvents
{
    class Program
    {
        static void InsertDisplay(int index)
        {
            Console.WriteLine("New item inserted at postion " + index);
        }

        static void DeleteDisplay(int index)
        {
            Console.WriteLine("New item deleted at postion " + index);
        }

        static void Main(string[] args)
        {
            Storage st = new Storage();

            st.ItemInserted += InsertDisplay;
            st.ItemInserted += (index) => Console.WriteLine("Elem hozzáadva ide: " + index);


            st.ItemDeleted += DeleteDisplay;
            st.ItemDeleted += delegate(int index) {
                Console.WriteLine("Elem törölve innen: " + index);
	        };
            


            st.AddItem("arduino");
            st.AddItem("raspberry");
            st.AddItem("stm32");
            st.AddItem("nodemcu");
            st.AddItem("esp");
            st.AddItem("fpga");

            st.DeleteItem("nodemcu");
            st.DeleteItem("stm32");

            for (int i = 0; i < st.Size; i++)
            {
                Console.WriteLine(st.GetItem(i));
            }

            Console.ReadLine();
        }
    }
}
