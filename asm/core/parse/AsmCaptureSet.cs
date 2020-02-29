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

    public readonly struct AsmCaptureSet
    {
        public static AsmCaptureSet Define(ApiHostPath host, CapturedEncodingReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded)
            => new AsmCaptureSet(host, captured, parsed, decoded);

        public static implicit operator AsmCaptureSet((ApiHostPath host, CapturedEncodingReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded) src)
            => Define(src.host, src.captured, src.parsed, src.decoded);
        
        AsmCaptureSet(ApiHostPath host, CapturedEncodingReport captured, ParsedEncodingReport parsed, AsmFunctionList decoded)
        {
            this.Host = host;
            this.Captured = captured;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

        public readonly ApiHostPath Host;

        public readonly CapturedEncodingReport Captured;

        public readonly ParsedEncodingReport Parsed;
        
        public readonly AsmFunctionList Decoded;
    }
}