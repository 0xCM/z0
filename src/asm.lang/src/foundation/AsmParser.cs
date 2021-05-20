//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;


    using static Part;
    using static memory;
    using static Rules;
    using static Chars;

    [ApiHost]
    public readonly partial struct AsmParser
    {
        const string Implication = " => ";

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


        [Op]
        public static AsmSigExpr sig(string src)
        {
            if(sig(src, out var dst))
                return dst;
            else
                return AsmSigExpr.Empty;
        }

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        [Op]
        public static Outcome form(string src, out AsmFormExpr dst)
        {
            dst = AsmFormExpr.Empty;
            if(text.unfence(src, SigFence, out var sigexpr))
            {
                if(AsmParser.sig(sigexpr, out var sig))
                {
                    if(text.unfence(src, OpCodeFence, out var opcode))
                    {
                        dst = new AsmFormExpr(AsmCore.opcode(opcode), sig);
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
        public static Outcome sig(string src, out AsmSigExpr dst)
        {
            if(text.nonempty(src))
            {
                if(AsmParser.mnemonic(src, out var monic))
                {
                    var i = text.index(src, Chars.Space);
                    var operands = i > 0 ? src.Substring(i).Split(Chars.Comma).Map(sigop) : sys.empty<AsmSigOperandExpr>();
                    dst = AsmCore.sig(monic, AsmRender.format(monic, operands));
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

        [MethodImpl(Inline), Op]
        static AsmSigOperandExpr sigop(string src)
            => new AsmSigOperandExpr(src.Trim());

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
                    dst = text.segment(sig, 0, i - 1).ToUpper();
                    return true;
                }
                else
                {
                    dst = sig;
                    return true;
                }
            }
        }

        public static Outcome parse(string src, out AsmOpCodeExpr dst)
        {
            dst = AsmCore.opcode(src);
            return true;
        }

        [Op]
        public static Outcome parse(AsmMnemonic src, out AsmMnemonicCode dst)
            => ClrEnums.parse(src.Format(), out dst);

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src.Trim());

        [Op]
        public static Outcome parse(TextRow src, out AsmApiStatement dst)
        {
            var count = src.CellCount;
            var i=0;
            var cells = src.Cells.View;
            if(count == AsmApiStatement.FieldCount)
            {
                DataParser.parse(skip(cells, i++), out dst.BlockAddress);
                DataParser.parse(skip(cells, i++), out dst.IP);
                DataParser.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = AsmCore.statement(skip(cells,i++));
                dst.Encoded = AsmBytes.hexcode(skip(cells, i++));
                sig(skip(cells, i++), out dst.Sig);
                dst.OpCode = AsmCore.opcode(skip(cells, i++));
                if(!DataParser.parse(skip(cells, i++), out dst.OpUri))
                    return (false, $"Failed to parse uri text <{skip(cells,i)}>");

                return true;
            }
            else
            {
                dst = default;
                var msg = $"Wrong number of cells in row {src}";
                return (false,msg);
            }
        }

        public static Outcome thumbprint(string src, out AsmThumbprint thumbprint)
        {
            thumbprint = AsmThumbprint.Empty;
            var outcome = Outcome.Empty;
            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmStatementExpr statement = a.RightOfFirst(Semicolon);

            var parts = @readonly(src.RightOfFirst(Semicolon).SplitClean(Implication));
            if(parts.Length == 2)
            {
                var lhs = skip(parts,0);
                var rhs = skip(parts,1);
                if(text.unfence(lhs, SigFence, out var sigexpr))
                {
                    if(AsmParser.sig(sigexpr, out var sig, out outcome))
                    {
                        AsmParser.code(sig.Mnemonic, out var monic);

                        if(text.unfence(lhs, OpCodeFence, out var opcode))
                        {
                            if(AsmBytes.hexcode(rhs, out var encoded))
                            {
                                thumbprint = new AsmThumbprint(statement, sig, AsmCore.opcode(opcode), encoded);
                                return true;
                            }
                            else
                                return (false, "Could not parse the encoded bytes");
                        }
                        else
                            return (false, Msg.OpCodeFenceNotFound.Format(OpCodeFence));

                    }
                    else
                        return (false, $"Could not parse sig expression from ${sigexpr}");
                }
                else
                    return (false, $"Could not locate the signature fence {SigFence}");
            }
            else
                return (false, $"Could not dichotomize {src} ");
        }
    }
}