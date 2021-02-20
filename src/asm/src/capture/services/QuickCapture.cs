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

    using api = Capture;

    public readonly struct QuickCapture : IDisposable, IApiHostCapture
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

        public ApiHostCaptureSet EmitCaptureSet(Type host)
        {
            var catalog = ApiCatalogs.HostCatalog(Wf, host);
            return api.set(Asm, catalog, CaptureHost(catalog));
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