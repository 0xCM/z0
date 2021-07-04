//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;
    using static core;
    using static Rules;
    using static Chars;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;
    using SR = SymbolicRender;

    [ApiHost]
    public readonly struct AsmParser
    {
        public static Outcome parse(ReadOnlySpan<AsciCode> src, out AsmExpr dst)
        {
            dst = AsmExpr.Empty;
            var outcome = Outcome.Success;
            var i = SP.EatWhitespace(src);
            if(i == NotFound)
                return (false,"Input was empty");

            var remainder = slice(src,i);
            i = SQ.index(remainder,AsciCode.Space);
            if(i == NotFound)
            {
                var monic = asm.mnemonic(SR.format(remainder).Trim());
                var operands = Span<char>.Empty;
                dst = asm.expr(monic,operands);
            }
            else
            {
                var monic = asm.mnemonic(SR.format(slice(remainder,0, i)).Trim());
                var operands = SR.format(slice(remainder,i)).Trim();
                dst = asm.expr(monic, operands);
            }

            return outcome;
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

        [Op]
        public static Outcome form(string src, out AsmFormExpr dst)
        {
            dst = AsmFormExpr.Empty;
            var result = Outcome.Success;

            result = FenceParser.unfence(src, SigFence, out var sigexpr);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(SigFence,src));

            result = sig(sigexpr, out var _sig);
            if(result.Fail)
                return (false, Msg.CouldNotParseSigExpr.Format(sigexpr));

            result = FenceParser.unfence(src, OpCodeFence, out var opcode);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(OpCodeFence, src));

            dst = new AsmFormExpr(asm.opcode(opcode), _sig);
            return true;
        }

        [Op]
        public static Outcome mnemonic(string sig, out AsmMnemonic dst)
        {
            dst = AsmMnemonic.Empty;
            if(text.empty(sig))
                return false;

            var trimmed = sig.Trim();
            var i = text.index(trimmed, Chars.Space);
            if(i == NotFound)
                return false;
            else
            {
                dst = text.substring(trimmed,0,i);
                return true;
            }
        }

        [Op]
        public static Outcome sig(string src, out AsmSigExpr dst)
        {
            if(text.empty(src))
                return true;

            var trimmed = src.Trim();
            var i = text.index(trimmed, Chars.Space);
            if(i == NotFound)
                dst = asm.sig(asm.mnemonic(src), src);
            else
            {
                var mnemonic = asm.mnemonic(text.slice(trimmed,0,i));
                var operands = text.slice(trimmed, i + 1);
                dst = asm.sig(mnemonic, trimmed);
            }
            return true;
        }

        [Op]
        public static Outcome parse(string src, out AsmExpr dst)
        {
            dst = new AsmExpr(src.Trim());
            return true;
        }

        public static Outcome parse(string src, out AsmOpCodeExpr dst)
        {
            dst = asm.opcode(src);
            return true;
        }

        [Op]
        public static Outcome parse(in AsmMnemonic src, out AsmMnemonicCode dst)
        {
            if(Enums.parse(src.Format(), out dst))
                return true;
            else
            {
                dst = 0;
                return false;
            }
        }

        [Op]
        public static Outcome parse(in TextRow src, out AsmApiStatement dst)
        {
            var result = Outcome.Success;
            var count = src.CellCount;
            var cells = src.Cells;
            var i=0;
            if(count == AsmApiStatement.FieldCount)
            {
                result += DataParser.parse(skip(cells, i++), out dst.BlockAddress);
                result += DataParser.parse(skip(cells, i++), out dst.IP);
                result += DataParser.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = asm.expr(skip(cells, i++));
                dst.Encoded = AsmHexCode.parse(skip(cells, i++));
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

        public static Outcome<uint> parse(in TextGrid doc, ConcurrentBag<AsmApiStatement> dst)
        {
            const byte StatementFieldCount = AsmApiStatement.FieldCount;

            var counter = 0u;
            if(doc.Header.Labels.Length != StatementFieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(StatementFieldCount, doc.Header.Labels.Length));

            var count = doc.RowCount;
            var rows = doc.RowData.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var result = parse(row, out AsmApiStatement statement);
                if(result)
                {
                    dst.Add(statement);
                    counter++;
                }
                else
                    return result;
            }
            return counter;
        }

        public static Outcome thumbprint(string src, out AsmThumbprint thumbprint)
        {
            thumbprint = AsmThumbprint.Empty;
            var result = Outcome.Success;
            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmExpr statement = a.RightOfFirst(Semicolon);

            var parts = @readonly(src.RightOfFirst(Semicolon).SplitClean(Implication));
            if(parts.Length < 2)
                return (false, $"Could not partition {src} ");

            var A = skip(parts,0);
            var B = skip(parts,1).Trim();

            // For thumbprints that include a bitstring such as 0001 0000 0000 1111
            var C = parts.Length > 2 ? skip(parts,2) : EmptyString;
            if(FenceParser.unfence(A, SigFence, out var sigexpr))
            {
                result = AsmParser.sig(sigexpr, out var sig);
                if(result.Fail)
                    return (false, $"Could not parse sig expression from ${sigexpr}");

                    AsmParser.code(sig.Mnemonic, out var monic);

                    if(FenceParser.unfence(A, OpCodeFence, out var opcode))
                    {
                        if(AsmHexCode.parse(B, out var encoded))
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

        public static ref AsmFormRecord parse(in TextRow src, ref AsmFormRecord dst)
        {
            var i = 0;
            DataParser.parse(src[i++], out dst.Seq);
            AsmParser.opcode(src[i++], out dst.OpCode);
            AsmParser.sig(src[i++], out dst.Sig);
            AsmParser.form(src[i++], out dst.FormExpr);
            return ref dst;
        }

        public static Outcome parse(TextLine src, out AsmIndex dst)
        {
            const string ErrorPattern = "Error parsing {0} on line {1}";
            var parts = src.Split(Chars.Pipe).Map(x => x.Trim());
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
                return (false, string.Format(ErrorPattern, nameof(dst.Sequence), src.LineNumber));

            outcome += DataParser.parse(skip(parts,i++), out dst.GlobalOffset);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.GlobalOffset), src.LineNumber));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockAddress);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.BlockAddress), src.LineNumber));

            outcome += DataParser.parse(skip(parts,i++), out dst.IP);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.IP), src.LineNumber));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockOffset);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.BlockOffset), src.LineNumber));

            outcome += parse(skip(parts,i++), out dst.Statement);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.Statement), src.LineNumber));

            outcome += AsmHexCode.parse(skip(parts,i++), out dst.Encoded);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.Encoded), src.LineNumber));

            outcome += sig(skip(parts,i++), out dst.Sig);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.Sig), src.LineNumber));

            dst.OpCode = asm.opcode(skip(parts, i++));

            var bitstring = skip(parts,i++);
            dst.Bitstring = dst.Encoded;

            outcome += DataParser.parse(skip(parts,i++), out dst.OpUri);
            if(outcome.Fail)
                return (false, string.Format(ErrorPattern, nameof(dst.OpUri), src.LineNumber));

            return true;
        }

        public static Outcome parse(TextRow src, out AsmDetailRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Empty;
            dst = default;
            outcome = DataParser.parse(skip(input, i++), out dst.Sequence);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.BlockAddress);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.IP);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.GlobalOffset);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.LocalOffset);
            if(!outcome)
                return outcome;

            dst.Mnemonic = new AsmMnemonic(skip(input, i++));

            outcome = parse(skip(input, i++), out dst.OpCode);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Instruction);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Statement);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Encoded);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.CpuId);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.OpCodeId);
            if(!outcome)
                return outcome;
            return true;
        }

        public static Outcome parse(TextRow src, out CpuIdRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Success;
            outcome += DataParser.parse(skip(input,i++), out dst.Chip);
            outcome += DataParser.parse(skip(input,i++), out dst.Leaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Subleaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Eax);
            outcome += DataParser.parse(skip(input,i++), out dst.Ebx);
            outcome += DataParser.parse(skip(input,i++), out dst.Ecx);
            outcome += DataParser.parse(skip(input,i++), out dst.Edx);
            return outcome;
        }

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static MsgPattern<Count,Count,TextLine> FieldCountMismatch => "Expected {0} fields but found {1} in '{2}'";

        const string Implication = " => ";
    }
}