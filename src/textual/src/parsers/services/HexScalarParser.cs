//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Globalization;

    using static Seed;
    using static HexSpecs;

    public readonly struct HexScalarParser : ITextParser<ulong>
    {        
        public static HexScalarParser Service => default(HexScalarParser);
        
        public ParseResult<ulong> Parse(string src)  
            => SystemParse(src)
                .MapValueOrElse(
                    value => ParseResult.Success(src,value), 
                    () => ParseResult.Fail<ulong>(src));                    
            
        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        Option<ulong> SystemParse(string src)
        {            
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return value;
            return default;
        }
    }
}