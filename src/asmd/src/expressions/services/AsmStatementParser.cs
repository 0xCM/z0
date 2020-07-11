//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatementParser : ITextParser<AsmStatement>
    {        
        readonly Func<string,Mnemonic> MnemonicParse;
        
        [MethodImpl(Inline)]
        public AsmStatementParser(Func<string,Mnemonic> parser)
        {
            MnemonicParse = parser;
        }

        public ParseResult<AsmStatement> Parse(string src)
        {
            var mnemonic = MnemonicParse(src.LeftOf(Chars.Space));
            if(mnemonic != Mnemonic.INVALID)
            {
                var operands = src.RightOf(Chars.Space).SplitClean(Chars.Comma);
                return ParseResult.Success(src, new AsmStatement(mnemonic, operands));
            }
            else
                return ParseResult.Fail<AsmStatement>(src);            
        }
    }
}