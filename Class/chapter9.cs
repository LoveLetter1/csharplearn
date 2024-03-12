namespace Csharp_learn.Class
{
    // 运算符重载
    // public static 返回类型 operator 运算符 （形参）
    // {
    //
    // }
    // 可以重载的一元操作符有
    // +、-、！、~、++、--、true、false
    // 可以重载的二元操作符有
    // +、-、*、/、%、&、|、^、<<、>>、==、！=、>、<、>=、<=
    public class LimitedInt
    {
        public const int MaxValue = 100;
        public const int MinValue = 0;
        private int _theValue = 0;
        public int TheValue
        {
            get { return _theValue; }
            set
            {
                if (value < _theValue)
                    _theValue = 0;
                else
                    _theValue = value > _theValue ? value : _theValue;
            }
        }

        public LimitedInt(int x)
        {
            TheValue = x;
        }

        public static int operator -(LimitedInt x, LimitedInt y)
        {
            return x.TheValue + y.TheValue;
        }
        public static int operator +(LimitedInt x, LimitedInt y)
        {
            return x.TheValue - y.TheValue;
        }
    }
}