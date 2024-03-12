namespace Csharp_learn.Class
{
    // 枚举是值类型
    // 枚举只有一种类型的成员：命名的整数值常量
    // 每个枚举类型都有个底层整数类型，默认为int
    // 默认情况下，第一个成员赋值为0，后面依次+1
    enum TrafficLight
    {
        Green,
        Yello,
        Red
    }
    // 可以在枚举名后面加上int以外的其他整数类型
    // 枚举可以有重复的值，但不能有重复的名称
    enum TrafficLightNew:ulong
    {
        Green=10,
        Yello=10,
        Red=15
    }
    // 隐式成员编号
    enum FaceCard
    {
        Jack=11, //11
        Queen,   //12
        King,    //13
        Ace,     //14
        Num=4,   //4
        SomeOther,          //5
        HighestFaceCard=Ace //14
    }
}