//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using Z0.Asm;
    using Z0.Asm.Dsl;
    
    partial struct AsmFx
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
        public static AsmArgs<m8,Imm8> cmp(m8 dst, Imm8 src)
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
        public static AsmArgs<m32,R32> cmp(m32 dst, R32 src)
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
        public static AsmArgs<R64,m64> cmp(R64 dst, m64 src)
            => asm.args(dst,src);         
    }
}