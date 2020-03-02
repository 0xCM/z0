//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    
    readonly struct AsmCaptureService : IAsmCaptureService
    {
        public IAsmContext Context {get;}

        readonly IAsmCaptureOps Ops;

        [MethodImpl(Inline)]
        public static IAsmCaptureService Create(IAsmContext context, IAsmCaptureOps control)
            => new AsmCaptureService(context, control);

        [MethodImpl(Inline)]
        AsmCaptureService(IAsmContext context, IAsmCaptureOps control)
        {
            Context = context;
            Ops = control;            
        }

        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => Ops.Capture(in exchange, id, src);

        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Ops.Capture(in exchange, id, src);

        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, OpIdentity id, Delegate src)
            => Ops.Capture(in exchange, id, src);

        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, MethodInfo src, params Type[] args)
            => Ops.Capture(exchange,src,args);

        public AsmMemberCapture[] Capture(in AsmCaptureExchange exchange, MethodInfo[] methods)
            => Ops.Capture(exchange,methods);
    }
}