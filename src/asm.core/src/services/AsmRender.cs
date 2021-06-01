//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static Chars;
    using static core;

    [ApiHost]
    public readonly struct AsmRender
    {
        const char Open = Chars.LBracket;

        const string Sep = " | ";

        const char Close = Chars.RBracket;

        [Op]
        public static string bits(RexPrefix src)
            => text.format(BitRender.render(n8, n4, src.Code));

        const string RexFieldPattern = "[W:{0} | R:{1} | X:{2} | B:{3}]";

        [Op]
        public static string bitfield(RexPrefix src)
            => string.Format(RexFieldPattern, src.W, src.R, src.X, src.B);

        public static string describe(RexPrefix src)
            => $"{src.Code.FormatAsmHex()} | [{bits(src)}] => {bitfield(src)}";

        public static string bitfield(Vsib src)
        {
            var dst = text.buffer();
            dst.Append(Open);

            dst.Append(src.SS.ToString());

            dst.Append(Sep);

            dst.Append(src.Index.ToString());

            dst.Append(Sep);

            dst.Append(src.Base.ToString());

            dst.Append(Close);
            return dst.Emit();
        }

        public static void bitfield(ModRm src, ITextBuffer dst)
        {
            dst.Append(Open);

            dst.Append("ModRM.mod");
            dst.Append(Chars.Colon);
            dst.Append(src.Mod.Format());

            dst.Append(Sep);

            dst.Append("ModRM.reg");
            dst.Append(Chars.Colon);
            dst.Append(src.Reg.Format());

            dst.Append(Sep);

            dst.Append("ModRM.r/m");
            dst.Append(Chars.Colon);
            dst.Append(src.Rm.Format());

            dst.Append(Close);
        }

        [Op]
        public static byte format(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = AsmCore.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.asmcomment(src.Uri, src.CodeBlock);
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            seek(dst, i++) = src.Separator;
            return i;
        }

        [Op]
        public static void render(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config, ITextBuffer dst)
        {
            const string AbsolutePattern = "{0} {1} {2}";
            const string RelativePattern = "{0} {1}";

            var label = asm.label(w16, src.Offset);
            var address = @base + src.Offset;

            if(config.AbsoluteLabels)
                dst.Append(string.Format(AbsolutePattern, address.Format(), label.Format(), src.Statement.FormatFixed()));
            else
                dst.Append(string.Format(RelativePattern, label.Format(), src.Statement.FormatFixed()));

            dst.Append(AsmCore.comment(AsmRender.format(src.AsmForm, src.Encoded, config.FieldDelimiter)));
        }

        [Op]
        public static string format(AsmThumbprint src)
            => string.Format("{0} ; ({1})<{2}>[{3}] => {4}", src.Statement.FormatFixed(), src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());

        [Op]
        public static string comment(AsmThumbprint src)
            => string.Format("; ({0})<{1}>[{2}] => {3}",  src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());

        [Op]
        public static string format(AsmFormExpr src, byte[] encoded, string sep)
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHex());

        [Op]
        public static string format(AsmMnemonic monic, Index<AsmSigOperandExpr> operands)
        {
            var dst = text.buffer();
            render(monic, operands, dst);
            return dst.Emit();
        }

        [Op]
        public static void render(AsmMnemonic monic, Index<AsmSigOperandExpr> operands, ITextBuffer dst)
        {
            dst.Append(monic.Format(MnemonicCase.Uppercase));
            var opcount = operands.Length;
            if(opcount != 0)
            {
                dst.Append(Chars.Space);
                dst.Append(text.join(Chars.Comma, operands));
            }
        }

        [Op]
        public static string format(ModRm src)
        {
            var dst = text.buffer();
            dst.Append(src.Rm.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Reg.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Mod.Format());
            return dst.ToString();
        }

        [Op]
        public static string format(Sib src)
        {
            var dst = text.buffer();
            dst.Append(src.Base.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Index.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Scale.Format());
            return dst.ToString();
        }

        [Op]
        public static string format(in AsmBranchInfo src)
            => text.concat(src.Source, " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        [Op]
        public static string format(in AsmImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));

        [Op]
        public static string format(in AsmDx src)
            => (src.Size switch{
                AsmDisplacementSize.y1 => ((byte)src.Value).FormatHex(HexSpec),
                AsmDisplacementSize.y2 => ((ushort)src.Value).FormatHex(HexSpec),
                AsmDisplacementSize.y4 => ((uint)src.Value).FormatHex(HexSpec),
                _ => (src.Value).FormatHex(HexSpec),
            }) + "dx";


        static HexFormatOptions HexSpec
        {
            [MethodImpl(Inline), Op]
            get => HexFormatSpecs.options(zpad:false, specifier:false);
        }

        [Op]
        public static string offset(ulong offset, DataWidth width)
            => width switch{
                DataWidth.W8 => ScalarCast.uint8(offset).FormatAsmHex(),
                DataWidth.W16 => ScalarCast.uint16(offset).FormatAsmHex(),
                DataWidth.W32 => ScalarCast.uint32(offset).FormatAsmHex(),
                DataWidth.W64 => offset.FormatAsmHex(),
                _ => EmptyString
            };

        [Op]
        public static string format(in AsmCallSite src)
            => string.Format("{0}:{1}", src.Caller, src.LocalOffset);

        [Op]
        public static string format(AsmFormExpr src)
            => string.Format("({0})<{1}>", src.Sig, src.OpCode);
        [Op]
        public static string format(in AsmCaller src)
            => string.Format("{0} {1}", src.Base, src.Identity);

        [Op]
        public static string format(in AsmCallee src)
            => string.Concat(src.Base.Format(), Colon, Chars.Space, src.Identity);

        [Op]
        public static string format(in AsmCallInfo src)
            => string.Format("{0} -> {2}", src.CallSite, src.Target);

        [Op]
        public static string format(in CallRel32 src)
            => string.Format("{0}:{1} -> {2}", src.ClientAddress, src.TargetDx, src.TargetAddress);
    }
}