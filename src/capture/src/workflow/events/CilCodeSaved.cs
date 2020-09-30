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

    public readonly struct CilDataSaved : IWfEvent<CilDataSaved>
    {
        public const string EventName = nameof(CilDataSaved);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public readonly ApiHostUri Host;

        public readonly Count MemberCount;

        public FS.FileUri Target {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CilDataSaved(WfStepId step, ApiHostUri host, Count count, FS.FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Host = host;
            MemberCount = count;
            Target = dst;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount, Target);
    }
}