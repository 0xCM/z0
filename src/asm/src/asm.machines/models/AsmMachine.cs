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
    using static AsmMem;
    using static AsmRegs;
    using static AsmRegBanks;

    [ApiComplete]
    public readonly ref partial struct AsmMachine
    {
        readonly AsmRegBank Regs;

        [MethodImpl(Inline)]
        internal AsmMachine(AsmRegBank regs)
        {
            Regs = regs;
        }

        [MethodImpl(Inline)]
        public void mov(r8 dst, r8 src)
        {
            Regs[w8, dst.Index] = Regs[w8, src.Index];
        }

        [MethodImpl(Inline)]
        public void mov(ref m8 dst, r8 src)
        {
            dst = Regs[w8, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(r16 dst, r16 src)
        {
            Regs[w16, dst.Index] = Regs[w16, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m16 dst, r16 src)
        {
            dst = Regs[w16, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(r32 dst, r32 src)
        {
            Regs[w32, dst.Index] = Regs[w32, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m32 dst, r32 src)
        {
            dst = Regs[w32, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(r64 dst, r64 src)
        {
            Regs[w64, dst.Index] = Regs[w64, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m64 dst, r64 src)
        {
            dst = Regs[w64, src.Index];
        }
    }

    /*

        | 88 / r            | MOV r/m8,r8              | Move r8 to r/m8.                                               |
        | REX + 88 / r      | MOV r/m8 ***, r8 ***     | Move r8 to r/m8.                                               |
        | 89 / r            | MOV r/m16,r16            | Move r16 to r/m16.                                             |
        | 89 / r            | MOV r/m32,r32            | Move r32 to r/m32.                                             |
        | REX.W + 89 / r    | MOV r/m64,r64            | Move r64 to r/m64.                                             |
        | 8A / r            | MOV r8,r/m8              | Move r/m8 to r8.                                               |
        | REX + 8A / r      | MOV r8***,r/m8***        | Move r/m8 to r8.                                               |
        | 8B / r            | MOV r16,r/m16            | Move r/m16 to r16.                                             |
        | 8B / r            | MOV r32,r/m32            | Move r/m32 to r32.                                             |
        | REX.W + 8B / r    | MOV r64,r/m64            | Move r/m64 to r64.                                             |


    */
}