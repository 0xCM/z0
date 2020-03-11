//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Root;
        

    /// <summary>
    /// Gathers a set of frequently-used buffers that is a by-convention asm service
    /// </summary>
    public readonly ref struct AsmBuffers
    {
        const int DefaultSize = 512;

        readonly Span<byte> CaptureTarget;

        readonly Span<byte> CaptureState;

        readonly BufferAllocation MBuffer;
        
        readonly BufferAllocation LBuffer;

        readonly BufferAllocation RBuffer;

        [MethodImpl(Inline)]
        public static AsmBuffers New(IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
            => new AsmBuffers(context, observer, size);

        [MethodImpl(Inline)]
        AsmBuffers(IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            AsmContext = context;
            Exchange = context.ExtractExchange(observer, size);     
            Capture = Exchange.Operations;
            CaptureTarget = Exchange.TargetBuffer;
            CaptureState = Exchange.StateBuffer;
            MBuffer = Buffers.alloc(size ?? DefaultSize);            
            LBuffer = Buffers.alloc(size ?? DefaultSize);
            RBuffer = Buffers.alloc(size ?? DefaultSize);            
        }

        public readonly IAsmContext AsmContext;

        public BufferToken MainExec
            => MBuffer;

        public BufferToken LeftExec
            => LBuffer;

        public BufferToken RightExec
            => RBuffer;

        public readonly ICaptureService Capture;

        public readonly OpExtractExchange Exchange;

        public void Dispose()
        {
            MBuffer.Dispose();
            LBuffer.Dispose();
            RBuffer.Dispose();
        }
    }
}