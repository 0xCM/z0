//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    class TestMethods
    {
        public static uint Add(uint a, uint b)
            => a + b;

        public static uint Sub(uint a, uint b)
            => a - b;

        public static uint Mul(uint a, uint b)
            => a * b;

        public static void WriteLine()
            => Console.WriteLine("");
    }

    public sealed class t_method_reader : UnitTest<t_method_reader>
    {
        public void read_by_name()
        {
            Span<byte> buffer = new byte[128];
            var m1 = MethodReader.ReadMethod<N128,TestMethods>(nameof(TestMethods.Add),buffer);            

            buffer.Clear();
            var m2 = MethodReader.ReadMethod<N128,TestMethods>(nameof(TestMethods.Sub),buffer);
            
            buffer.Clear();
            var m3 = MethodReader.ReadMethod<N128,TestMethods>(nameof(TestMethods.WriteLine),buffer);            
        }

        public void read_reflected_1()
        {
            var methods = type<TestMethods>().StaticMethods().ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = MethodReader.ReadMethod(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }
        }

        public void read_reflected_2()
        {
            var methods = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = MethodReader.ReadMethod(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }

        }

    }

}