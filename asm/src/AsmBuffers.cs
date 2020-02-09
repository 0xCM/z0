//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public readonly ref struct AsmBuffers
    {
        const int DefaultSize = 512;

        public static AsmBuffers Create(IAsmContext context, ICaptureEventSink sink, int? size = null)
            => new AsmBuffers(context,sink,size);

        AsmBuffers(IAsmContext context, ICaptureEventSink sink, int? size = null)
        {
            AsmContext = context;
            CaptureTarget = new byte[size ?? DefaultSize];
            CaptureState = new byte[size ?? DefaultSize];
            Capture = CaptureServices.Control(sink);   
            Exchange = CaptureServices.Exchange(Capture, CaptureTarget, CaptureState);     
            MBuffer = OS.AllocExec(size ?? DefaultSize);            
            LBuffer = OS.AllocExec(size ?? DefaultSize);
            RBuffer = OS.AllocExec(size ?? DefaultSize);            
        }

        readonly Span<byte> CaptureTarget;

        readonly Span<byte> CaptureState;

        readonly ExecBuffer MBuffer;
        
        readonly ExecBuffer LBuffer;

        readonly ExecBuffer RBuffer;

        public readonly IAsmContext AsmContext;

        public ExecBufferToken MainExec
            => MBuffer;

        public ExecBufferToken LeftExec
            => LBuffer;

        public ExecBufferToken RightExec
            => RBuffer;

        public readonly ICaptureControl Capture;

        public readonly CaptureExchange Exchange;

        public void Dispose()
        {
            MBuffer.Dispose();
            LBuffer.Dispose();
            RBuffer.Dispose();
        }
    }

    public static class BufferX
    {    
        public static AsmBuffers Buffers(this IAsmContext context, ICaptureEventSink sink, int? size = null)
            => AsmBuffers.Create(context,sink,size);
    }
}