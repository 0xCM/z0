//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Aggregates artifacts obtained via host capture workflow execution
    /// </summary>
    public readonly struct ApiHostCapture
    {
        [MethodImpl(Inline)]
        public static ApiHostCapture Define(ApiHostUri host, MemberExtractReport captured, MemberParseReport parsed, AsmFunctionList decoded)
            => new ApiHostCapture(host, captured, parsed, decoded);
        
        [MethodImpl(Inline)]
        ApiHostCapture(ApiHostUri host, MemberExtractReport captured, MemberParseReport parsed, AsmFunctionList decoded)
        {
            this.Host = host;
            this.Extracted = captured;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

        /// <summary>
        /// The host uri
        /// </summary>
        public readonly ApiHostUri Host;

        /// <summary>
        /// The extract report
        /// </summary>
        public readonly MemberExtractReport Extracted;

        /// <summary>
        /// The parse reprt
        /// </summary>
        public readonly MemberParseReport Parsed;
        
        /// <summary>
        /// The decoded functions
        /// </summary>
        public readonly AsmFunctionList Decoded;
    }
}