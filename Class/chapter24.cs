#define debug
using System;

// #undef debug
namespace Csharp_learn.Class
{
    // 预处理指令不用分号结尾，允许行尾注释
    // #define和#undef
    // #define和#undef只能用在源文件第一行，也就是任何c#代码之前
    public class Demo
    {
        public static void Enter()
        {
            #if !debug
            // #error Message,Message触发时禁止编译
            #error Can't Debug
            #endif
            #warning change debug to !debug
            
        }
        //区域指令和注释一样

        #region ClassCreated

        public class Math
        {
            
        }

        #endregion
    }
}