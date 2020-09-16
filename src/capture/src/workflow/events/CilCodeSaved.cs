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

    public readonly struct CilCodeSaved : IWfEvent<CilCodeSaved>
    {
        public const string EventName = nameof(CilCodeSaved);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public readonly ApiHostUri Host;

        public readonly Count MemberCount;

        public readonly FS.FilePath Target;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CilCodeSaved(WfStepId step, ApiHostUri host, uint count, FS.FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
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