//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    public readonly struct AsmHostExtract
    {
        [MethodImpl(Inline)]
        public static AsmHostExtract Define(ApiHostUri host, AsmOpExtractReport captured, AsmParseReport parsed, AsmFunctionList decoded)
            => new AsmHostExtract(host, captured, parsed, decoded);

        [MethodImpl(Inline)]
        public static implicit operator AsmHostExtract((ApiHostUri host, AsmOpExtractReport captured, AsmParseReport parsed, AsmFunctionList decoded) src)
            => Define(src.host, src.captured, src.parsed, src.decoded);
        
        [MethodImpl(Inline)]
        AsmHostExtract(ApiHostUri host, AsmOpExtractReport captured, AsmParseReport parsed, AsmFunctionList decoded)
        {
            this.Host = host;
            this.Captured = captured;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

        public readonly ApiHostUri Host;

        public readonly AsmOpExtractReport Captured;

        public readonly AsmParseReport Parsed;
        
        public readonly AsmFunctionList Decoded;
    }
}