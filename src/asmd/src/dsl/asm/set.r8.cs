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
        public static R.al set(Fixed8 src,  R.al dst)
            => new R.al(src);

        [MethodImpl(Inline), Op]
        public static R.cl set(Fixed8 src,  R.cl dst)
            => new R.cl(src);

        [MethodImpl(Inline), Op]
        public static R.dl set(Fixed8 src,  R.dl dst)
            => new R.dl(src);

        [MethodImpl(Inline), Op]
        public static R.bl set(Fixed8 src,  R.bl dst)
            => new R.bl(src);

        [MethodImpl(Inline), Op]
        public static R.sil set(Fixed8 src,  R.sil dst)
            => new R.sil(src);

        [MethodImpl(Inline), Op]
        public static R.dil set(Fixed8 src,  R.dil dst)
            => new R.dil(src);

        [MethodImpl(Inline), Op]
        public static R.spl set(Fixed8 src,  R.spl dst)
            => new R.spl(src);

        [MethodImpl(Inline), Op]
        public static R.bpl set(Fixed8 src,  R.bpl dst)
            => new R.bpl(src);

        [MethodImpl(Inline), Op]
        public static R.r8b set(Fixed8 src,  R.r8b dst)
            => new R.r8b(src);

        [MethodImpl(Inline), Op]
        public static R.r9b set(Fixed8 src,  R.r9b dst)
            => new R.r9b(src);

        [MethodImpl(Inline), Op]
        public static R.r10b set(Fixed8 src,  R.r10b dst)
            => new R.r10b(src);

        [MethodImpl(Inline), Op]
        public static R.r11b set(Fixed8 src,  R.r11b dst)
            => new R.r11b(src);

        [MethodImpl(Inline), Op]
        public static R.r12b set(Fixed8 src,  R.r12b dst)
            => new R.r12b(src);

        [MethodImpl(Inline), Op]
        public static R.r13b set(Fixed8 src,  R.r13b dst)
            => new R.r13b(src);

        [MethodImpl(Inline), Op]
        public static R.r14b set(Fixed8 src,  R.r14b dst)
            => new R.r14b(src);

        [MethodImpl(Inline), Op]
        public static R.r15b set(Fixed8 src,  R.r15b dst)
            => new R.r15b(src);
    }
}