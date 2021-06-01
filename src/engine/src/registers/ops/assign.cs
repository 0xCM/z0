//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Regs;

    using G = RegVecsG;

    partial struct RegVecs
    {
        [MethodImpl(Inline), Op]
        public static rax mul(RegVec<rcx,rdx> src)
            => math.mul(uint64(src.r0), uint64(src.r1));

        [MethodImpl(Inline), Op]
        public ref RegVec<rcx> assign(rcx r0, ref RegVec<rcx> dst)
            => ref G.assign(r0, ref dst);

        [MethodImpl(Inline), Op]
        public ref RegVec<rcx,rdx> assign(rcx r0, rdx r1, ref RegVec<rcx,rdx> dst)
            => ref G.assign(r0, r1, ref dst);

        [MethodImpl(Inline), Op]
        public ref RegVec<ecx,edx> assign(ecx r0, edx r1, ref RegVec<ecx,edx> dst)
            => ref G.assign(r0, r1,ref dst);
    }

    partial struct RegVecsG
    {
        [MethodImpl(Inline)]
        public static ref RegVec<R0> assign<R0>(R0 r0, ref RegVec<R0> dst)
            where R0 : unmanaged, IReg
        {
            dst.r0 = r0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref RegVec<R0,R1> assign<R0,R1>(R0 r0, R1 r1, ref RegVec<R0,R1> dst)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
        {
            dst.r0 = r0;
            dst.r1 = r1;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref RegVec<R0,R1,R2> assign<R0,R1,R2>(R0 r0, R1 r1, R2 r2, ref RegVec<R0,R1,R2> dst)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
        {
            dst.r0 = r0;
            dst.r1 = r1;
            dst.r2 = r2;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref RegVec<R0,R1,R2,R3> assign<R0,R1,R2,R3>(R0 r0, R1 r1, R2 r2, R3 r3, ref RegVec<R0,R1,R2,R3> dst)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
            where R3 : unmanaged, IReg
        {
            dst.r0 = r0;
            dst.r1 = r1;
            dst.r2 = r2;
            dst.r3 = r3;
            return ref dst;
        }
    }
}