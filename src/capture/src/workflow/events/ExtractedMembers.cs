//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    [Event]
    public readonly struct ExtractedMembers : IWfEvent<ExtractedMembers>
    {
        public const string EventName = nameof(ExtractedMembers);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly Count MemberCount;

        [MethodImpl(Inline)]
        public ExtractedMembers(ApiHostUri host, Count count, CorrelationToken ct)
        {
            EventId = (EventName, ct);
            Host = host;
            MemberCount = count;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, MemberCount, Host.Format());

        public ExtractedMembers Zero
            => Empty;

        public static ExtractedMembers Empty
            => default;
    }
}