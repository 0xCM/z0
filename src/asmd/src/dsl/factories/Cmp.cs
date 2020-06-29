//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static asm;

    [ApiHost]
    public readonly struct Cmp  
    {
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<al,imm8> cmp(al dst, imm8 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public static Bound<m8,imm8> cmp(m8 dst, imm8 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP r8, r/m8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r8,m8> cmp(r8 dst, m8 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<eax,imm32> cmp(eax dst, imm32 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<rax,imm32> cmp(rax dst, imm32 src)
            => bind(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r32,r32> cmp(r32 dst, r32 src)
            => bind(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<m32,r32> cmp(m32 dst, r32 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,r64> cmp(r64 dst, r64 src)
            => bind(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,m64> cmp(r64 dst, m64 src)
            => bind(dst,src);         

    }


    readonly struct CmpG
    {
        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Bound<r8<R>,imm8> cmp<R>(r8<R> dst, imm8 src)
            where R : unmanaged, IRegOp8
                => bind(dst,src);

        [MethodImpl(Inline)]
        public static Bound<r8<R>,r8<S>> cmp<R,S>(r8<R> dst, r8<S> src)
            where R : unmanaged, IRegOp8
            where S : unmanaged, IRegOp8
                => bind(dst,src);


        [MethodImpl(Inline),Op]
        public static Bound<M,imm8> cmp<M>(M dst, imm8 src)
            where M : unmanaged, IMemOp8
                => bind(dst,src);         

        [MethodImpl(Inline)]
        public static Bound<R,S> cmp<R,S>(R dst, S src)
            where R : unmanaged, IOperand
            where S : unmanaged, IOperand
                => bind(dst,src);

    }
}