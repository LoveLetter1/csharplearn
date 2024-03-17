using System;
using System.Collections;

namespace Csharp_learn.Class
{
    //枚举器和枚举器
    public class ColorEnumerator : IEnumerator
    {
        private string[] colors;
        private int position = -1;

        public ColorEnumerator(string[] arr)
        {
            colors = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                colors[i] = arr[i];
            }
            
        }
        
        public bool MoveNext()
        {
            if (position < colors.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                if (position == -1)
                    throw new InvalidOperationException();
                if(position>=colors.Length)
                    throw new InvalidOperationException();
                return colors[position];
            }
        }
    }
    public class Spectrum : IEnumerable
    {
        private string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }
    }
    //yield return封装了IEnumerator
    public class CustomList : IEnumerable
    {
        private int[] list = { 1, 2, 3, 4, 5, 6, 7, 8 };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
                yield return list[i];
        }
    }
    

    public class Program19
    {
        public static void Main1()
        {
            CustomList customList = new CustomList();
            foreach (var i in customList)
            {
                Console.WriteLine(i);
            }
        }
    }
}