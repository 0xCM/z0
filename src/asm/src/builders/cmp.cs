//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm.Dsl;

    partial struct AsmBuilder
    {
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<al,Imm8> cmp(al dst, Imm8 src)
            => asm.args(dst,src);

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public static AsmArgs<M8,Imm8> cmp(M8 dst, Imm8 src)
            => asm.args(dst,src);

        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<eax,Imm32> cmp(eax dst, Imm32 src)
            => asm.args(dst,src);

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<rax,Imm32> cmp(rax dst, Imm32 src)
            => asm.args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<R32,R32> cmp(R32 dst, R32 src)
            => asm.args(dst,src);

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<M32,R32> cmp(M32 dst, R32 src)
            => asm.args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<R64,R64> cmp(R64 dst, R64 src)
            => asm.args(dst,src);

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static AsmArgs<R64,M64> cmp(R64 dst, M64 src)
            => asm.args(dst,src);
    }
}