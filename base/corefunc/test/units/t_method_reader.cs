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
        /*
        0000h 0x0f 0x1f 
        0002h 0x44 0x00 
        0004h 0x00 0x8b 
        0006h 0xc1 0x23 
        0008h 0xc2 0xc3 
        000ah 0x00 0x00 
        */
        public static uint and_ng(uint a, uint b)
            => a & b;

        /*
        0000h 0x0f 0x1f 
        0002h 0x44 0x00 
        0004h 0x00 0x8b 
        0006h 0xc1 0x0b 
        0008h 0xc2 0xc3 
        000ah 0x00 0x00 
        */
        public static uint or_ng(uint a, uint b)
            => a | b;

        /*
        0000h 0x0f 0x1f 
        0002h 0x44 0x00 
        0004h 0x00 0x8b 
        0006h 0xc1 0x33 
        0008h 0xc2 0xc3 
        000ah 0x00 0x00 
        */
        public static uint xor_ng(uint a, uint b)
            => a ^ b;

        public static void test_writeline()
            => Console.WriteLine("");
    }

    class TestMethods<T>
        where T : unmanaged
    {
        public static T and_gt(T a, T b)
            => gmath.and(a,b);

        public static T or_gt(T a, T b)
            => gmath.or(a,b);

        public static T xor_gt(T a, T b)
            => gmath.xor(a,b);

    }

    static class GenericMethodHost
    {
        public static T and_gm<T>(T a, T b)
            where T : unmanaged
                => gmath.and(a,b);

        public static T or_gm<T>(T a, T b)
            where T : unmanaged
                => gmath.or(a,b);

        public static T xor_gm<T>(T a, T b)
            where T : unmanaged
                => gmath.xor(a,b);

    }

    public sealed class t_method_reader : UnitTest<t_method_reader>
    {

        public void read_generic_type()
        {

            var def = typedef(typeof(TestMethods<>));
            MethodReader.generic(def, typeof(uint), (m,data) => Trace(data.Format()));
        }

        public void read_generic_methods()
        {
            foreach(var m in typeof(GenericMethodHost).ReifyGeneric<uint>())
                Trace(m.Format());
        }

        public void read_by_name()
        {
            Span<byte> buffer = new byte[128];
            var m1 = MethodReader.read<TestMethods>(nameof(TestMethods.and_ng),buffer);            

            buffer.Clear();
            var m2 = MethodReader.read<TestMethods>(nameof(TestMethods.or_ng),buffer);
            
            buffer.Clear();
            var m3 = MethodReader.read<TestMethods>(nameof(TestMethods.test_writeline),buffer);            
        }

        public void read_non_generic()
        {
            var methods = type<TestMethods>().StaticMethods().ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = MethodReader.read(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }
        }

        public void read_library()
        {
            var methods = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = MethodReader.read(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }
        }
    }
}