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
        public static R.ax set(ushort src,  R.ax dst)
            => new R.ax(src);

        [MethodImpl(Inline), Op]
        public static R.cx set(ushort src,  R.cx dst)
            => new R.cx(src);

        [MethodImpl(Inline), Op]
        public static R.dx set(ushort src,  R.dx dst)
            => new R.dx(src);

        [MethodImpl(Inline), Op]
        public static R.bx set(ushort src,  R.bx dst)
            => new R.bx(src);

        [MethodImpl(Inline), Op]
        public static R.si set(ushort src,  R.si dst)
            => new R.si(src);

        [MethodImpl(Inline), Op]
        public static R.di set(ushort src,  R.di dst)
            => new R.di(src);

        [MethodImpl(Inline), Op]
        public static R.sp set(ushort src,  R.sp dst)
            => new R.sp(src);

        [MethodImpl(Inline), Op]
        public static R.bp set(ushort src,  R.bp dst)
            => new R.bp(src);

        [MethodImpl(Inline), Op]
        public static R.r8w set(ushort src,  R.r8w dst)
            => new R.r8w(src);

        [MethodImpl(Inline), Op]
        public static R.r9w set(ushort src,  R.r9w dst)
            => new R.r9w(src);

        [MethodImpl(Inline), Op]
        public static R.r10w set(ushort src,  R.r10w dst)
            => new R.r10w(src);

        [MethodImpl(Inline), Op]
        public static R.r11w set(ushort src,  R.r11w dst)
            => new R.r11w(src);

        [MethodImpl(Inline), Op]
        public static R.r12w set(ushort src,  R.r12w dst)
            => new R.r12w(src);

        [MethodImpl(Inline), Op]
        public static R.r13w set(ushort src,  R.r13w dst)
            => new R.r13w(src);

        [MethodImpl(Inline), Op]
        public static R.r14w set(ushort src,  R.r14w dst)
            => new R.r14w(src);

        [MethodImpl(Inline), Op]
        public static R.r15w set(ushort src,  R.r15w dst)
            => new R.r15w(src); 
    }
}