using System;

namespace EventHandlingInterfaces
{
    class MyDisplay : IStorageDisplay
    {
        public void ItemDeleted(int index)
        {
            Console.WriteLine("New item deleted at position " + index);
        }

        public void ItemInserted(int index)
        {
            Console.WriteLine("New item inserted at position " + index);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            MyDisplay display = new MyDisplay();
            Storage st = new Storage(display);
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
