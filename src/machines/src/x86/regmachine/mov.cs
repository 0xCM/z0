//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.X86
{
    using System;
    using System.Runtime.CompilerServices;

    using Asm;

    using static Root;
    using static core;
    using static Asm.AsmOperands;

    partial class RegMachine
    {
        [MethodImpl(Inline), Op]
        public void mov(r8 a, r8 b)
            => reg8(a.Index) = reg8(b.Index);

        [MethodImpl(Inline), Op]
        public void mov(r16 a, r16 b)
            => reg16(a.Index) = reg16(b.Index);

        [MethodImpl(Inline), Op]
        public void mov(r32 a, r32 b)
            => reg32(a.Index) = reg32(b.Index);

        [MethodImpl(Inline), Op]
        public void mov(r64 a, r64 b)
            => reg64(a.Index) = reg64(b.Index);
    }
}