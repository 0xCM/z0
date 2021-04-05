//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;

    [ApiHost]
    public class AsmRender : WfService<AsmRender>
    {
        readonly BitFormat Bf1;

        readonly BitFormat Bf2;

        readonly BitFormat Bf3;

        readonly BitFormat Bf4;

        readonly BitFormat Bf5;

        readonly BitFormat Bf6;

        readonly BitFormat Bf7;

        readonly BitFormat Bf8;

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
        public static string format(in AsmComment src)
            => src.Content.IsNonEmpty ? string.Format("; {0}",src.Content) : EmptyString;

        [Op]
        public static string format(in CpuId src)
        {
            const string FormatPattern = "fx:{0} subfx:{1} => eax:{2} ebx:{3} ecx:{4} edx:{5}";
            return text.format(FormatPattern, src.Fx, src.SubFx, src.Eax, src.Ebx, src.Ecx, src.Edx);
        }

        [Op]
        public static string format(in AsmBranchInfo src)
            => text.concat(src.Source, " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        [Op]
        public static string format(in AsmImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));

        [Op]
        public static string format(in AsmDisplacement src)
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
            => string.Format("{0}:{1}", src.Caller, src.InstructionOffset);

        [Op]
        public static string format(AsmFormExpr src)
            => string.Format("({0})<{1}>", src.Sig, src.OpCode);
        [Op]
        public static string format(in AsmCaller src)
            => string.Format("{0} {1}", src.Base, src.Identity);

        [Op]
        public static string format(in AsmCallee src)
            => text.concat(src.Base.Format(), Colon, Chars.Space, src.Identity);

        public static string format(in AsmCallInfo src)
            => string.Format("{0} -> {2}", src.CallSite, src.Target);

        [Op]
        public static string format(in CallRel32 src)
            => string.Format("{0}:{1} -> {2}", src.ClientAddress, src.TargetDx, src.TargetAddress);
    }
}