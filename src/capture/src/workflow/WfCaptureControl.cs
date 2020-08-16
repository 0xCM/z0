//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Asm;

    using static Konst;

    public readonly struct WfCaptureControl
    {
        public const string ActorName = nameof(CaptureControl);        

        public static WfActor Actor => Flow.actor(ActorName);
        
        static WfCaptureState state(IAppContext context, WfConfig config, CorrelationToken ct)
        {           
            var Paths = context.AppPaths;
            var Asm = WfBuilder.asm(context);                           
            var WfContext = Flow.context(context, config, ct);                        
            return new WfCaptureState(WfContext, Asm, config, ct);
        }

        [MethodImpl(Inline)]
        public static CaptureControl create(IAppContext root, WfConfig config, CorrelationToken ct)
            => new CaptureControl(state(root, config, ct));

        [MethodImpl(Inline)]
        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state);
    }
}