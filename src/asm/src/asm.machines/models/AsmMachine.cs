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
    using static AsmImm;
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

        /// <summary>
        /// 88 / r | MOV r8,r8 | Move r8 to r8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public void mov(r8 dst, r8 src)
        {
            Regs[w8, dst.Index] = Regs[w8, src.Index];
        }

        /// <summary>
        /// 89 / r |  MOV r16,r16  | Move r16 to r16
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        [MethodImpl(Inline), Op]
        public void mov(r16 dst, r16 src)
        {
            Regs[w16, dst.Index] = Regs[w16, src.Index];
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        [MethodImpl(Inline), Op]
        public void mov(r32 dst, r32 src)
        {
            Regs[w32, dst.Index] = Regs[w32, src.Index];
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r64 dst, r64 src)
        {
            Regs[w64, dst.Index] = Regs[w64, src.Index];
        }

        [MethodImpl(Inline)]
        public void mov(ref m8 dst, r8 src)
        {
            dst = Regs[w8, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m16 dst, r16 src)
        {
            dst = Regs[w16, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m32 dst, r32 src)
        {
            dst = Regs[w32, src.Index];
        }

        [MethodImpl(Inline), Op]
        public void mov(ref m64 dst, r64 src)
        {
            dst = Regs[w64, src.Index];
        }

        /// <summary>
        /// B0+ rb ib
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(ref r8 dst, imm8 src)
        {
            Regs[w8, dst.Index] = src.Content;
        }

        /// <summary>
        /// B8+ rw iw
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r16 dst, imm16 src)
        {
            Regs[w16, dst.Index] = src.Content;
        }

        /// <summary>
        /// B8+ rd id
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r32 dst, imm32 src)
        {
            Regs[w32, dst.Index] = src.Content;
        }

        /// <summary>
        /// REX.W + B8+ rd io
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r64 dst, imm64 src)
        {
            Regs[w64, dst.Index] = src.Content;
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

        | B0+ rb ib         | MOV r8, imm8             | OI    | Valid       | Valid           | Move imm8 to r8.                                               |
        | REX + B0+ rb ib   | MOV r8 *** , imm8        | OI    | Valid       | N.E.            | Move imm8 to r8.                                               |
        | B8+ rw iw         | MOV r16, imm16           | OI    | Valid       | Valid           | Move imm16 to r16.                                             |
        | B8+ rd id         | MOV r32, imm32           | OI    | Valid       | Valid           | Move imm32 to r32.                                             |
        | REX.W + B8+ rd io | MOV r64, imm64           | OI    | Valid       | N.E.            | Move imm64 to r64.                                             |
        | C6 / 0 ib         | MOV r/m8, imm8           | MI    | Valid       | Valid           | Move imm8 to r/m8.                                             |
        | REX + C6 / 0 ib   | MOV r/m8***, imm8        | MI    | Valid       | N.E.            | Move imm8 to r/m8.                                             |
        | C7 / 0 iw         | MOV r/m16, imm16         | MI    | Valid       | Valid           | Move imm16 to r/m16.                                           |
        | C7 / 0 id         | MOV r/m32, imm32         | MI    | Valid       | Valid           | Move imm32 to r/m32.                                           |
        | REX.W + C7 / 0 id | MOV r/m64, imm32         | MI    | Valid       | N.E.            | Move imm32 sign extended to 64-bits to r/m64.                  |


    */
}