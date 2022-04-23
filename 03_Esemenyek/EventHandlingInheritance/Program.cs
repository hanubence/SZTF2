using System;

namespace EventHandlingInheritance
{
    class MyStorage : Storage
    {
        public override void ItemDeleted(int index)
        {
            Console.WriteLine("New item deleted at position " + index);
        }

        public override void ItemInserted(int index)
        {
            Console.WriteLine("New item insterted at position " + index);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Storage st = new MyStorage();
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

