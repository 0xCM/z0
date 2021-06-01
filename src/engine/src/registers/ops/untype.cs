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
    using static Typed;

    using G = RegVecsG;

    partial struct RegVecs
    {
        [MethodImpl(Inline), Op]
        public RegVec untype(RegVec<rcx,rdx,r8q,r9q> src)
            => untype(src,recover<RegKind>(Cells.alloc(w128).Bytes));

        [MethodImpl(Inline), Op]
        public RegVec untype(RegVec<rcx,rdx,r8q,r9q> src, Span<RegKind> buffer)
            => G.untype(src,buffer);
    }

    partial struct RegVecsG
    {
        [MethodImpl(Inline)]
        public static RegVec untype<R0>(RegVec<R0> src, Span<RegKind> buffer)
            where R0 : unmanaged, IReg
        {
            seek(buffer,0) = src.r0.RegKind;
            return new RegVec(slice(buffer,0,1), bytes(src));
        }

        [MethodImpl(Inline)]
        public static RegVec untype<R0,R1>(RegVec<R0,R1> src, Span<RegKind> buffer)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
        {
            seek(buffer,0) = src.r0.RegKind;
            seek(buffer,1) = src.r1.RegKind;
            return new RegVec(slice(buffer,0,2), bytes(src));
        }

        [MethodImpl(Inline)]
        public static RegVec untype<R0,R1,R2>(RegVec<R0,R1,R2> src, Span<RegKind> buffer)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
        {
            seek(buffer,0) = src.r0.RegKind;
            seek(buffer,1) = src.r1.RegKind;
            seek(buffer,2) = src.r2.RegKind;
            return new RegVec(slice(buffer,0,3), bytes(src));
        }

        [MethodImpl(Inline)]
        public static RegVec untype<R0,R1,R2,R3>(RegVec<R0,R1,R2,R3> src, Span<RegKind> buffer)
            where R0 : unmanaged, IReg
            where R1 : unmanaged, IReg
            where R2 : unmanaged, IReg
            where R3 : unmanaged, IReg
        {
            seek(buffer,0) = src.r0.RegKind;
            seek(buffer,1) = src.r1.RegKind;
            seek(buffer,2) = src.r2.RegKind;
            seek(buffer,3) = src.r2.RegKind;
            return new RegVec(slice(buffer,0,4), bytes(src));
        }
    }
}