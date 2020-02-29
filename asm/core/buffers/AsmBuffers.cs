//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
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

        public static AsmBuffers Create(IAsmContext context, CaptureEventObserver observer, int? size = null)
            => new AsmBuffers(context, observer, size);

        AsmBuffers(IAsmContext context, CaptureEventObserver observer, int? size = null)
        {
            AsmContext = context;
            Exchange = CaptureServices.Exchange(observer, size);     
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

        public readonly ICaptureOps Capture;

        public readonly CaptureExchange Exchange;

        public void Dispose()
        {
            MBuffer.Dispose();
            LBuffer.Dispose();
            RBuffer.Dispose();
        }
    }
}