//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

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
            => Bind.cmp(dst,src);         

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public static Bound<m8,imm8> cmp(m8 dst, imm8 src)
            => Bind.cmp(dst,src);
            
        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<eax,imm32> cmp(eax dst, imm32 src)
            => Bind.cmp(dst,src);         

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<rax,imm32> cmp(rax dst, imm32 src)
            => Bind.cmp(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r32,r32> cmp(r32 dst, r32 src)
            => Bind.cmp(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<m32,r32> cmp(m32 dst, r32 src)
            => Bind.cmp(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,r64> cmp(r64 dst, r64 src)
            => Bind.cmp(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,m64> cmp(r64 dst, m64 src)
            => Bind.cmp(dst,src);         
    }
}