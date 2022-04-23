using System;
using EventHandlingGenericEvents;

namespace LA03_05_EventHandlingGenericEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage st = new Storage();

            st.ItemInserted += (object sender, Storage.StorageEventArgs e) =>
            {
                Console.WriteLine("Item inserted at postion: " + e.Index);
            };

            st.ItemDeleted += (object sender, Storage.StorageEventArgs e) =>
            {
                Console.WriteLine("Item deleted at postion: " + e.Index);
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
