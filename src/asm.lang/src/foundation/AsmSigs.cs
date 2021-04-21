//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;
    using static memory;
    using static Rules;
    using static TextRules;

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        Index<char> RegDigits;

        Adjacent<char, OneOf<char>> RegDigitRule;

        public AsmSigs()
        {
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));

        }

        [Op]
        public bool IsDigit(AsmOpCodeExpr src)
        {
            var s = src.Content;
            return s.Length >= 2
                && @char(s) == DigitQualifier
                && Query.test(@char(s,1), Rules.oneof(RegDigits));
        }

        [Op]
        public bool ParseDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(TextRules.eval(src, RegDigitRule, out var result) &&
                text.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }
    }
}