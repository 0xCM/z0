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

    public readonly struct CaptureController
    {
        public const string ActorName = nameof(CaptureControl);        

        public static WfActor Actor => Flow.actor(ActorName);
        
        static WfState state(IAppContext context, WfConfig config, CorrelationToken ct)
        {           
            var Paths = context.AppPaths;
            var Asm = WfBuilder.asm(context);                           
            var WfContext = Flow.context(context, config, ct);                        
            return new WfState(WfContext, Asm, config, ct);
        }

        [MethodImpl(Inline)]
        public static CaptureControl create(IAppContext root, WfConfig config, CorrelationToken ct)
            => new CaptureControl(state(root, config, ct));

        [MethodImpl(Inline)]
        public static CaptureControl create(WfState state)
            => new CaptureControl(state);

        // [MethodImpl(Inline)]
        // public static CaptureControl create(IAppContext root, string[] args, CorrelationToken ct)
        //     => CaptureController.create(root, Flow.configure(root, args, ct), ct);
    }
}