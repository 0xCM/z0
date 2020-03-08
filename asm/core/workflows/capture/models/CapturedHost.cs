//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmWorkflowReports;

    public readonly struct CapturedHost
    {
        [MethodImpl(Inline)]
        public static CapturedHost Define(ApiHostUri host, MemberExtractReport captured, MemberParseReport parsed, AsmFunctionList decoded)
            => new CapturedHost(host, captured, parsed, decoded);
        
        [MethodImpl(Inline)]
        CapturedHost(ApiHostUri host, MemberExtractReport captured, MemberParseReport parsed, AsmFunctionList decoded)
        {
            this.Host = host;
            this.Captured = captured;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

        public readonly ApiHostUri Host;

        public readonly MemberExtractReport Captured;

        public readonly MemberParseReport Parsed;
        
        public readonly AsmFunctionList Decoded;
    }
}