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

    public readonly struct ApiHexSaved : IWfEvent<ApiHexSaved>
    {
        public const string EventName = nameof(ApiHexSaved);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly X86UriHex[] ApiHex;

        public readonly Count32 MemberCount;

        public readonly FS.FilePath Target;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ApiHexSaved(WfStepId step, ApiHostUri host, X86UriHex[] code, FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            MemberCount = code.Length;
            ApiHex = code;
            Target = FS.path(dst.Name);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public ApiHexSaved(WfStepId step, ApiHostUri host, X86UriHex[] code, FS.FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
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