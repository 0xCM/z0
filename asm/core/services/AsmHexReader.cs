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

    using static Root;

    readonly struct AsmHexReader : IAsmHexReader
    {
        const char DefaultIdSep = AsciSym.Space;

        const char DefaultByteSep = AsciSym.Space;

        public IAsmContext Context {get;}

        readonly char IdSep;
        
        readonly char ByteSep;

        [MethodImpl(Inline)]
        public static IAsmHexReader New(IAsmContext context, char? idsep = null, char? bytesep = null)
            => new AsmHexReader(context, idsep, bytesep);

        [MethodImpl(Inline)]
        AsmHexReader(IAsmContext context, char? idsep = null, char? bytesep = null)
        {
            this.Context = context;
            this.IdSep = idsep ?? DefaultIdSep;
            this.ByteSep = bytesep ?? DefaultByteSep;
        }

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
                var uritext = formatted.TakeBefore(IdSep).Trim();
                var uri = OpUri.Parse(uritext);
                var bytes = formatted.TakeAfter(IdSep).SplitClean(ByteSep).Select(HexParser.parsebyte).ToArray();
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