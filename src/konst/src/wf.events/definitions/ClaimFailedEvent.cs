//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event(EventName)]
    public readonly struct ClaimFailedEvent : IWfEvent<ClaimFailedEvent>
    {
        public const string EventName = GlobalEvents.CmdExec;

        public WfEventId EventId {get;}

        public ClaimKind Claim {get;}

        public string Description {get;}

        public CallingMember Origin {get;}

        public FlairKind Flair  => FlairKind.Error;

        [MethodImpl(Inline)]
        public ClaimFailedEvent(ClaimKind kind, string description, CallingMember origin, CorrelationToken ct)
        {
            EventId = (EventName, ct);
            Description = description;
            Claim = kind;
            Origin = origin;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId);
    }
}