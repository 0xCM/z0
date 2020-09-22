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

    public readonly struct MembersExtracted : IWfEvent<MembersExtracted>
    {
        public const string EventName = nameof(MembersExtracted);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly ApiMemberExtract[] Members;

        public readonly Count MemberCount;

        public readonly FS.FilePath Target;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public MembersExtracted(WfStepId step, ApiHostUri host, ApiMemberExtract[] members, FS.FilePath dst,  CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            Target = dst;
            Members = members;
            MemberCount = Members.Length;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount, Target.ToUri());
    }
}