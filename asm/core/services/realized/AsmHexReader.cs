//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    readonly struct AsmHexReader : IHexDataReader
    {
        [MethodImpl(Inline)]
        public static IHexDataReader New(IContext context)
            => default(AsmHexReader);

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        Option<AsmOpBits> Parse(string formatted)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var uritext = formatted.TakeBefore(Chars.Space).Trim();
                var uri = OpUri.Parse(uritext);
                var bytes = formatted.TakeAfter(Chars.Space).SplitClean(HexSpecs.DataDelimiter).Select(parser.ParseByte).ToArray();
                return AsmOpBits.Define(uri, bytes);                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        public IEnumerable<AsmOpBits> Read(FilePath src)
            => from line in src.ReadLines().Select(Parse)
                where line.IsSome()
                select line.Value;
    }
}