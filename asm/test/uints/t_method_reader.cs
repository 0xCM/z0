//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    
    public sealed class t_native_reader : t_asm<t_native_reader>
    {
        protected override bool TraceEnabled => true;

        StreamWriter NativeTestWriter([Caller] string test = null)
        {
            var dstDir = Context.EmissionPaths().DataSubDir(FolderName.Define(typeof(t_native_reader).Name));            
            var dstPath = dstDir + FileName.Define($"{test}", FileExtensions.Hex);    
            return dstPath.Writer();
        }

        public void parse_address_segment()
        {
            for(var i=0; i<RepCount; i++)
            {
                var start = Random.Next(0ul, uint.MaxValue);
                var end = Random.Next((ulong)uint.MaxValue, ulong.MaxValue);
                var expect = MemoryRange.Define(start,end);
                var format = expect.Format();
                var actual = MemoryRange.Parse(format).OnNone(() => Notify(format)).Require();
                Claim.eq(expect,actual);
            }
        }

        public void capture_vectorized_generics()
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            using var writer = NativeTestWriter();

            var exchange = Context.ExtractExchange(OnCaptureEvent);
            var ops  = exchange.Operations;

            var types = NumericKind.All.DistinctTypes();
            var defintions = typeof(VectorizedCases).StaticMethods().OpenGeneric(1).Select(m => m.GetGenericMethodDefinition());
            foreach(var t in types)
            {
                foreach(var def in defintions)
                {
                    var m = def.MakeGenericMethod(t);
                    writer.WriteMember(ops.Capture(in exchange,m.Identify(), m));
                }
            }
        }

        public void capture_direct()
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }            
            var exchange = Context.ExtractExchange(OnCaptureEvent);
            var ops  = exchange.Operations;



            using var target = NativeTestWriter();
            foreach(var m in typeof(DirectMethodCases).DeclaredMethods().Public().Static().NonGeneric())
                target.WriteMember(ops.Capture(in exchange, m.Identify(), m));
        }

        static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v,imm);

        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        public void capture_delegates()
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var exchange = Context.ExtractExchange(OnCaptureEvent);
            var ops  = exchange.Operations;

            using var target = NativeTestWriter();

            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> dAnd = Avx2.And;
            target.WriteMember(ops.Capture(in exchange, dAnd.Identify(), dAnd));

            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            target.WriteMember(ops.Capture(in exchange, mAnd.Identify(), mAnd));

            var dShuffle = shuffler(4);
            target.WriteMember(ops.Capture(in exchange, dShuffle.Identify(), dShuffle));

            var dShift = shifter(4);
            target.WriteMember(ops.Capture(in exchange, dShift.Identify(), dShift));

            var methods = typeof(gvec).DeclaredStaticMethods().OpenGeneric().WithName("vand").Select(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(uint))).ToArray();
            
            foreach(var m in methods)
                target.WriteMember(ops.Capture(in exchange, m.Identify(), m));
            
        }

        public void read_library()
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var exchange = Context.ExtractExchange(OnCaptureEvent);
            var ops  = exchange.Operations;

            var src = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();

            for(var i=0; i<src.Length; i++)
            {
                var capture = ops.Capture(in exchange, src[i].Identify(), src[i]);
                //PostMessage(capture.FormatCode());
            }
        }
    }
}