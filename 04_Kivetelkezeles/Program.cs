using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Kivetel
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage st = new Storage(3, 3);

            st.AddItem("Béla");
            st.AddItem("Géza");
            st.AddItem("Kati");
            st.AddItem("Béla");
            st.AddItem("Géza");
            st.AddItem("Kati");
            st.AddItem("Béla");
            st.AddItem("Géza");
            st.AddItem("Kati");
            st.AddItem("Kati");
            st.AddItem("Kati");



            try
            {
                st.AddItem("Béla");
                st.AddItem("Géza");
                st.AddItem("Kati");
                st.AddItem("Béla");
                st.AddItem("Géza");
                st.AddItem("Kati");
                st.AddItem("Béla");
                st.AddItem("Géza");
                st.AddItem("Kati");
                st.AddItem("Kati");
            }
            catch(StorageFullException ste)
            {
                Console.WriteLine(ste.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }


            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(st.GetItem(i,j)+ "\t");
                }
                Console.WriteLine();
            }

            ;

        }

        
    }
}
