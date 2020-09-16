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

    public readonly struct X86UriHexSaved : IWfEvent<X86UriHexSaved>
    {
        public const string EventName = nameof(X86UriHexSaved);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly X86ApiCodeRow[] ApiHex;

        public readonly Count MemberCount;

        public readonly FS.FilePath Target;

        public FlairKind Flair {get;}


        [MethodImpl(Inline)]
        public X86UriHexSaved(WfStepId step, ApiHostUri host, X86ApiCodeRow[] code, FS.FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            MemberCount = code.Length;
            ApiHex = code;
            Target = dst;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount, Target);
    }
}