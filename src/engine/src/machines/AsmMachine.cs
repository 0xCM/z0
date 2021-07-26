//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static MemModels;
    using static RegModels;
    using static CpuModels;

    [ApiComplete]
    public readonly ref partial struct AsmMachine
    {
        /// <summary>
        /// 88 / r | MOV r8,r8 | Move r8 to r8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public void mov(r8 dst, r8 src)
        {

        }

        /// <summary>
        /// 89 / r |  MOV r16,r16  | Move r16 to r16
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        [MethodImpl(Inline), Op]
        public void mov(r16 dst, r16 src)
        {

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        [MethodImpl(Inline), Op]
        public void mov(r32 dst, r32 src)
        {

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r64 dst, r64 src)
        {

        }

        [MethodImpl(Inline)]
        public void mov(ref m8 dst, r8 src)
        {

        }

        [MethodImpl(Inline), Op]
        public void mov(ref m16 dst, r16 src)
        {

        }

        [MethodImpl(Inline), Op]
        public void mov(ref m32 dst, r32 src)
        {

        }

        [MethodImpl(Inline), Op]
        public void mov(ref m64 dst, r64 src)
        {

        }

        /// <summary>
        /// B0+ rb ib
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(ref r8 dst, Imm8 src)
        {

        }

        /// <summary>
        /// B8+ rw iw
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r16 dst, Imm16 src)
        {

        }

        /// <summary>
        /// B8+ rd id
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r32 dst, Imm32 src)
        {

        }

        /// <summary>
        /// REX.W + B8+ rd io
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public void mov(r64 dst, Imm64 src)
        {

        }
    }
}