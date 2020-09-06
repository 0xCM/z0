//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    /// <summary>
    /// Aggregates artifacts from a host capture workflow
    /// </summary>
    public readonly struct CapturedHost
    {
        public readonly ApiHostUri Host;

        public readonly X86ApiExtract[] Extracts;

        public readonly X86MemberRefinement[] Parsed;

        public readonly AsmRoutine[] Decoded;

        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host, X86ApiExtract[] extracts, X86MemberRefinement[] parsed, AsmRoutine[] decoded)
        {
            Host = host;
            Extracts = extracts;
            Parsed = parsed;
            Decoded = decoded;
        }
    }
}