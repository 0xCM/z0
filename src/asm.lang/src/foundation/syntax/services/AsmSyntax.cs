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
    using static Rules;
    using static TextRules;
    using static TextRules.Parse;

    [ApiHost]
    public readonly struct AsmSyntax
    {
        const char OperandDelimiter = Chars.Comma;

        const char MnemonicTerminator = Chars.Space;

        [Op]
        public static Outcome mnemonic(string sig, out AsmMnemonic dst)
        {
            dst = AsmMnemonic.Empty;
            if(text.empty(sig))
                return false;

            if(MnemonicText(sig, out var candidate))
            {
                dst = new AsmMnemonic(candidate);
                return true;
            }
            else
                return false;
        }

        [Op]
        public static AsmSigExpr sig(string src)
        {
            if(AsmSyntax.sig(src, out var dst))
                return dst;
            else
                return AsmSigExpr.Empty;
        }

        [Op]
        public static Outcome sig(string src, out AsmSigExpr dst)
        {
            if(text.nonempty(src))
            {
                if(AsmSyntax.mnemonic(src, out var monic))
                {
                    var i = text.index(src, MnemonicTerminator);
                    var operands = i > 0 ? src.Substring(i).Split(OperandDelimiter).Map(sigop) : sys.empty<AsmSigOperandExpr>();
                    dst = new AsmSigExpr(monic, operands, format(monic, operands));
                    return true;
                }
            }
            dst = AsmSigExpr.Empty;
            return false;
        }

        [Op]
        public static Outcome sig(string src, out AsmSigExpr dst, out Outcome result)
        {
            result = sig(src, out dst);
            return result;
        }

        [Op]
        public static Outcome form(string src, out AsmFormExpr dst)
        {
            dst = AsmFormExpr.Empty;
            if(unfence(src, SigFence, out var sigexpr))
            {
                if(AsmSyntax.sig(sigexpr, out var sig))
                {
                    if(unfence(src, OpCodeFence, out var opcode))
                    {
                        dst = new AsmFormExpr(asm.opcode(opcode), sig);
                        return true;
                    }
                    else
                        return (false, Msg.FenceNotFound.Format(OpCodeFence, src));
                }
                else
                    return (false, Msg.CouldNotParseSigExpr.Format(sigexpr));
            }
            else
                return (false, Msg.FenceNotFound.Format(SigFence,src));
        }

        [Op]
        public static Outcome opcode(string src, out AsmOpCodeExpr dst)
        {
            dst = new AsmOpCodeExpr(src);
            return true;
        }

        [Op]
        public static Outcome code(AsmMnemonic src, out AsmMnemonicCode dst)
        {
            if(Enum.TryParse(typeof(AsmMnemonicCode), src.Format(), true, out var _code))
            {
                dst = (AsmMnemonicCode)_code;
                return true;
            }

            dst = 0;
            return false;
        }

        [MethodImpl(Inline), Op]
        static AsmSigOperandExpr sigop(string src)
            => new AsmSigOperandExpr(src.Trim());

        [Op]
        static bool MnemonicText(string sig, out string dst)
        {
            const char MnemonicTerminator = Chars.Space;

            if(text.empty(sig))
            {
                dst = EmptyString;
                return false;
            }
            else
            {
                var i = text.index(sig, MnemonicTerminator);
                if(i > 0)
                {
                    dst = Parse.segment(sig, 0, i - 1).ToUpper();
                    return true;
                }
                else
                {
                    dst = sig;
                    return true;
                }
            }
        }

        [Op]
        static string format(AsmMnemonic monic, Index<AsmSigOperandExpr> operands)
        {
            var dst = text.buffer();
            render(monic, operands, dst);
            return dst.Emit();
        }

        [Op]
        static void render(AsmMnemonic monic, Index<AsmSigOperandExpr> operands, ITextBuffer dst)
        {
            dst.Append(monic.Format(MnemonicCase.Uppercase));
            var opcount = operands.Length;
            if(opcount != 0)
            {
                dst.Append(Chars.Space);
                dst.Append(Format.join(OperandDelimiter, operands));
            }
        }

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);
    }
}