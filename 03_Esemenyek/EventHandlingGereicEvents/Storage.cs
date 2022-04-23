using System;
namespace EventHandlingGenericEvents
{
    public class Storage
    {
        public class StorageEventArgs : EventArgs
        {
            public int Index { get; set; }
            public StorageEventArgs(int index)
            {
                this.Index = index;
            }
        }

        public event EventHandler<StorageEventArgs> ItemInserted;
        public event EventHandler<StorageEventArgs> ItemDeleted;

        string[] array;

        public Storage()
        {
            array = new string[0];
        }

        public int Size
        {
            get
            {
                return array.Length;
            }
        }

        public string GetItem(int index)
        {
            if (index < array.Length)
            {
                return array[index];
            }
            else
            {
                return "";
            }
        }

        public void AddItem(string item)
        {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = item;
            //new item inserted (position = newArray.Length - 1)

            ItemInserted?.Invoke(this, new StorageEventArgs(newArray.Length - 1));

            array = newArray;
        }

        public void DeleteItem(string item)
        {
            int i = 0;
            while (i < array.Length && !array[i].Equals(item))
            {
                i++;
            }
            if (i < array.Length)
            {
                string[] newArray = new string[array.Length - 1];
                for (int j = 0; j < i; j++)
                {
                    newArray[j] = array[j];
                }
                //searched item deleted (position = i)
                ItemDeleted?.Invoke(this, new StorageEventArgs(i));
                for (int j = i + 1; j < array.Length; j++)
                {
                    newArray[j - 1] = array[j];
                }
                array = newArray;
            }
        }
    }
}
