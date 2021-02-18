//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using LD = LinqDynamic;

    public sealed class t_method_capture : t_asm<t_method_capture>
    {
        public override bool Enabled => true;

        public void parse_address_segment()
        {
            var parser = MemoryRange.parser();
            for(var i=0; i<RepCount; i++)
            {
                var start = Random.Next(0ul, uint.MaxValue);
                var end = Random.Next((ulong)uint.MaxValue, ulong.MaxValue);
                var expect = new MemoryRange(start,end);
                var format = expect.Format();
                var actual = parser.Parse(format).Value;
                Claim.eq(expect,actual);
            }
        }

        public void capture_gvec()
        {
            var closures = NumericKind.UnsignedInts.DistinctTypes();
            var defintions = typeof(VectorizedCases).StaticMethods().OpenGeneric(1).Select(m => m.GetGenericMethodDefinition());

            using var dst = CaseWriter(FileExtensions.Asm);
            foreach(var closure in closures)
            {
                foreach(var definition in defintions)
                {
                    var reified = definition.MakeGenericMethod(closure);
                    var id = reified.Identify();
                    var captured = AsmCheck.Capture(id, reified);
                    captured.OnSome(c => AsmCheck.WriteAsm(c, dst));
                }
            }
        }

        public void capture_quick()
        {
            using var dst = CaseWriter(FileExtensions.Asm);
            using var quick = AsmServices.CaptureQuick(Wf, Context);
            foreach(var m in typeof(z).DeclaredMethods().Public().Static().NonGeneric())
            {
                var code = quick.Capture(m);
                code.OnSome(c => AsmCheck.WriteAsm(c,dst));
            }
        }

        public void capture_direct()
        {
            using var dst = CaseWriter(FileExtensions.Asm);
            foreach(var m in typeof(DirectMethodCases).DeclaredMethods().Public().Static().NonGeneric())
                AsmCheck.Capture(m.Identify(), m).OnSome(capture => AsmCheck.WriteAsm(capture, dst));
        }

        void capture_dynamic_delegates()
        {
            using var dst = CaseWriter(FileExtensions.Asm);
            var xor = LD.xor<uint>();
            var alt = Capture.alt(Wf, Context);
            AsmCheck.WriteAsm(alt.Capture(new IdentifiedMethod(Identity.identify(xor.Method), xor.Method)), dst);
            var gteq = LD.gteq<uint>();
            AsmCheck.WriteAsm(alt.Capture(new IdentifiedMethod(Identity.identify(xor.Method), xor.Method)), dst);
        }

        void capture_dynamic_delegate_batch()
        {
            using var dst = CaseWriter(FileExtensions.Asm);
            var methods = z.array(
                LD.xor<byte>().Method, LD.xor<ushort>().Method, LD.xor<uint>().Method, LD.xor<ulong>().Method
                );
            var identified = z.alloc<IdentifiedMethod>(methods.Length);
            for(var i=0; i<identified.Length; i++)
                identified[i] = new IdentifiedMethod(Identity.identify(methods[i]), methods[i]);
            var buffer = sys.alloc<byte>(Pow2.T14);
            var alt = Capture.alt(Wf, Context);
            var capture = alt.Capture(identified, buffer);
            AsmCheck.WriteAsm(capture, dst);
        }

        public void capture_delegates()
        {
            using var dst = CaseWriter(FileExtensions.Asm);

            var case1In = CaptureCases.And256;
            var case1Out = AsmCheck.Capture(case1In.Identify(), case1In).Require();
            AsmCheck.WriteAsm(case1Out, dst);

            var case2In = CaptureCases.And256;
            var case2Out = AsmCheck.Capture(case2In.Identify(), case1In).Require();
            AsmCheck.WriteAsm(case2Out, dst);

            var case3In = CaptureCases.shuffler(4);
            var case3Out = AsmCheck.Capture(case3In.Identify(), case3In).Require();
            AsmCheck.WriteAsm(case3Out, dst);

            var case4In = CaptureCases.shifter(7);
            var case4Out = AsmCheck.Capture(case4In.Identify(), case4In).Require();
            AsmCheck.WriteAsm(case4Out, dst);

            var case5In = CaptureCases.vand;
            root.iter(case5In,
                src => AsmCheck.WriteAsm(AsmCheck.Capture(src.Identify(), src).Require(), dst));
        }

        public void read_library()
        {
            var exchange = Capture.exchange(Context);
            var src = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            for(var i=0; i<src.Length; i++)
            {
                var capture = AsmCheck.Capture(src[i].Identify(), src[i]);
            }
        }
    }
}