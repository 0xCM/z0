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
        public static AsmHostExtract Define(ApiHostPath host, ExtractionReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded)
            => new AsmHostExtract(host, captured, parsed, decoded);

        [MethodImpl(Inline)]
        public static implicit operator AsmHostExtract((ApiHostPath host, ExtractionReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded) src)
            => Define(src.host, src.captured, src.parsed, src.decoded);
        
        [MethodImpl(Inline)]
        AsmHostExtract(ApiHostPath host, ExtractionReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded)
        {
            this.Host = host;
            this.Captured = captured;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

        public readonly ApiHostPath Host;

        public readonly ExtractionReport Captured;

        public readonly ParsedEncodingReport Parsed;
        
        public readonly AsmFunctionList Decoded;
    }
}