//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a segmented bitfield indexed by enum values
    /// </summary>
    /// <remarks>
    /// The literals must define a dense monotonically increasing sequence within the integral range [0,31].
    /// In other words, there must be a bijection between the enum values and some subsequence s_k that satisifies
    /// s_i < s_{i + 1}  and s_m == s_n <=> m == n. The easiest way to satisfy these criteria is to simply
    /// create an enum where the first literal has the value 0, the second literal has the value 1 and so
    /// on as needed up to the maximum of 32 literals/values
    /// </remarks>
    public struct BitFieldSpec256<T>
        where T : unmanaged
    {
        Vector256<byte> Widths;

        [MethodImpl(Inline)]
        public BitFieldSpec256(Vector256<byte> widths)
            => Widths = widths;

        [MethodImpl(Inline)]
        public byte SegWidth(T index)
            => vcell(Widths, uint8(index));

        public byte this[T index]
        {
            [MethodImpl(Inline)]
            get => SegWidth(index);
        }
    }
}