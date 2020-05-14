//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class AsmExpr
    {
        /*
        | 38 / r           | CMP r/m8, r8
        | 39 / r           | CMP r/m16, r16
        | 39 / r           | CMP r/m32, r32
        | 3A / r           | CMP r8, r/m8
        | 3B / r           | CMP r16, r/m16
        | 3B / r           | CMP r32, r/m32
        | 3C ib            | CMP AL, imm8
        | 3D iw            | CMP AX, imm16
        | 3D id            | CMP EAX, imm32
        | 80 /7 ib         | CMP r/m8, imm8
        | 81 /7 iw         | CMP r/m16, imm16
        | 81 /7 id         | CMP r/m32, imm32
        | 83 /7 ib         | CMP r/m16, imm8
        | 83 /7 ib         | CMP r/m32, imm8
        | REX + 38 / r     | CMP r/m8 * , r8 *
        | REX.W + 39 / r   | CMP r/m64,r64
        | REX + 3A / r     | CMP r8 * , r/m8 *
        | REX.W + 3B / r   | CMP r64, r/m64
        | REX.W + 3D id    | CMP RAX, imm32
        | REX + 80 /7 ib   | CMP r/m8 * , imm8
        | REX.W + 81 /7 id | CMP r/m64, imm32
        | REX.W + 83 /7 ib | CMP r/m64, imm8

        */

        [Op]
        public int cmp(byte x)
            => x < byte.MaxValue ? 0x3c : -1;

        [Op]
        public int cmp(ushort x)
            => x < ushort.MaxValue ? 0x3d : -1;

        [Op]
        public int cmp(uint x)
            => x < uint.MaxValue ? 0x83 : -1;

        [Op]
        public int cmp(byte x, byte y)
            => x < y ? 0x3b : -1;

        [Op]
        public int cmp(ushort x, ushort y)
            => x < y ? 0x3b : -1;

        [Op]
        public int cmp(uint x, uint y)
            => x < y ? 0x41 : -1;

        [Op]
        public int cmp(ulong x, ulong y)
            => x < y ? 0x493b : -1;

    }
}