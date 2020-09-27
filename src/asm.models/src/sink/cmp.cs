//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static AsmRegisters;

    partial struct AsmSink
    {
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<al,Imm8> cmp(al dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public AsmArgs<M8,Imm8> cmp(M8 dst, Imm8 src)
            => args(dst,src);

        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<eax,Imm32> cmp(eax dst, Imm32 src)
            => args(dst,src);

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<rax,Imm32> cmp(rax dst, Imm32 src)
            => args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<R32,R32> cmp(R32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<M32,R32> cmp(M32 dst, R32 src)
            => args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<R64,R64> cmp(R64 dst, R64 src)
            => args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public AsmArgs<R64,M64> cmp(R64 dst, M64 src)
            => args(dst,src);
    }
}