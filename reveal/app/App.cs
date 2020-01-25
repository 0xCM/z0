//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Linq;

    using static zfunc;

    class App
    {                

        void EmitFunctions(Type host)
            => AsmProcessServices.Emitter().EmitFunctions(host);

        void EmitFunctions<T>()
            => EmitFunctions(typeof(T));

        void Extract()
        {                        
            new ExperimentalScenarios().Emit();
            new PrimalScenarios().Emit();
            iter(GetType().Assembly.Types().WithAttributions(typeof(OpCodeProvider)), EmitFunctions);
        }

        void Run()
        {

            try
            {
                Extract();
            }
            catch(Exception e)
            {
                print(appMsg(e));
            }
        }

        public static void Main(params string[] args)
            => new App().Run();
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OpCodeProvider : Attribute
    {


    }

}