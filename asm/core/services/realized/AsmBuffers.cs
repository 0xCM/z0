//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
        
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
        public static AsmBuffers New(IContext context, AsmCaptureEventObserver observer, int? size = null)
            => new AsmBuffers(context, observer, size);

        [MethodImpl(Inline)]
        AsmBuffers(IContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            Exchange = context.ExtractExchange(observer, size);     
            Capture = Exchange.Operations;
            CaptureTarget = Exchange.TargetBuffer;
            CaptureState = Exchange.StateBuffer;
            MBuffer = Buffers.native(size ?? DefaultSize);            
            LBuffer = Buffers.native(size ?? DefaultSize);
            RBuffer = Buffers.native(size ?? DefaultSize);            
        }


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