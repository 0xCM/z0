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
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly NativeBuffer Buffer;

        readonly BufferTokens Tokens;

        readonly ICaptureServiceProxy Service;

        [MethodImpl(Inline)]
        internal QuickCapture(IWfShell wf, IAsmContext context, NativeBuffer buffer, BufferTokens tokens, ICaptureServiceProxy capture)
        {
            Wf = wf;
            Asm = context;
            Tokens = tokens;
            Service = capture;
            Buffer =  buffer;
        }

        public Option<ApiCaptureBlock> Capture(MethodInfo src)
            => Service.Capture(src.Identify(), src);

        public Option<ApiMemberCapture> Capture(ApiMember src)
            => Service.Capture(src);

        public Option<ApiCaptureBlock> Capture(ApiHostUri host, MethodInfo src)
            => Service.Capture(src.Identify(),src);

        public Option<ApiCaptureBlock> Capture(OpIdentity id, MethodInfo src)
            => Service.Capture(id, src);

        public Option<ApiCaptureBlock> Capture(MethodInfo src, params Type[] args)
            => Service.Capture(src,args);

        public Option<ApiCaptureBlock> Capture(OpIdentity id, in DynamicDelegate src)
            => Service.Capture(id,src);

        public Option<ApiCaptureBlock> Capture(OpIdentity id, Delegate src)
            => Service.Capture(id,src);

        public Option<ApiParseResult> Capture(OpIdentity id, Span<byte> src)
            => Service.Capture(id,src);

        public Option<ApiCaptureBlock> Capture<D>(OpIdentity id, DynamicDelegate<D> src)
            where D : Delegate => Service.Capture(id, src);

        public ApiCaptureBlocks Capture(ReadOnlySpan<MethodInfo> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCaptureBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(src,i);
                var identified = method.Identify();
                var result = Capture(identified,method);
                if(result)
                    seek(dst,i) = result.Value;
                else
                    seek(dst,i) = ApiCaptureBlock.Empty;
            }
            return buffer;

        }

        Span<LocatedMethod> locate(ReadOnlySpan<IdentifiedMethod> src)
        {
            var count = src.Length;
            var buffer = alloc<LocatedMethod>(count);
            ref var located = ref first(span(buffer));
            for(var i=0u; i<count; i++)
                seek(located, i) = ApiJit.jit(skip(src, i));
            Array.Sort(buffer);
            return buffer;
        }

        [Op]
        public ApiCaptureBlocks CaptureHost(in ApiHostCatalog src)
        {
            var members = src.Members.View;
            var count = members.Length;
            var blocks = sys.alloc<ApiCaptureBlock>(count);
            ref var b = ref first(blocks);
            var buffer = sys.alloc<byte>(Pow2.T14);
            for(var i=0; i<count; i++)
            {
                ref readonly var member = ref skip(members, i);
                var address = member.BaseAddress;
                var id = member.Id;
                var captured = Service.Capture(member);
                if(captured)
                {
                    var data = captured.Value;
                    seek(b,i) = data.Code;
                }
            }
            return blocks;
        }

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}