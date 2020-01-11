//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
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

    static class InstrinsicHost
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vhi<T>(Vector128<T> x)
            where T : unmanaged
                => ginx.vhi(x);

        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector128<T> x)
            where T : unmanaged
                => ginx.vlo(x);

        [MethodImpl(Inline)]
        public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vadd(x,y);

        [MethodImpl(Inline)]
        public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vadd(x,y);

        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vand(x,y);

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vand(x,y);

        [MethodImpl(Inline)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vxor(x,y);

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vxor(x,y);

    }

    public sealed class t_method_reader : UnitTest<t_method_reader>
    {
        protected override bool TraceEnabled => false;
        
        public void read_generic_type()
        {

            var def = typedef(typeof(TestMethods<>));
            NativeReader.generic(def, typeof(uint), (m,data) => Trace(data.Format()));
        }

        public void write_generic_methods_1()
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define("intrinsics"), "test_1", FileExtension.Define("asm"));
            using var writer = path.Writer();
            var types = new Type[]{
                typeof(byte), typeof(ushort), typeof(uint), typeof(ulong),
                typeof(sbyte), typeof(short), typeof(int), typeof(long), 
                typeof(float), typeof(double)
                };
            foreach(var t in types)
                typeof(InstrinsicHost).CaptureGenericAsm(t,writer);
                    

        }

        public void write_generic_methods_2()
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define("intrinsics"), "test_2", FileExtension.Define("asm"));
            using var writer = dst.Writer();
            typeof(InstrinsicHost).StaticMethods().OpenGeneric().CaptureGenericAsm(typeof(int), writer);

        }
        public void read_generic_methods()
        {                        

            foreach(var m in typeof(InstrinsicHost).CaptureGenericAsm(typeof(uint)))
                Trace(m.Format(8));
        }

        public void read_by_name()
        {
            Span<byte> buffer = new byte[128];
            var m1 = NativeReader.read<TestMethods>(nameof(TestMethods.and_ng),buffer);            

            buffer.Clear();
            var m2 = NativeReader.read<TestMethods>(nameof(TestMethods.or_ng),buffer);
            
            buffer.Clear();
            var m3 = NativeReader.read<TestMethods>(nameof(TestMethods.test_writeline),buffer);            
        }

        public void read_non_generic()
        {
            var methods = type<TestMethods>().StaticMethods().ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = NativeReader.read(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }
        }

        public void write_non_generic()
        {
            var methods = typeof(math).StaticMethods().NonGeneric();
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define("math"), "test_1", FileExtension.Define("asm"));
            using var dst = path.Writer();
            methods.CaptureAsm(dst);
            dst.Flush();
            
        }
        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);


        public void read_delegate()
        {
            
            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            var dAndData = dAnd.CaptureDelegateAsm(100);
            Trace("And:delegate");
            Trace(dAndData.Format());

            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            var mAndData = mAnd.CaptureAsm();
            Trace("And:Method");
            Trace(mAndData.Format());

            var dShuffle = shuffler(4);
            var dShuffleData = dShuffle.CaptureDelegateAsm(100);
            
            Trace("Shuffle:Delegate");
            Trace(dShuffleData.Format());

            var dShift = shifter(4);
            var dShiftData = dShift.CaptureDelegateAsm(100);
            Trace("Shift:Delegate");
            Trace(dShiftData.Format());

            var mgAnds = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName(nameof(ginx.vand));
            foreach(var mgAnd in mgAnds)
            {
                var mgAndData = mgAnd.CaptureGenericAsm(typeof(uint));
                Trace($"{mgAnd.Signature()}");                
                Trace(mgAndData.Format());
            }

        }

        public void read_library()
        {
            var methods = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            Span<byte> buffer = new byte[128];
            for(var i=0; i<methods.Length; i++)
            {
                var m = NativeReader.read(methods[i], buffer);
                Trace(m.Format());
                buffer.Clear();
            }
        }
    }
}