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
    using static AsmRegTokens;
    using static Blit;

    partial struct CallCv
    {
        [MethodImpl(Inline), Op]
        public static ref readonly v4<Gp8Reg> regslots(win64 cc, W8 w)
            => ref first(recover<v4<Gp8Reg>>(bytes(winX64Regs(w))));

        [MethodImpl(Inline), Op]
        public static ref readonly v4<Gp16Reg> regslots(win64 cc, W16 w)
            => ref first(recover<v4<Gp16Reg>>(bytes(winX64Regs(w))));

        [MethodImpl(Inline), Op]
        public static ref readonly v4<Gp32Reg> regslots(win64 cc, W32 w)
            => ref first(recover<v4<Gp32Reg>>(bytes(winX64Regs(w))));

        [MethodImpl(Inline), Op]
        public static ref readonly v4<Gp64Reg> regslots(win64 cc, W64 w)
            => ref first(recover<v4<Gp64Reg>>(bytes(winX64Regs(w))));
    }
}
