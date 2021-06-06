//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Rules;
    using static Chars;

    [ApiHost]
    public class AsmParser : AppService<AsmParser>
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
            var result = Outcome.Success;

            result = text.unfence(src, SigFence, out var sigexpr);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(SigFence,src));

            result = AsmParser.sig(sigexpr, out var sig);
            if(result.Fail)
                return (false, Msg.CouldNotParseSigExpr.Format(sigexpr));

            result = text.unfence(src, OpCodeFence, out var opcode);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(OpCodeFence, src));

            dst = new AsmFormExpr(asm.opcode(opcode), sig);
            return true;
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
                    dst = asm.sig(monic, AsmRender.format(monic, operands));
                    return true;
                }
            }
            dst = AsmSigExpr.Empty;
            return false;
        }

        [Op]
        public static Outcome parse(string src, out AsmSigExpr dst)
        {
            return sig(src, out dst);
        }

        [Op]
        public static Outcome parse(string src, out AsmStatementExpr dst)
        {
            dst = new AsmStatementExpr(src.Trim());
            return true;
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
            dst = asm.opcode(src);
            return true;
        }

        [Op]
        public static Outcome parse(AsmMnemonic src, out AsmMnemonicCode dst)
            => Enums.parse(src.Format(), out dst);

        [Op]
        public static Outcome parse(TextRow src, out AsmApiStatement dst)
        {
            var result = Outcome.Success;
            var count = src.CellCount;
            var cells = src.Cells.View;
            var i=0;
            if(count == AsmApiStatement.FieldCount)
            {
                result += DataParser.parse(skip(cells, i++), out dst.BlockAddress);
                result += DataParser.parse(skip(cells, i++), out dst.IP);
                result += DataParser.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = asm.statement(skip(cells, i++));
                dst.Encoded = AsmBytes.parse(skip(cells, i++));
                result += sig(skip(cells, i++), out dst.Sig);
                dst.OpCode = asm.opcode(skip(cells, i++));
                dst.Bitstring = dst.Encoded;
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
            var result = Outcome.Success;
            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmStatementExpr statement = a.RightOfFirst(Semicolon);

            var parts = @readonly(src.RightOfFirst(Semicolon).SplitClean(Implication));
            if(parts.Length < 2)
                return (false, $"Could not partition {src} ");

            var A = skip(parts,0);
            var B = skip(parts,1);

            // For thumbprints that include a bitstring such as 0001 0000 0000 1111
            var C = parts.Length > 2 ? skip(parts,2) : EmptyString;
            if(text.unfence(A, SigFence, out var sigexpr))
            {
                result = AsmParser.sig(sigexpr, out var sig);
                if(result.Fail)
                    return (false, $"Could not parse sig expression from ${sigexpr}");

                    AsmParser.code(sig.Mnemonic, out var monic);

                    if(text.unfence(A, OpCodeFence, out var opcode))
                    {
                        if(AsmBytes.parse(B, out var encoded))
                        {
                            thumbprint = new AsmThumbprint(statement, sig, asm.opcode(opcode), encoded);
                            return true;
                        }
                        else
                            return (false, "Could not parse the encoded bytes");
                    }
                    else
                        return (false, Msg.OpCodeFenceNotFound.Format(OpCodeFence));
            }
            else
                return (false, $"Could not locate the signature fence {SigFence}");
        }

        public static Outcome parse(uint line, string src, out AsmIndex dst)
            => parse(new TextLine(line, src), out dst);

        public static Outcome parse(uint line, ReadOnlySpan<char> src, out AsmIndex dst)
            => parse(text.line(line, text.format(src)), out dst);

        static MsgPattern<Count,Count,TextLine> FieldCountMismatch => "Expected {0} fields but found {1} in '{2}'";

        public static Outcome parse(TextLine src, out AsmIndex dst)
        {
            const string ErrorPattern = "Error parsing line {0}, cell {1} from '{2}'";
            var parts = src.Split(Chars.Pipe);
            var count = parts.Length;
            var outcome = Outcome.Success;
            if(count != AsmIndex.FieldCount)
            {
                dst = default;
                return (false, FieldCountMismatch.Format(AsmIndex.FieldCount, count, src));
            }
            dst = default;
            var i=0u;

            outcome += DataParser.parse(skip(parts,i++), out dst.Sequence);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.GlobalOffset);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockAddress);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.IP);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockOffset);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.Expression);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += AsmBytes.parse(skip(parts,i++), out dst.Encoded);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.Sig);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.OpCode);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            var bitstring = skip(parts,i++);
            dst.Bitstring = dst.Encoded;

            outcome += DataParser.parse(skip(parts,i++), out dst.OpUri);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, src, i-1, skip(parts,i-1)));

            return true;
        }
    }
}