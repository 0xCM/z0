//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe sealed class CaptureCore : AppService<CaptureCore>, ICaptureCore
    {
        // public Option<ApiCaptureResult> Capture(in CaptureExchange exchange, OpIdentity id, Span<byte> src)
        // {
        //     try
        //     {
        //         return capture(exchange, id, ref first(src));
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e);
        //         return root.none<ApiCaptureResult>();
        //     }
        // }

        // public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, in ApiMember src)
        // {
        //     try
        //     {
        //         var summary = capture(exchange, src.Id, src.BaseAddress);
        //         var size = summary.Pair.Length;
        //         var code = CodeBlocks.capture(src.Id, src.Method, summary.Pair.Raw, summary.Pair.Parsed, summary.TermCode);
        //         return new ApiMemberCapture(src, code);
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e);
        //         return root.none<ApiMemberCapture>();
        //     }
        // }

        // public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
        // {
        //     try
        //     {
        //         var address = ApiJit.jit(src);
        //         var summary = capture(exchange, id, address);
        //         return DefineMember(id, src, summary.Pair, summary.TermCode);
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e);
        //         return root.none<ApiCaptureBlock>();
        //     }
        // }

        public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, in DynamicDelegate src)
        {
            try
            {
                var pSrc = ApiJit.jit(src).Address;
                var summary = capture(exchange, id, pSrc);
                return CodeBlocks.capture(id, src.Source, summary.Pair.Raw, summary.Pair.Parsed, summary.TermCode);
            }
            catch(Exception e)
            {
                term.error($"Capture service failure");
                term.error(e);
                return root.none<ApiCaptureBlock>();
            }
        }

        // public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
        // {
        //     try
        //     {
        //         var address = ApiJit.jit(src);
        //         var summary = capture(exchange, id, address);
        //         return DefineMember(id, src, summary.Pair, summary.TermCode);
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e);
        //         return root.none<ApiCaptureBlock>();
        //     }
        // }

        // public Option<ApiCaptureBlock> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
        // {
        //     if(src.IsOpenGeneric())
        //     {
        //         var target = src.Reify(args);
        //         var id = MultiDiviner.Service.DivineIdentity(target);
        //         return Capture(exchange, id, target);
        //     }
        //     else
        //         return Capture(exchange, src.Identify(), src);
        // }

        // [MethodImpl(Inline)]
        // static ApiCaptureBlock DefineMember(OpIdentity id, MethodInfo src, CodeBlockPair bits, ExtractTermCode term)
        //     => CodeBlocks.capture(id, src, bits.Raw, bits.Parsed, term);

        // [MethodImpl(Inline)]
        // static ApiCaptureBlock DefineMember(OpIdentity id, Delegate src, CodeBlockPair bits, ExtractTermCode term)
        //     => CodeBlocks.capture(id, src.Method, bits.Raw, bits.Parsed, term);

        // [MethodImpl(Inline)]
        // static ApiCaptureResult capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
        //     => ApiExtracts.divine(exchange.Buffer, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        static ApiCaptureResult capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
            => ApiExtracts.divine(exchange.Buffer, id, src.ToPointer<byte>());
    }
}