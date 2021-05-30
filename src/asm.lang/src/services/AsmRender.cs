//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static Typed;
    using static Chars;
    using static core;

    [ApiHost]
    public class AsmRender : AppService<AsmRender>
    {
        readonly BitFormat Bf1;

        readonly BitFormat Bf2;

        readonly BitFormat Bf3;

        readonly BitFormat Bf4;

        readonly BitFormat Bf5;

        readonly BitFormat Bf6;

        readonly BitFormat Bf7;

        readonly BitFormat Bf8;

        readonly Symbols<AsmMnemonicCode> Mnemonics;

        public AsmRender()
        {
            Bf1 = BitFormatOptions.bitmax(uint1.Width, uint1.Width);
            Bf2 = BitFormatOptions.bitmax(uint2.Width, uint2.Width);
            Bf3 = BitFormatOptions.bitmax(uint3.Width, uint3.Width);
            Bf4 = BitFormatOptions.bitmax(uint4.Width, uint4.Width);
            Bf5 = BitFormatOptions.bitmax(uint5.Width, uint5.Width);
            Bf6 = BitFormatOptions.bitmax(uint6.Width, uint6.Width);
            Bf7 = BitFormatOptions.bitmax(uint7.Width, uint7.Width);
            Bf8 = BitFormatOptions.bitmax(uint8T.Width, uint8T.Width);
            Mnemonics = Symbols.symbolic<AsmMnemonicCode>();
        }

        protected override void OnInit()
        {

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


        [Op]
        public static string format(DirectMemoryOp src)
        {
            var dst = text.buffer();
            if(src.Base.IsNonEmpty)
                dst.Append(src.Base.Format());
            else
                dst.Append("UNK");

            if(src.Scale.NonUnital && src.Scale.NonZero)
            {
                var scale = src.Scale.Format();
                dst.Append(string.Concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(string.Concat(Chars.Space, Chars.Plus, Chars.Space, format(src.Dx)));

            return dst.ToString();
        }

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