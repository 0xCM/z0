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

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}