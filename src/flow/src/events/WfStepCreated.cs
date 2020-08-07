//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct WfStepCreated : IWfEvent<WfStepCreated>
    {
        public const string EventName = nameof(WfStepCreated);

        public WfEventId EventId {get;}
        
        public WfStepId StepId {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepCreated(WfStepId id, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            StepId = id;
            EventId = WfEventId.define(EventName, ct);
            Flair = flair;
        }
 
        public string Format()
            => text.format(PSx2, EventId, StepId);
    }
}