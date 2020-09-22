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

    public readonly struct ApiHexTableSaved : IWfEvent<ApiHexTableSaved>
    {
        public const string EventName = nameof(ApiHexTableSaved);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly ApiHexRow[] Rows;

        public readonly Count MemberCount;

        public readonly FS.FilePath Target;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ApiHexTableSaved(WfStepId step, ApiHostUri host, ApiHexRow[] code, FS.FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            MemberCount = code.Length;
            Rows = code;
            Target = dst;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount, Target.ToUri());
    }
}