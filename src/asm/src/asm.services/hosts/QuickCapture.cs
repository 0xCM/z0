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

    using Z0.Asm;

    public readonly struct QuickCapture : IDisposable
    {
        readonly IAsmContext Context;

        readonly NativeBuffer Buffer;

        readonly BufferTokens Tokens;

        readonly ICaptureServiceProxy Service;

        [MethodImpl(Inline)]
        internal QuickCapture(IAsmContext context, NativeBuffer buffer, BufferTokens tokens, ICaptureServiceProxy capture)
        {
            Context = context;
            Tokens = tokens;
            Service = capture;
            Buffer =  buffer;
        }

        [MethodImpl(Inline)]
        public Option<ApiCaptureBlock> Capture(MethodInfo src)
            => Service.Capture(z.insist(src).Identify(), src);

        [MethodImpl(Inline)]
        public Option<ApiMemberCapture> Capture(ApiMember src)
            => Service.Capture(src);

        [MethodImpl(Inline)]
        public Option<ApiCaptureBlock> Capture(ApiHostUri hos, MethodInfo src)
            => Service.Capture(z.insist(src).Identify(),src);

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}