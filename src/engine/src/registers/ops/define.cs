//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmRegs;

    using G = RegVecsG;

    // [a:RCX, b:RDX, c:R8, d:R9, f:Stack, e:Stack]
    partial struct RegVecs
    {
        [MethodImpl(Inline), Op]
        public RegVec<rcx> define(rcx r0)
            => G.define(r0);

        [MethodImpl(Inline), Op]
        public RegVec<rcx,rdx> define(rcx r0, rdx r1)
            => G.define(r0,r1);

        [MethodImpl(Inline), Op]
        public RegVec<ecx,edx> define(ecx r0, edx r1)
            => G.define(r0,r1);

        [MethodImpl(Inline), Op]
        public RegVec<rcx,rdx,r8q> define(rcx r0, rdx r1, r8q r2)
            => G.define(r0,r1,r2);

        [MethodImpl(Inline), Op]
        public RegVec<rcx,rdx,r8q,r9q> define(rcx r0, rdx r1, r8q r2, r9q r3)
            => G.define(r0, r1, r2, r3);
    }

    partial struct RegVecsG
    {
        [MethodImpl(Inline)]
        public static RegVec<R0> define<R0>(R0 r0)
            where R0 : unmanaged, IReg
                => new RegVec<R0>(r0);

        [MethodImpl(Inline)]
        public static RegVec<R0,R1> define<R0,R1>(R0 r0, R1 r1)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
                => new RegVec<R0,R1>(r0, r1);

        [MethodImpl(Inline)]
        public static RegVec<R0,R1,R2> define<R0,R1,R2>(R0 r0, R1 r1, R2 r2)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
                => new RegVec<R0,R1,R2>(r0, r1, r2);

        [MethodImpl(Inline)]
        public static RegVec<R0,R1,R2,R3> define<R0,R1,R2,R3>(R0 r0, R1 r1, R2 r2, R3 r3)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
            where R3 : unmanaged, IReg
                => new RegVec<R0,R1,R2,R3>(r0, r1, r2, r3);
    }
}