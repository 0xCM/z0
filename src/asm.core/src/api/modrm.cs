//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static ModRmByte modrm(byte mod, byte reg, byte rm)
        {
            var dst = ModRmByte.Empty;
            dst.Rm(rm);
            dst.Reg(reg);
            dst.Mod(mod);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ModRmByte modrm(byte mod, RegIndex reg, RegIndex rm)
            => modrm(mod, (byte)reg,(byte)rm);
    }
}