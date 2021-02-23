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
    using static memory;

    unsafe sealed class CaptureCore : AsmWfService<CaptureCore>, ICaptureCore
    {
        public Option<ApiParseResult> Capture(in CaptureExchange exchange, OpIdentity id, Span<byte> src)
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
                return root.none<ApiCaptureBlock>();
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
                return root.none<ApiCaptureBlock>();
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
                return root.none<ApiParseResult>();
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
            }
            catch(Exception e)
            {
                term.error(e);
                return root.none<ApiCaptureBlock>();
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
        static ApiCaptureBlock DefineMember(OpIdentity id, MethodInfo src, CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);

        [MethodImpl(Inline)]
        static ApiCaptureBlock DefineMember(OpIdentity id, Delegate src, CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src.Method, bits.Input, bits.Output, term);

        [MethodImpl(Inline)]
        static ApiParseResult capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
            => CaptureCalcs.capture(exchange.TargetBuffer, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        static ApiParseResult capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
            => CaptureCalcs.capture(exchange.TargetBuffer, id, src.ToPointer<byte>());
    }
}