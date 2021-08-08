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

    [ApiHost]
    public class AsmBitfields
    {
        const char Open = Chars.LBracket;

        const char Delimit = Chars.Pipe;

        const char Sep = Chars.Space;

        const char Close = Chars.RBracket;

        const char Assign = Chars.Eq;

        public static AsmBitfields service()
            => The;

        OpCodes _OpCodes;

        static AsmBitfields The;

        public IAsmBitfield OpCodeField()
            => _OpCodes;

        AsmBitfields()
        {
            _OpCodes = new OpCodes();
        }

        static AsmBitfields()
        {
            The = new AsmBitfields();
        }

        sealed class OpCodes : AsmBitfield<AsmTokens.OpCodes>
        {
            public OpCodes()
                : base("OpCodeBits")
            {

            }
        }

        [Op]
        public static string format(Register src)
        {
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndexCode,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClassCode,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidthCode,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        [Op]
        public static uint modrm(Span<char> dst)
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var k=0u;
            for(var c=0u; c<f2.Length; c++)
            for(var b=0u; b<f1.Length; b++)
            for(var a=0u; a<f0.Length; a++)
            {
                var modrm = AsmEncoder.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                AsmBitfields.modrm(modrm, ref k, dst);
                seek(dst, k++) = Sep;
                seek(dst, k++) = Assign;
                seek(dst, k++) = Sep;

                var bits = modrm.Encoded.FormatBits() + "b";
                text.copy(bits, ref k, dst);

                seek(dst, k++) = Sep;
                seek(dst, k++) = Assign;
                seek(dst, k++) = Sep;

                var hex = modrm.Encoded.FormatAsmHex(2);
                text.copy(hex, ref k, dst);

                seek(dst,k++) = (char)AsciControl.CR;
                seek(dst,k++) = (char)AsciControl.LF;
            }
            return k;
        }

        [Op]
        public static uint modrm(ModRm src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            const string ModRM = "ModRM";
            const string Mod = "mod";
            const string Reg = "reg";
            const string Rm = "r/m";
            text.copy(ModRM, ref i, dst);
            seek(dst, i++) = Open;

            text.copy(Mod, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render2(src.Mod(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Sep;
            seek(dst, i++) = Delimit;
            seek(dst, i++) = Sep;

            text.copy(Reg, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render3(n3, src.Reg(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Sep;
            seek(dst, i++) = Delimit;
            seek(dst, i++) = Sep;

            text.copy(Rm, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render3(n3, src.Rm(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Close;
            return i - i0;
        }
    }
}