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

    readonly struct AsmCaptureService : ICaptureService
    {
        public IAsmContext Context {get;}

        readonly ICaptureOps Ops;

        public static ICaptureService Create(IAsmContext context, ICaptureOps control)
            => new AsmCaptureService(context, control);

        AsmCaptureService(IAsmContext context, ICaptureOps control)
        {
            Context = context;
            Ops = control;            
        }

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => Ops.Capture(exchange,src,args);

        public CapturedMember[] Capture(in CaptureExchange exchange, MethodInfo[] methods)
            => Ops.Capture(exchange,methods);
    }
}