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
    using System.Reflection;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static NativeTestCases;

    public sealed class t_native_reader : UnitTest<t_native_reader>
    {
        protected override bool TraceEnabled => true;
        
        public void capture_generic_type()
        {
            using var writer = NativeTestWriter();
            var def = typedef(typeof(GenericTypeCases<>));
            var types = PrimalKind.Integers.PrimalTypes();
            foreach(var t in types)
            foreach(var captured in NativeReader.gtype(def,t))
                writer.WriteLine(captured.Format(4));
        }

        public void capture_vectorized_generics()
        {
            using var writer = NativeTestWriter();
            var types = PrimalKind.All.PrimalTypes();
            foreach(var t in types)
                typeof(VectorizedCases).CaptureNativeGeneric(t,writer);                    

        }


        public void capture_direct()
        {
            using var writer = NativeTestWriter();
            typeof(DirectMethodCases).CaptureNative(writer);

            // var methods = type<DirectMethodCases>().StaticMethods().ToArray();
            // typeof(DirectMethodCases).FastOpMethods();

            // Span<byte> buffer = new byte[128];
            // for(var i=0; i<methods.Length; i++)
            // {
            //     var m = NativeReader.read(methods[i], buffer);
            //     Trace(m.Format());
            //     buffer.Clear();
            // }
        }

        public void write_non_generic()
        {
            var methods = typeof(math).StaticMethods().NonGeneric();
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define("math"), "test_1", FileExtension.Define("asm"));
            using var dst = path.Writer();
            methods.CaptureNative(dst);
            dst.Flush();
            
        }
        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);


        public void read_delegate()
        {
            Span<byte> buffer = new byte[100];
            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            var dAndData = dAnd.CaptureNative(buffer);
            Trace("And:delegate");
            Trace(dAndData.Format());

            buffer.Clear();
            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            var mAndData = mAnd.CaptureNative(buffer);
            Trace("And:Method");
            Trace(mAndData.Format());

            buffer.Clear();
            var dShuffle = shuffler(4);
            var dShuffleData = dShuffle.CaptureNative(buffer);
            
            Trace("Shuffle:Delegate");
            Trace(dShuffleData.Format());

            buffer.Clear();
            var dShift = shifter(4);
            var dShiftData = dShift.CaptureNative(buffer);
            Trace("Shift:Delegate");
            Trace(dShiftData.Format());

            var mgAnds = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand");
            foreach(var mgAnd in mgAnds)
            {
                buffer.Clear();
                var mgAndData = mgAnd.CaptureNativeGeneric(typeof(uint), buffer);
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

        public void read_constants()
        {
            var method = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
            Span<byte> buffer = new byte[128];
            var data = NativeReader.read(method,buffer);

        }
    }
}