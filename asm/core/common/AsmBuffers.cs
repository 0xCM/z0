//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    /// <summary>
    /// Gathers a set of frequently-used buffers that is a by-convention asm service
    /// </summary>
    public readonly ref struct AsmBuffers
    {
        const int DefaultSize = 512;

        readonly Span<byte> CaptureTarget;

        readonly Span<byte> CaptureState;

        readonly ExecBuffer MBuffer;
        
        readonly ExecBuffer LBuffer;

        readonly ExecBuffer RBuffer;

        [MethodImpl(Inline)]
        public static AsmBuffers Create(IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
            => new AsmBuffers(context, observer, size);

        [MethodImpl(Inline)]
        AsmBuffers(IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            AsmContext = context;
            Exchange = context.CaptureExchange(observer, size);     
            Capture = Exchange.Operations;
            CaptureTarget = Exchange.TargetBuffer;
            CaptureState = Exchange.StateBuffer;
            MBuffer = buffers.alloc(size ?? DefaultSize);            
            LBuffer = buffers.alloc(size ?? DefaultSize);
            RBuffer = buffers.alloc(size ?? DefaultSize);            
        }

        public readonly IAsmContext AsmContext;

        public BufferToken MainExec
            => MBuffer;

        public BufferToken LeftExec
            => LBuffer;

        public BufferToken RightExec
            => RBuffer;

        public readonly IAsmOpExtractor Capture;

        public readonly AsmCaptureExchange Exchange;

        public void Dispose()
        {
            MBuffer.Dispose();
            LBuffer.Dispose();
            RBuffer.Dispose();
        }
    }
}