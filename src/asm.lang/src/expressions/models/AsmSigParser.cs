//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;
    using static TextRules;

    [ApiHost]
    public readonly struct AsmSigParser
    {
        const char MnemonicTerminator = Chars.Space;

        const char OperandDelimiter = Chars.Comma;

        [Op]
        public static bool mnemonic(string sig, out AsmMnemonic dst)
        {
            dst = default;
            if(text.empty(sig))
                return false;

            var i = Query.index(sig, MnemonicTerminator);
            if(i > 0)
                dst = new AsmMnemonic(Parse.segment(sig, 0, i - 1));
            else
                dst = new AsmMnemonic(sig);

            return true;
        }

        [Op]
        public static AsmMnemonic mnemonic(string sig)
        {
            if(mnemonic(sig, out var dst))
                return dst;
            else
                return AsmMnemonic.Empty;
        }

        [Op]
        public static bool parse(string src, out Signature dst)
        {
            if(text.nonempty(src))
            {
                if(mnemonic(src, out var monic))
                {
                    var i = Query.index(src, MnemonicTerminator);
                    var operands = i > 0 ? src.Substring(i).Split(OperandDelimiter).Map(operand) : sys.empty<SigOperand>();
                    dst = new Signature(monic, operands);
                    return true;
                }
            }
            dst = Signature.Empty;
            return false;
        }

        [Op]
        public static Signature parse(string src)
        {
            if(parse(src, out var dst))
                return dst;
            else
                return Signature.Empty;
        }

        /// <summary>
        /// Defines a <see cref='SigOperand'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static SigOperand operand(string src)
            => new SigOperand(src);
    }
}