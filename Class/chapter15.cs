using System;

namespace Csharp_learn.Class
{
   //事件是成员，必须声明在类或结构中
   //事件成员隐式初始化为null
   //事件初始化语句为
   //class Incrementer{
   //    public event 委托类型 事件名；
   //}
   //订阅者向事件添加事件处理程序。事件处理程序必须具有与事件的委托相同的返回类型和签名
   //使用+=为事件添加事件处理程序
   //事件处理程序的规范可以是以下几种：实例方法、静态方法、匿名方法、Lambda表达式
   public delegate void Handler();

   public class Incrementer
   {
      public event EventHandler CountedADozen;
      public void DoCount()
      {
         for(int i=1;i<100;i++)
            if (i % 12 == 0 && CountedADozen != null)
               CountedADozen(this,null);
      }
   }

   public class Dozens
   {
      public int DozensCount { get; private set; }

      public Dozens(Incrementer incrementer)
      {
         DozensCount = 0;
         incrementer.CountedADozen += IncrementDozensCount;
      }

      public void IncrementDozensCount(object scoure,EventArgs e)
      {
         DozensCount++;
      }
   }
   //通过扩展EventArgs来传递数据
   public class IncrementerEventArgs : EventArgs
   {
      public int IterationCount { get; set; }
      
   }
}