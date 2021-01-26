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
    using static asm;

    [ApiHost]
    public readonly partial struct AsmOperands
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// AL, imm8
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<al,Imm8> ops(al dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// r/m8, imm8
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline),Op]
        public Args<MemOp8,Imm8> ops(MemOp8 dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// EAX, imm32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<eax,Imm32> ops(eax dst, Imm32 src)
            => args(dst,src);

        /// <summary>
        /// RAX, imm32
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public Args<rax,Imm32> ops(rax dst, Imm32 src)
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
        public Args<MemOp32,R32> ops(MemOp32 dst, R32 src)
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
        public Args<R64,MemOp64> ops(R64 dst, MemOp64 src)
            => args(dst,src);
    }
}