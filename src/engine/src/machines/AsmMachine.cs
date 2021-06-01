//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmMem;
    using static Regs;
    using static Typed;

    [ApiComplete]
    public readonly ref partial struct AsmMachine
    {
        [Op]
        public static AsmMachine create()
            => new AsmMachine(new RegBank(RegBanks.create(w512,32), RegBanks.create(w64, 16)));

        readonly RegBank Regs;

        [MethodImpl(Inline)]
        internal AsmMachine(RegBank regs)
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
        public void mov(ref r8 dst, Imm8 src)
        {
            Regs[w8, dst.Index] = src.Content;
        }

        /// <summary>
        /// B8+ rw iw
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r16 dst, Imm16 src)
        {
            Regs[w16, dst.Index] = src.Content;
        }

        /// <summary>
        /// B8+ rd id
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r32 dst, Imm32 src)
        {
            Regs[w32, dst.Index] = src.Content;
        }

        /// <summary>
        /// REX.W + B8+ rd io
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r64 dst, Imm64 src)
        {
            Regs[w64, dst.Index] = src.Content;
        }
    }
}