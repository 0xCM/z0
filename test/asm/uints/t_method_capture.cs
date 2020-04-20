//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
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
            Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
                => v => Avx2.Shuffle(v,imm);

            Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
                => v => Avx2.ShiftLeftLogical(v,imm);

            var exchange = Context.CaptureExchange();            
            var service = exchange.Service;
            using var dst = CaseFileWriter(FileExtensions.Asm);
            
            void CaptureFromMethod(in CaptureExchange xchange)
            {
                var name = nameof(Avx2.And);
                var src = typeof(Avx2).GetMethod(name, new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });

                service.Capture(xchange, src.Identify(), src)
                    .OnSome(capture => WriteAsm(capture, dst))
                    .OnNone(() => error($"{name} method capture failed"));
            }

            void CaptureFromDelegate(in CaptureExchange xchange)
            {
                var name = nameof(Avx2.And);
                Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> src = Avx2.And;

                service.Capture(xchange, src.Identify(), src)
                    .OnSome(capture => WriteAsm(capture, dst))
                    .OnNone(() => error($"{name} delegate capture failed"));
            }

            void CaptureShuffler(in CaptureExchange xchange)
            {
                var dShuffle = shuffler(4);
                service.Capture(xchange, dShuffle.Identify(), dShuffle)
                    .OnSome(capture => WriteAsm(capture, dst))
                    .OnNone(() => error($"{dShuffle.Method.Name} capture failed"));                        
            }

            void CaptureShifter(in CaptureExchange xchange)
            {
                var dShift = shifter(4);
                service.Capture(xchange, dShift.Identify(), dShift)
                    .OnSome(capture => WriteAsm(capture, dst))
                    .OnNone(() => error($"{dShift.Method.Name} capture failed"));
            }

            void CaptureGeneric(in CaptureExchange xchange)
            {
                var methods = typeof(gvec).DeclaredStaticMethods()
                            .OpenGeneric()
                            .WithName("vand")
                            .Select(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(uint)))
                            .ToArray();            
                
                foreach(var src in methods)
                    service.Capture(xchange, src.Identify(), src)
                        .OnSome(capture => WriteAsm(capture, dst))
                        .OnNone(() => error($"{src.Name} capture failed"));
            }

            CaptureFromMethod(exchange);
            CaptureFromDelegate(exchange);
            CaptureShuffler(exchange);
            CaptureShifter(exchange);
            CaptureGeneric(exchange);
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