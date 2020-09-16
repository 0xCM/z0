//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct MembersLocated : IWfEvent<MembersLocated>
    {
        public const string EventName = nameof(MembersLocated);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public ApiMember[] Members {get;}

        public Count MemberCount => Members.Length;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public MembersLocated(ApiHostUri host, ApiMember[] functions, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName,ct);
            Host = host;
            Members = functions;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount);
    }
}