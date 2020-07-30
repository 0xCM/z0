//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Represents the <see cref='Mnemonic.Cmp'/> instruction
    /// </summary>
    [ApiHost]
    public readonly struct Cmp
    {
        public Mnemonic Mnemonic => Mnemonic.Cmp;        
        
        /// <summary>
        /// CMP AL, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<al,Imm8> cmp(al dst, Imm8 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// CMP r/m8, imm8
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline),Op]
        public static Bound<m8,Imm8> cmp(m8 dst, Imm8 src)
            => asm.bind(dst,src);
            
        /// <summary>
        /// CMP EAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<eax,Imm32> cmp(eax dst, Imm32 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// CMP RAX, imm32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<rax,Imm32> cmp(rax dst, Imm32 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r32,r32> cmp(r32 dst, r32 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// # CMP r/m32, r32
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<m32,r32> cmp(m32 dst, r32 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,r64> cmp(r64 dst, r64 src)
            => asm.bind(dst,src);         

        /// <summary>
        /// CMP r64, r/m64
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Bound<r64,m64> cmp(r64 dst, m64 src)
            => asm.bind(dst,src);         
    }
}