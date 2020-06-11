//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using R = Dsl;

    partial class asm
    {
        [MethodImpl(Inline), Op]
        public static R.eax set(Fixed32 src,  R.eax dst)
            => new R.eax(src);

        [MethodImpl(Inline), Op]
        public static R.ecx set(Fixed32 src,  R.ecx dst)
            => new R.ecx(src);

        [MethodImpl(Inline), Op]
        public static R.edx set(Fixed32 src,  R.edx dst)
            => new R.edx(src);

        [MethodImpl(Inline), Op]
        public static R.ebx set(Fixed32 src,  R.ebx dst)
            => new R.ebx(src);

        [MethodImpl(Inline), Op]
        public static R.esi set(Fixed32 src,  R.esi dst)
            => new R.esi(src);

        [MethodImpl(Inline), Op]
        public static R.edi set(Fixed32 src,  R.edi dst)
            => new R.edi(src);

        [MethodImpl(Inline), Op]
        public static R.esp set(Fixed32 src,  R.esp dst)
            => new R.esp(src);

        [MethodImpl(Inline), Op]
        public static R.ebp set(Fixed32 src,  R.ebp dst)
            => new R.ebp(src);
 

        [MethodImpl(Inline), Op]
        public static R.r8d set(Fixed32 src,  R.r8d dst)
            => new R.r8d(src);

        [MethodImpl(Inline), Op]
        public static R.r9d set(Fixed32 src,  R.r9d dst)
            => new R.r9d(src);

        [MethodImpl(Inline), Op]
        public static R.r10d set(Fixed32 src,  R.r10d dst)
            => new R.r10d(src);

        [MethodImpl(Inline), Op]
        public static R.r11d set(Fixed32 src,  R.r11d dst)
            => new R.r11d(src);

        [MethodImpl(Inline), Op]
        public static R.r12d set(Fixed32 src,  R.r12d dst)
            => new R.r12d(src);

        [MethodImpl(Inline), Op]
        public static R.r13d set(Fixed32 src,  R.r13d dst)
            => new R.r13d(src);

        [MethodImpl(Inline), Op]
        public static R.r14d set(Fixed32 src,  R.r14d dst)
            => new R.r14d(src);

        [MethodImpl(Inline), Op]
        public static R.r15d set(Fixed32 src,  R.r15d dst)
            => new R.r15d(src);  
    }
}