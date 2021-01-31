//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;
    using static Rules;
    using static AsmOpCodeModel;

    [ApiHost]
    public sealed class AsmOpCodeParser : WfService<AsmOpCodeParser, AsmOpCodeParser>
    {
        OneOf<char> RegDigits = Rules.oneof('0','1', '2', '3', '4', '5', '6', '7');

        public AsmOpCodeParser()
        {

        }


        [Op]
        public bool RegisterDigit(string src, out RegDigit dst)
        {
            dst = default;
            var rule = Rules.adjacent(Chars.FSlash, RegDigits);
            if(Parse.rule(src, rule, out var result))
            {
                if(Parse.digit(result.B, out var digit))
                    dst = digit;
            }

            return false;
        }
    }
}