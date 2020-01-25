//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static NativeTestCases;

    public sealed class t_native_reader : t_fastop<t_native_reader>
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

        public void capture_vectorized_generics()
        {
            using var writer = NativeTestWriter();
            var types = PrimalKind.All.PrimalTypes();
            foreach(var t in types)
                NativeCapture.capture(typeof(VectorizedCases),t, writer);
        }

        public void capture_direct()
        {
            using var target = NativeTestWriter();
            NativeCapture.capture(typeof(DirectMethodCases), target);
        }

        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        public void capture_delegates()
        {
            using var target = NativeTestWriter();

            Span<byte> buffer = new byte[100];
            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            NativeCapture.capture(dAnd,target);

            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            NativeCapture.capture(mAnd,target);

            var dShuffle = shuffler(4);
            NativeCapture.capture(dShuffle,target);

            var dShift = shifter(4);
            NativeCapture.capture(dShift,target);

            var mgAnds = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand");
            NativeCapture.capture(mgAnds, typeof(uint),target);
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