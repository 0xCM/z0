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
        [MethodImpl(Inline), Op]
        public static rax set(ulong src,  rax dst)
            => new rax(src);

        [MethodImpl(Inline), Op]
        public static rcx set(ulong src,  rcx dst)
            => new rcx(src);

        [MethodImpl(Inline), Op]
        public static rdx set(ulong src,  rdx dst)
            => new rdx(src);

        [MethodImpl(Inline), Op]
        public static rbx set(ulong src,  rbx dst)
            => new rbx(src);

        [MethodImpl(Inline), Op]
        public static rsi set(ulong src,  rsi dst)
            => new rsi(src);

        [MethodImpl(Inline), Op]
        public static rdi set(ulong src,  rdi dst)
            => new rdi(src);

        [MethodImpl(Inline), Op]
        public static rsp set(ulong src,  rsp dst)
            => new rsp(src);

        [MethodImpl(Inline), Op]
        public static rbp set(ulong src,  rbp dst)
            => new rbp(src);
    }
}