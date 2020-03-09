//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static zfunc;

    class App
    {                
        void EmitAll()
        {                        
            new ExperimentalScenarios().Emit();
            var a = GetType().Assembly;
            var clridx = a.CreateClrIndex();

            var context = AsmContext.New();
            foreach(var t in a.GetTypes().Tagged(typeof(OpCodeProvider)))
            {
                var emitter = AsmProcessServices.Emitter(context);
                emitter.EmitFunctions(t);                
            }
        }

        void Run()
        {                
            try
            {
                EmitAll();
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