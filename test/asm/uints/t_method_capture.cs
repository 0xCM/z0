//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.IO;
        

    public sealed class t_method_catpure : t_asm<t_method_catpure>
    {
        public void parse_address_segment()
        {
            var parser = HexParsers.MemoryRange;
            for(var i=0; i<RepCount; i++)
            {
                var start = Random.Next(0ul, uint.MaxValue);
                var end = Random.Next((ulong)uint.MaxValue, ulong.MaxValue);
                var expect = MemoryRange.Define(start,end);
                var format = expect.Format();
                var actual = parser.Parse(format).Value;
                Claim.eq(expect,actual);
            }
        }

        public void capture_gvec()
        {
            var exchange = Context.CaptureExchange();
            var service  = exchange.Service;

            var closures = NumericKind.UnsignedInts.DistinctTypes();
            var defintions = typeof(VectorizedCases).StaticMethods().OpenGeneric(1).Select(m => m.GetGenericMethodDefinition());

            using var dst = CaseFileWriter(FileExtensions.Asm);
            foreach(var closure in closures)
            {
                foreach(var definition in defintions)
                {
                    var reified = definition.MakeGenericMethod(closure);
                    var id = reified.Identify();
                    var captured = service.Capture(exchange, id, reified);
                    captured.OnSome(c => WriteAsm(c, dst));
                }
            }
        }

        public void capture_direct()
        {
            var exchange = Context.CaptureExchange();
            var service  = exchange.Service;

            using var dst = CaseFileWriter(FileExtensions.Asm);
            foreach(var m in typeof(DirectMethodCases).DeclaredMethods().Public().Static().NonGeneric())
                service.Capture(in exchange, m.Identify(), m).OnSome(capture => WriteAsm(capture, dst));                
        }

        public void capture_delegates()
        {
            using var dst = CaseFileWriter(FileExtensions.Asm);

            var case1In = CaptureCases.And256;
            var case1Out = AsmCheck.Capture(case1In.Identify(), case1In).Require();
            WriteAsm(case1Out, dst);

            var case2In = CaptureCases.And256;
            var case2Out = AsmCheck.Capture(case2In.Identify(), case1In).Require();
            WriteAsm(case2Out, dst);

            var case3In = CaptureCases.shuffler(4);
            var case3Out = AsmCheck.Capture(case3In.Identify(), case3In).Require();
            WriteAsm(case3Out, dst);

            var case4In = CaptureCases.shifter(7);
            var case4Out = AsmCheck.Capture(case4In.Identify(), case4In).Require();
            WriteAsm(case4Out, dst);

            var case5In = CaptureCases.vand;
            Control.iter(case5In, 
                src => WriteAsm(AsmCheck.Capture(src.Identify(), src).Require(), dst));
        }

        public void read_library()
        {
            var exchange = Context.CaptureExchange();
            var ops  = exchange.Service;

            var src = typeof(math).StaticMethods().Where(m => m.Name == "xor").ToArray();

            for(var i=0; i<src.Length; i++)
            {
                var capture = ops.Capture(exchange, src[i].Identify(), src[i]);
            }
        }
    }
}