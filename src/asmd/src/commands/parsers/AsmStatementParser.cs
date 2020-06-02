//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct AsmStatementParser : ITextParser<AsmStatement>
    {
        public static AsmStatementParser Service => default(AsmStatementParser);

        public ParseResult<AsmStatement> Parse(string src)
        {
            var hp = HexScalarParser.Service;
            var offset = hp.Parse(src.LeftOf(Chars.Space));
            if(offset)            
            {
                var expression = src.RightOf(Chars.Space);
                return ParseResult.Success(src, new AsmStatement((ushort)offset.Value, expression));
            }

            return ParseResult.Fail<AsmStatement>(src);            
        }
    }
}