using System;
namespace Csharp_learn.Class
{
    public class MyArray
    {
        //数组的声明
        private MyData[] _myDatas = new MyData[5];
        private int[] _arr = new int[5];
        private int[] _arr2 = new int[] { 3, 4, 5, 6 };
        private int[,] _arr3 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        //new int部分可以省略
        private int[,] _arr4 = { { 1, 2 }, { 3, 4 } };
        //var 隐式声明
        //var arr = new[]{ 1, 2, 3 };在main中使用
        // 交错级数 每一维不等长
        private int[][] _jagArr = new int[3][];

        private int[][,] _jagArr2 = new int[3][,];
        //private int[][] jagArr = new int[3][4];不被允许
        public MyArray()
        {
            _jagArr[0] = new int[] { 10, 20 };
            _jagArr[1] = new int[] { 3, 4, 5 };
            _jagArr[2] = new int[] { 1, 2, 3, 4 };
        }

        public void Print()
        {
            foreach (var i in _arr)          
            {
                Console.WriteLine(i);
            }
        }
    }
}