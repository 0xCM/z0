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
        
        public void parse_address_segment()
        {
            for(var i=0; i<RepCount; i++)
            {
                var start = Random.Next(0ul, uint.MaxValue);
                var end = Random.Next((ulong)uint.MaxValue, ulong.MaxValue);
                var expect = MemoryRange.Define(start,end);
                var format = expect.Format();
                var actual = MemoryRange.Parse(format).OnNone(() => Trace(format)).Require();
                Claim.eq(expect,actual);
            }

        }

        public void capture_generic_type()
        {
            using var writer = NativeTestWriter();
            var def = typedef(typeof(GenericTypeCases<>));
            var types = PrimalKind.Integers.PrimalTypes();
            foreach(var t in types)
            foreach(var captured in NativeReader.gtype(def,t))
                writer.WriteLine(captured.Format());
        }

        public void capture_vectorized_generics()
        {
            using var writer = NativeTestWriter();
            var types = PrimalKind.All.PrimalTypes();
            foreach(var t in types)
                typeof(VectorizedCases).CaptureNative(t,writer);                    
        }

        public void capture_direct()
        {
            using var writer = NativeTestWriter();
            typeof(DirectMethodCases).CaptureNative(writer);
        }

        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        public void capture_delegates()
        {
            using var dst = NativeTestWriter();

            Span<byte> buffer = new byte[100];
            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            dAnd.CaptureNative(dst);

            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            mAnd.CaptureNative(dst);

            var dShuffle = shuffler(4);
            dShuffle.CaptureNative(dst);

            var dShift = shifter(4);
            dShift.CaptureNative(dst);

            var mgAnds = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand");
            mgAnds.CaptureNative(typeof(uint),dst);

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