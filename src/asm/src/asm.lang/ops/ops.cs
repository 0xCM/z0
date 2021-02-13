//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;
    using static AsmMem;
    using static AsmImm;

    partial struct asm
    {
        /// <summary>
        /// AL, imm8
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<al,imm8> ops(al dst, imm8 src)
            => args(dst,src);

        /// <summary>
        /// r/m8, imm8
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline),Op]
        public Args<m8,imm8> ops(m8 dst, imm8 src)
            => args(dst,src);

        /// <summary>
        /// EAX, imm32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<eax,imm32> ops(eax dst, imm32 src)
            => args(dst,src);

        /// <summary>
        /// RAX, imm32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<rax,imm32> ops(rax dst, imm32 src)
            => args(dst,src);

        /// <summary>
        /// r/m32, r32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<R32,R32> ops(R32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// r/m32, r32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<m32,R32> ops(m32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// r64, r/m64
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<R64,R64> ops(R64 dst, R64 src)
            => args(dst,src);

        /// <summary>
        /// r64, r/m64
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<R64,m64> ops(R64 dst, m64 src)
            => args(dst,src);
    }
}