//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static X86Registers;

    partial struct AsmSemantic
    {
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<al,Imm8> cmp(al dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public Args<Mem8,Imm8> cmp(Mem8 dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<eax,Imm32> cmp(eax dst, Imm32 src)
            => args(dst,src);

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<rax,Imm32> cmp(rax dst, Imm32 src)
            => args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<R32,R32> cmp(R32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<Mem32,R32> cmp(Mem32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<R64,R64> cmp(R64 dst, R64 src)
            => args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Args<R64,Mem64> cmp(R64 dst, Mem64 src)
            => args(dst,src);
    }
}