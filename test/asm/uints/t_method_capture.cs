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

            using var dst = CaseWriter(FS.Extensions.Asm);
            foreach(var closure in closures)
            {
                foreach(var definition in defintions)
                {
                    var reified = definition.MakeGenericMethod(closure);
                    var id = reified.Identify();
                    var captured = AsmChecks.Capture(id, reified);
                    captured.OnSome(c => AsmChecks.WriteAsm(c, dst));
                }
            }
        }

        public void capture_quick()
        {
            using var dst = CaseWriter(FS.Extensions.Asm);
            using var quick = Wf.CaptureQuick();
            foreach(var m in typeof(cpu).DeclaredMethods().Public().Static().NonGeneric())
            {
                var code = quick.Capture(m);
                AsmChecks.WriteAsm(code,dst);
            }
        }

        public void capture_direct()
        {
            using var dst = CaseWriter(FS.Extensions.Asm);
            foreach(var m in typeof(DirectMethodCases).DeclaredMethods().Public().Static().NonGeneric())
                AsmChecks.Capture(m.Identify(), m).OnSome(capture => AsmChecks.WriteAsm(capture, dst));
        }

        void capture_dynamic_delegates()
        {
            using var dst = CaseWriter(FS.Extensions.Asm);
            using var quick = Wf.CaptureQuick();

            var xor = LD.xor<uint>();
            var gteq = LD.gteq<uint>();
            //var alt = Capture.alt(Wf);
            var m1 = new IdentifiedMethod(ApiIdentity.identify(xor.Method), xor.Method);
            var m2 = new IdentifiedMethod(ApiIdentity.identify(gteq.Method), gteq.Method);

            AsmChecks.WriteAsm(quick.Capture(m1), dst);
            AsmChecks.WriteAsm(quick.Capture(m2), dst);
        }

        void capture_dynamic_delegate_batch()
        {
            using var dst = CaseWriter(FS.Extensions.Asm);
            using var quick = Wf.CaptureQuick();

            var methods = root.array(
                LD.xor<byte>().Method, LD.xor<ushort>().Method, LD.xor<uint>().Method, LD.xor<ulong>().Method
                );

            foreach(var method in methods)
                AsmChecks.WriteAsm(quick.Capture(method), dst);

            // var identified = memory.alloc<IdentifiedMethod>(methods.Length);
            // for(var i=0; i<identified.Length; i++)
            //     identified[i] = new IdentifiedMethod(ApiIdentity.identify(methods[i]), methods[i]);
            // var buffer = sys.alloc<byte>(Pow2.T14);
            // var capture = quick.Capture(identified, buffer);
            // AsmCheck.WriteAsm(capture, dst);
        }

        public void capture_delegates()
        {
            using var dst = CaseWriter(FS.Extensions.Asm);

            var case1In = CaptureCases.And256;
            var case1Out = AsmChecks.Capture(case1In.Identify(), case1In).Require();
            AsmChecks.WriteAsm(case1Out, dst);

            var case2In = CaptureCases.And256;
            var case2Out = AsmChecks.Capture(case2In.Identify(), case1In).Require();
            AsmChecks.WriteAsm(case2Out, dst);

            var case3In = CaptureCases.shuffler(4);
            var case3Out = AsmChecks.Capture(case3In.Identify(), case3In).Require();
            AsmChecks.WriteAsm(case3Out, dst);

            var case4In = CaptureCases.shifter(7);
            var case4Out = AsmChecks.Capture(case4In.Identify(), case4In).Require();
            AsmChecks.WriteAsm(case4Out, dst);

            var case5In = CaptureCases.vand;
            root.iter(case5In,
                src => AsmChecks.WriteAsm(AsmChecks.Capture(src.Identify(), src).Require(), dst));
        }

        public void read_library()
        {
            var exchange = Capture.exchange();
            var src = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();
            for(var i=0; i<src.Length; i++)
            {
                var capture = AsmChecks.Capture(src[i].Identify(), src[i]);
            }
        }
    }
}