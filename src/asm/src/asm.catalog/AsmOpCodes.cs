//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using static AsmOpCodeModel;
    using static AsmMnemonics;
    using static TextRules;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static RegDigit digit(uint3 src)
            => new RegDigit(src);

        public static string normalize(AsmSigExpr sig, string opcode, BinaryCode encoded)
        {
            if(ParseMnemonic(sig, out var mnemonic) && mnemonic == PUSH)
            {
                var rule = Rules.fork(Chars.Plus);
                var result = Transform.apply(rule, opcode);
                return string.Format("{0} +{1}", result.Left, result.Right);
            }
            else
                return opcode;
        }

        static bool ParseMnemonic(AsmSigExpr src, out AsmMnemonicExpr dst)
        {
            var i = Query.index(src.Text, Chars.Space);
            if(i != NotFound && i > 0)
            {
                dst = AsmExpr.mnemonic(Parse.segment(src.Text, 0, i - 1));
                return true;
            }
            else
            {
                dst = AsmMnemonicExpr.Empty;
                return false;
            }
        }
    }
}