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

    [ApiHost]
    public readonly struct Cmp  
    {
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<al,imm8> cmp(al dst, imm8 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r8,imm8> cmp(r8 dst, imm8 src)
        {
            return paired(dst,src);         
        }        

        /// <summary>
        /// CMP r8, r/m8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r8,r8> cmp(r8 dst, r8 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP r8, r/m8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r8,m8> cmp(r8 dst, m8 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<m8,imm8> cmp(m8 dst, imm8 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<eax,imm32> cmp(eax dst, imm32 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<rax,imm32> cmp(rax dst, imm32 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r32,r32> cmp(r32 dst, r32 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<m32,r32> cmp(m32 dst, r32 src)
        {
            return paired(dst,src);         
        }

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r64,r64> cmp(r64 dst, r64 src)
        {
            return paired(dst,src);         

        }

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public Bound<r64,m64> cmp(r64 dst, m64 src)
        {
             return paired(dst,src);         

        }
    }
}