//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using Z0.Asm;

    public readonly struct QuickCapture : IDisposable
    {
        readonly IWfRuntime Wf;

        readonly NativeBuffer Buffer;

        readonly BufferTokens Tokens;

        readonly ICaptureServiceProxy Service;

        [MethodImpl(Inline)]
        internal QuickCapture(IWfRuntime wf, NativeBuffer buffer, BufferTokens tokens, ICaptureServiceProxy capture)
        {
            Wf = wf;
            Tokens = tokens;
            Service = capture;
            Buffer =  buffer;
        }

        public ApiCaptureBlock Capture(MethodInfo src)
            => Service.Capture(src.Identify(), src).ValueOrDefault(ApiCaptureBlock.Empty);

        // public ApiCaptureBlock Capture(OpIdentity id, MethodInfo src)
        //     => Service.Capture(id, src).Require();

        // [Op]
        // public ApiCaptureBlocks CaptureHost(in ApiHostCatalog src)
        // {
        //     var members = src.Members.View;
        //     var count = members.Length;
        //     var blocks = sys.alloc<ApiCaptureBlock>(count);
        //     ref var b = ref first(blocks);
        //     var buffer = sys.alloc<byte>(Pow2.T14);
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var member = ref skip(members, i);
        //         var address = member.BaseAddress;
        //         var id = member.Id;
        //         var captured = Service.Capture(member);
        //         if(captured)
        //         {
        //             var data = captured.Value;
        //             seek(b,i) = data.Code;
        //         }
        //     }
        //     return blocks;
        // }

        // public ApiCaptureBlocks Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
        // {
        //     var located = locate(src);
        //     var count = located.Length;
        //     var captured = alloc<ApiCaptureBlock>(count);
        //     ref var dst = ref first(captured);
        //     for(var i=0u; i<count; i++)
        //     {
        //         buffer.Clear();
        //         ref readonly var method = ref skip(located, i);
        //         try
        //         {
        //             var summary = capture(buffer, method.Id, method.Address);
        //             var outcome = summary.Outcome;
        //             seek(dst, i) = block(method.Id, method.Method, summary.Encoded, outcome.TermCode);
        //         }
        //         catch(Exception e)
        //         {
        //             term.errlabel(e, method.Method.Name);
        //         }
        //     }
        //     return captured;
        // }

        // static Span<LocatedMethod> locate(ReadOnlySpan<IdentifiedMethod> src)
        // {
        //     var count = src.Length;
        //     var buffer = alloc<LocatedMethod>(count);
        //     ref var located = ref first(span(buffer));
        //     for(var i=0u; i<count; i++)
        //         seek(located, i) = ApiJit.jit(skip(src, i));
        //     Array.Sort(buffer);
        //     return buffer;
        // }

        // ApiMemberCapture Capture(ApiMember src)
        //     => Service.Capture(src).Require();

        // ApiCaptureBlock Capture(ApiHostUri host, MethodInfo src)
        //     => Service.Capture(src.Identify(),src).Require();

        // Option<ApiCaptureBlock> Capture(MethodInfo src, params Type[] args)
        //     => Service.Capture(src,args);

        // Option<ApiCaptureBlock> Capture(OpIdentity id, in DynamicDelegate src)
        //     => Service.Capture(id,src);

        // Option<ApiCaptureBlock> Capture(OpIdentity id, Delegate src)
        //     => Service.Capture(id,src);

        // Option<ApiParseResult> Capture(OpIdentity id, Span<byte> src)
        //     => Service.Capture(id,src);

        // [Op]
        // static ApiMemberCapture capture(in ApiMember src, Span<byte> buffer)
        // {
        //     var summary = capture(buffer, src.Id, ApiJit.jit(src));
        //     var size = summary.Data.Length;
        //     var code = new ApiCaptureBlock(src.Id, src.Method, summary.Encoded.Input, summary.Encoded.Output, summary.Outcome.TermCode);
        //     return new ApiMemberCapture(src, code);
        // }

        // [Op]
        // static unsafe CapturedOperation capture(Span<byte> dst, OpIdentity id, MemoryAddress src)
        // {
        //     var result = ApiCaptureDiviner.divine(dst, id, src.Pointer<byte>());
        //     return new CapturedOperation(id, result.Outcome, result.Code);
        // }

        // [MethodImpl(Inline), Op]
        // static ApiCaptureBlock block(OpIdentity id, MethodInfo src, CapturedCodeBlock bits, ExtractTermCode term)
        //     => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);

        // Option<ApiCaptureBlock> Capture<D>(OpIdentity id, DynamicDelegate<D> src)
        //     where D : Delegate => Service.Capture(id, src);

        // ReadOnlySpan<AsmRoutineCode> Capture(ReadOnlySpan<MethodInfo> src, FS.FilePath dst)
        //     => Wf.ApiDecoder().Decode(Capture(src), dst);

        // ApiCaptureBlocks Capture(ReadOnlySpan<MethodInfo> src)
        // {
        //     var count = src.Length;
        //     var buffer = alloc<ApiCaptureBlock>(count);
        //     ref var dst = ref first(buffer);
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var method = ref skip(src,i);
        //         var identified = method.Identify();
        //         seek(dst,i) = Capture(identified,method);
        //     }
        //     return buffer;
        // }

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}