//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(Integers), Sll]
        public readonly struct Sll<T> : IUnaryImm8Op<T>, ISpanShift<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset)
                => gmath.sll(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => Calcs.sll(src,count,dst);
        }

        [Closures(Integers), Sllv]
        public readonly struct Sllv<T> : IVarSpanShift<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => Calcs.sllv(src,counts,dst);
        }


        [Closures(Integers), Sll]
        public readonly struct Sll128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
                => ref zip(a, count, dst, VSvc.vsll<T>(n128));
        }

        [Closures(Integers), Sll]
        public readonly struct Sll256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
                => ref zip(a, count, dst, VSvc.vsll<T>(n256));
        }
    }
}