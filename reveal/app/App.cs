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
        void EmitAll()
        {                        
            new ExperimentalScenarios().Emit();
            new PrimalScenarios().Emit();
            var a = GetType().Assembly;
            var clridx = ClrMetadataIndex.Create(a);
            var context = AsmServices.Context(clridx, DataResourceIndex.Empty, AsmFormatConfig.Default);
            foreach(var t in a.GetTypes().WithAttributions(typeof(OpCodeProvider)))
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