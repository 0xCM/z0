//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;
    using static Chars;

    [ApiHost]
    public class AsmRender : WfService<AsmRender>
    {
        // [Op]
        // public static string format(in AsmOffsetLabel src)
        //     => src.Width switch{
        //         DataWidth.W8 => ScalarCast.uint8(src.Offset).FormatAsmHex(),
        //         DataWidth.W16 => ScalarCast.uint16(src.Offset).FormatAsmHex(),
        //         DataWidth.W32 => ScalarCast.uint32(src.Offset).FormatAsmHex(),
        //         DataWidth.W64 => src.Offset.FormatAsmHex(),
        //         _ => EmptyString
        //     };

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