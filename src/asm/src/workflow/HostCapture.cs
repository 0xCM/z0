//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;

    /// <summary>
    /// Aggregates artifacts obtained via host capture workflow execution
    /// </summary>
    public readonly struct HostCapture
    {
        public readonly ApiHostUri Host;

        public readonly MemberExtract[] Extracts;

        public readonly ParsedMember[] Parsed;
        
        public readonly AsmFunction[] Decoded;

        [MethodImpl(Inline)]
        public static HostCapture Define(ApiHostUri host, MemberExtract[] extracts, ParsedMember[] parsed, AsmFunction[] decoded)
            => new HostCapture(host, extracts, parsed, decoded);
        
        [MethodImpl(Inline)]
        HostCapture(ApiHostUri host, MemberExtract[] extracts, ParsedMember[] parsed, AsmFunction[] decoded)
        {
            this.Host = host;
            this.Extracts = extracts;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }
    }
}