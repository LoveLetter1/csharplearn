namespace Csharp_learn.Class
{
    /* 与C不同，C#结构体允许有成员函数
     *  类是引用类型，结构体是值类型
     *  结构体不能派生其他结构体
     *  结构体的实例属性和字段不允许初始化
     *  静态属性和字段可以初始化
     *  结构体不能用protected、protected internal、abstract、sealed、virtual修饰
     */
    public struct Point
    {
        public int X;
        public int Y;

        private static int _num = 0;
        // 结构体可以有实例构造函数和静态构造函数，不能用析构函数
        // 结构体的实例构造函数即使创建，隐私无参数构造函数依然存在
        public Point(int x,int y)
        {
            X = x;
            Y = y;
            _num++;
        }
    }
}