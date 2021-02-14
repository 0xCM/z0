//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static ExtractTermCode;

    public unsafe readonly struct CaptureCore : ICaptureCore
    {
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        public CaptureCore(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public Option<ApiParseResult> ParseBuffer(in CaptureExchange exchange, OpIdentity id, Span<byte> src)
        {
            try
            {
                return capture(exchange, id, ref first(src));
            }
            catch(Exception e)
            {
                term.error(e);
                return root.none<ApiParseResult>();
            }
        }

        public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, in ApiMember src)
        {
            try
            {
                var summary = capture(exchange, src.Id, src.BaseAddress);
                var size = summary.DataFlow.Length;
                var code = new ApiCaptureBlock(src.Id, src.Method, summary.DataFlow.Input, summary.DataFlow.Output, summary.Outcome.TermCode);
                return new ApiMemberCapture(src, code);
            }
            catch(Exception e)
            {
                term.error(e);
                return root.none<ApiMemberCapture>();
            }
        }

        public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
        {
            try
            {
                var address = ApiJit.jit(src);
                var summary = capture(exchange, id, address);
                var outcome = summary.Outcome;
                var captured = DefineMember(id, src, summary.DataFlow, outcome.TermCode);
                Demands.insist(address, captured.BaseAddress);
                return captured;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<ApiCaptureBlock>();
            }
        }

        public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, in DynamicDelegate src)
        {
            try
            {
                var pSrc = ApiJit.jit(src).Handle;
                var summary = capture(exchange, id, pSrc);
                var outcome =  summary.Outcome;
                var captured = new ApiCaptureBlock(id, src.Source, summary.DataFlow.Input, summary.DataFlow.Output, outcome.TermCode);
                Demands.insist((MemoryAddress)pSrc,captured.BaseAddress);
                return captured;
            }
            catch(Exception e)
            {
                term.error($"Capture service failure");
                term.error(e);
                return none<ApiCaptureBlock>();
            }
        }

        public Option<ApiParseResult> Capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
        {
            try
            {
                return capture(exchange, id, src);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<ApiParseResult>();
            }
        }

        public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
        {
            try
            {
                var pSrc = ApiJit.jit(src);
                var summary = capture(exchange, id, pSrc);
                var outcome = summary.Outcome;
                var captured = DefineMember(id, src, summary.DataFlow, outcome.TermCode);
                return captured;
                //return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<ApiCaptureBlock>();
            }
        }

        public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
        {
            if(src.IsOpenGeneric())
            {
                var target = src.Reify(args);
                var id = MultiDiviner.Service.DivineIdentity(target);
                return Capture(exchange, id, target);
            }
            else
                return Capture(exchange, src.Identify(), src);
        }

        [MethodImpl(Inline)]
        static ApiCaptureBlock DefineMember(OpIdentity id, MethodInfo src, Z0.CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);

        [MethodImpl(Inline)]
        static ApiCaptureBlock DefineMember(OpIdentity id, Delegate src, Z0.CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src.Method, bits.Input, bits.Output, term);

        [MethodImpl(Inline)]
        static ApiParseResult capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
            => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        static ApiParseResult capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
            => capture(exchange, id, src.ToPointer<byte>());

        [MethodImpl(Inline)]
        static ApiParseResult capture(in CaptureExchange exchange, OpIdentity id, byte* pSrc)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(ExtractState);

            while(offset < limit)
            {
                state = Step(exchange, id, ref offset, ref end, ref pSrc);

                if(ret_offset == null && state.Captured == RET)
                    ret_offset = offset;

                var tc = CalcTerm(exchange, offset, ret_offset, out var delta);
                if(tc != null)
                    return SummarizeParse(exchange, id, tc.Value, start, end, delta);
            }
            return SummarizeParse(exchange, id, CTC_BUFFER_OUT, start, end, 0);
        }

        [MethodImpl(Inline)]
        static ExtractState Step(in CaptureExchange exchange, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            exchange[offset++] = code;
            location = (long)pSrc;
            return new ExtractState(code);
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(ExtractTermCode tc, long start, long end, int delta)
            => new CaptureOutcome(((ulong)start, (ulong)(end + delta)), tc);

        [MethodImpl(Inline)]
        static ApiParseResult SummarizeParse(in CaptureExchange exchange, OpIdentity id, ExtractTermCode tc, long start, long end, int delta)
        {
            var outcome = Complete(tc, start, end, delta);
            var raw = exchange.Target(0, (int)(end - start)).ToArray();
            var trimmed = exchange.Target(0, outcome.ByteCount).ToArray();
            var bits = new Z0.CapturedCodeBlock((MemoryAddress)start, raw, trimmed);
            return new ApiParseResult(id, outcome, bits);
        }

        static ExtractTermCode? CalcTerm(in CaptureExchange exchange, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = Scan4(exchange, offset, out delta);
                if(tc != null)
                    return tc;
            }

            if(offset >= 5)
            {
                var tc = Scan5(exchange, offset, out delta);
                if(tc != null)
                    return tc;
            }

            if(offset >= 7 && Zx7(exchange, offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_RET_Zx7;
            }

            return null;
        }

        const byte ZED = 0;

        const byte RET = 0xc3;

        const byte INTR = 0xcc;

        const byte SBB = 0x19;

        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        [MethodImpl(Inline)]
        static ExtractTermCode? Scan4(in CaptureExchange exchange, int offset, out int delta)
        {
            var x0 = exchange[offset - 3];
            var x1 = exchange[offset - 2];
            var x2 = exchange[offset - 1];
            var x3 = exchange[offset - 0];
            delta = -2;

            if(match((x0,RET), (x1, SBB)))
                return CTC_RET_SBB;
            else if(match((x0, RET), (x1, INTR)))
                return CTC_RET_INTR;
            else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                return CTC_RET_ZED_SBB;
            else if(match((x0, RET), (x1, ZED), (x2,ZED)))
                return CTC_RET_Zx3;
            else if(match((x0,INTR), (x1, INTR)))
                return CTC_INTRx2;
            else
                return null;
        }

        [MethodImpl(Inline)]
        static ExtractTermCode? Scan5(in CaptureExchange exchange, int offset, out int delta)
        {
            var x0 = exchange[offset - 5];
            var x1 = exchange[offset - 4];
            var x2 = exchange[offset - 3];
            var x3 = exchange[offset - 2];
            var x4 = exchange[offset - 1];
            delta = 0;

            if(match((x0,ZED), (x1,ZED), (x2,J48), (x3,FF), (x4,E0)))
                return CTC_JMP_RAX;
            else
                return null;
        }

        [MethodImpl(Inline)]
        static bool Zx7(in CaptureExchange exchange, int offset)
            =>      exchange[offset - 6] == ZED
                && (exchange[offset - 5] == ZED)
                && (exchange[offset - 4] == ZED)
                && (exchange[offset - 3] == ZED)
                && (exchange[offset - 2] == ZED)
                && (exchange[offset - 1] == ZED)
                && (exchange[offset - 0] == ZED);

        [MethodImpl(Inline)]
        static Bit32 match((byte x, byte y) a, (byte x, byte y) b)
            => a.x == a.y
            && b.x == b.y;

        [MethodImpl(Inline)]
        static Bit32 match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c)
            => a.x == a.y
            && b.x == b.y
            && c.x == c.y;

        [MethodImpl(Inline)]
        static Bit32 match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c, (byte x, byte y) d, (byte x, byte y) e)
            => a.x == a.y
            && b.x == b.y
            && c.x == c.y
            && d.x == d.y
            && e.x == e.y;
    }
}