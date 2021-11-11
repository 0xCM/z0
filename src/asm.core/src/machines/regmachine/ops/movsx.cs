//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.X86
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Asm.AsmOperands;

    partial class RegMachine
    {
        [MethodImpl(Inline), Op]
        public void movsx(r16 a, r8 b)
        {
            ref readonly var src = ref reg8(b);
            ref var dst = ref reg16(a);
            if(bit.test(src,7))
                dst = (ushort)((ushort)0b11111111_00000000 | (ushort)src);
            else
                dst = (ushort)src;
        }
    }
}