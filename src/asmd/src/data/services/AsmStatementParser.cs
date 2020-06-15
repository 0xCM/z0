//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public readonly struct AsmStatementParser : ITextParser<AsmStatement>
    {
        public static AsmStatementParser Default => Create();

        public static AsmStatementParser Create(IParser<string,Mnemonic> parser = null)
        {
            if(parser != null)   
                return new AsmStatementParser(src => parser.Parse(src).ValueOrDefault(Mnemonic.INVALID));
            else
                return new AsmStatementParser(src => Enums.Parse(src,Mnemonic.INVALID));
        }

        readonly Func<string,Mnemonic> MnemonicParse;
        
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