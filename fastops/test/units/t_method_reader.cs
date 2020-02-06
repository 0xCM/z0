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
    using System.Reflection;
    
    using static zfunc;
    using static NativeTestCases;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    
    public sealed class t_native_reader : t_fastops<t_native_reader>
    {
        protected override bool TraceEnabled => true;
        
        ICaptureWriter NativeTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, Paths.HexExt);    
            return  CaptureServices.Writer(path);
        }

        public void parse_address_segment()
        {
            for(var i=0; i<RepCount; i++)
            {
                var start = Random.Next(0ul, uint.MaxValue);
                var end = Random.Next((ulong)uint.MaxValue, ulong.MaxValue);
                var expect = MemoryRange.Define(start,end);
                var format = expect.Format();
                var actual = MemoryRange.Parse(format).OnNone(() => PostMessage(format)).Require();
                Claim.eq(expect,actual);
            }
        }

        public void capture_vectorized_generics()
        {
            using var writer = NativeTestWriter();
            var svc = CaptureServices.Capture();

            var types = NumericKind.All.DistinctTypes();
            var methods = typeof(VectorizedCases).StaticMethods().OpenGeneric(1).Select(m => m.GetGenericMethodDefinition());
            iter(types, 
                t => iter(methods, 
                    m => svc.Capture(m.MakeGenericMethod(t), writer)));
        }

        public void capture_direct()
        {
            using var target = NativeTestWriter();
            var svc = CaptureServices.Capture();
            foreach(var m in typeof(DirectMethodCases).DeclaredMethods().Public().Static().NonGeneric())
            {
                svc.Capture(m,target);
            }            
        }

        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        public void capture_delegates()
        {
            using var target = NativeTestWriter();
            var svc = CaptureServices.Capture();

            Span<byte> buffer = new byte[100];
            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            svc.Capture(dAnd,target);

            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            svc.Capture(mAnd,target);

            var dShuffle = shuffler(4);
            svc.Capture(dShuffle,target);

            var dShift = shifter(4);
            svc.Capture(dShift,target);


            iter(typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand").Select(m => m.GetGenericMethodDefinition()), 
                def => svc.Capture(def.MakeGenericMethod(typeof(uint)),target));
            
        }

        public void read_library()
        {
            var src = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            Span<byte> buffer = new byte[128];
            var svc = CaptureServices.Capture();

            for(var i=0; i<src.Length; i++)
            {
                var capture = svc.Capture(src[i].Identify(), src[i], buffer);
                PostMessage(capture.FormatHexLines());
                buffer.Clear();
            }
        }
    }
}