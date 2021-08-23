//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmRegTokens;

    partial struct CallCv
    {
        [MethodImpl(Inline), Op]
        public static bit regslot(win64 cc, byte index, out Gp8Reg dst)
        {
            var i = math.and(index,Win64MaxReg);
            bit valid = i <= Win64MaxReg;
            dst = winX64Reg(w8,i);
            return valid;
        }

        [MethodImpl(Inline), Op]
        public static bit regslot(win64 cc, byte index, out Gp16Reg dst)
        {
            var i = math.and(index,Win64MaxReg);
            bit valid = i <= Win64MaxReg;
            dst = winX64Reg(w16,i);
            return valid;
        }

        [MethodImpl(Inline), Op]
        public static bit regslot(win64 cc, byte index, out Gp32Reg dst)
        {
            var i = math.and(index,Win64MaxReg);
            bit valid = i <= Win64MaxReg;
            dst = winX64Reg(w32,i);
            return valid;
        }

        [MethodImpl(Inline), Op]
        public static bit regslot(win64 cc, byte index, out Gp64Reg dst)
        {
            var i = math.and(index,Win64MaxReg);
            bit valid = i <= Win64MaxReg;
            dst = winX64Reg(w64,i);
            return valid;
        }
    }
}