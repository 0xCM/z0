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
        public static R.rax set(ulong src,  R.rax dst)
            => new R.rax(src);

        [MethodImpl(Inline), Op]
        public static R.rcx set(ulong src,  R.rcx dst)
            => new R.rcx(src);

        [MethodImpl(Inline), Op]
        public static R.rdx set(ulong src,  R.rdx dst)
            => new R.rdx(src);

        [MethodImpl(Inline), Op]
        public static R.rbx set(ulong src,  R.rbx dst)
            => new R.rbx(src);

        [MethodImpl(Inline), Op]
        public static R.rsi set(ulong src,  R.rsi dst)
            => new R.rsi(src);

        [MethodImpl(Inline), Op]
        public static R.rdi set(ulong src,  R.rdi dst)
            => new R.rdi(src);

        [MethodImpl(Inline), Op]
        public static R.rsp set(ulong src,  R.rsp dst)
            => new R.rsp(src);

        [MethodImpl(Inline), Op]
        public static R.rbp set(ulong src,  R.rbp dst)
            => new R.rbp(src);
     }
}