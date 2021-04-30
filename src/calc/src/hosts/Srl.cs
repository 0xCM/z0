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
        [Closures(Integers), Srl]
        public readonly struct Srl<T> : IUnaryImm8Op<T>, ISpanShift<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, byte count)
                => gmath.srl(a, count);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => Calcs.srl(src, count, dst);
        }

        [Closures(Integers), Srlv]
        public readonly struct Srlv<T> : IVarSpanShift<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => Calcs.srlv(src,counts,dst);
        }

        [Closures(Integers), Srl]
        public readonly struct Srl128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
                => ref zip(a, count, dst, Calcs.vsrl<T>(n128));
        }

        [Closures(Integers), Srl]
        public readonly struct Srl256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
                => ref zip(a, count, dst, Calcs.vsrl<T>(n256));
        }
    }
}