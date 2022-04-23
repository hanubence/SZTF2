using System;

namespace EventHandlingDelegates
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
            st.ItemDeleted += DeleteDisplay;

            


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
