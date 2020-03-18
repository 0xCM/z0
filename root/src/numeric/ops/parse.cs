//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Root;

    partial class Numeric
    {

        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ulong> parseHex(string src)
            => NumericParser.ParseHex(src)
                .MapValueOrElse(
                    value => ParseResult.Success(src,value), 
                    () => ParseResult.Fail<ulong>(src));                    
                    
        /// <summary>
        /// Attempts to parse the source text as a parametrically-identified type
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), NumericClosures(NumericKind.All)]
        public static ParseResult<T> parse<T>(string src)
            where T : unmanaged
                => NumericParser.Try<T>(src);
    }
}