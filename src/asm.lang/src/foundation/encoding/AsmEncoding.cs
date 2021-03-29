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

    [ApiHost]
    public readonly partial struct AsmEncoding
    {
        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 rm, uint3 reg, uint2 mod)
            => modrm(BitFields.join((rm,0), (reg,3), (mod,6)));

        [MethodImpl(Inline), Op]
        public static ModRm modrmRxRxD(uint3 r1, uint3 r2)
            => modrm(r1,r2,uint2.Max);

        public static void render(ModRm src, ITextBuffer dst)
        {
            const char Open = Chars.LBracket;
            const char Close = Chars.RBracket;
            const char Sep = Chars.Pipe;

            dst.Append(Open);

            dst.Append("Mod");
            dst.Append(Open);
            dst.Append(src.Mod.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Reg");
            dst.Append(Open);
            dst.Append(src.Reg.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Rm");
            dst.Append(Open);
            dst.Append(src.Rm.Format());
            dst.Append(Close);

            dst.Append(Close);
        }
    }
}