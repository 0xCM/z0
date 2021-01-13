//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline), Op]
        public rax set(ulong src, rax dst)
            => new rax(src);

        [MethodImpl(Inline), Op]
        public rcx set(ulong src, rcx dst)
            => new rcx(src);

        [MethodImpl(Inline), Op]
        public rdx set(ulong src, rdx dst)
            => new rdx(src);

        [MethodImpl(Inline), Op]
        public rbx set(ulong src, rbx dst)
            => new rbx(src);

        [MethodImpl(Inline), Op]
        public rsi set(ulong src, rsi dst)
            => new rsi(src);

        [MethodImpl(Inline), Op]
        public rdi set(ulong src, rdi dst)
            => new rdi(src);

        [MethodImpl(Inline), Op]
        public rsp set(ulong src, rsp dst)
            => new rsp(src);

        [MethodImpl(Inline), Op]
        public rbp set(ulong src, rbp dst)
            => new rbp(src);
    }
}