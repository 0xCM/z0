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
        public static Disp8 disp(byte value, AsmScale size = AsmScale.y1)
            => new Disp8(value);

        [MethodImpl(Inline), Op]
        public static Disp16 disp(ushort value, AsmScale size = AsmScale.y1)
            => new Disp16(value);

        [MethodImpl(Inline), Op]
        public static Disp32 disp(uint value, AsmScale size = AsmScale.y1)
            => new Disp32(value);
    }
}