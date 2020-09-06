//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BitSpans;

    /// <summary>
    /// Defines an anti-succinct data structure for bit representation
    /// </summary>
    public readonly ref partial struct BitSpan
    {
        internal readonly Span<bit> Data;

        [MethodImpl(Inline)]
        public static BitSpan operator +(in BitSpan head, in BitSpan tail)
            => BitSpans.concat(head,tail);

        [MethodImpl(Inline)]
        public static BitSpan operator &(in BitSpan x, in BitSpan y)
            => and(x,y);

        [MethodImpl(Inline)]
        public static BitSpan operator |(in BitSpan x, in BitSpan y)
            => or(x,y);

        [MethodImpl(Inline)]
        public static BitSpan operator ^(in BitSpan x, in BitSpan y)
            => xor(x,y);

        [MethodImpl(Inline)]
        public static BitSpan operator ~(in BitSpan x)
            => not(x);

        [MethodImpl(Inline)]
        public static bit operator ==(in BitSpan x, in BitSpan y)
            => same(x,y);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitSpan x, in BitSpan y)
            => !same(x,y);

        [MethodImpl(Inline)]
        public BitSpan(Span<bit> src)
            => Data = src;

        public Span<bit> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        ref bit Head
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        /// <summary>
        /// Queries/Manipulates an index-identified bit
        /// </summary>
        public ref bit this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Head, index);
        }

        /// <summary>
        /// Queries/Manipulates an index-identified bit
        /// </summary>
        public ref bit this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Head, index);
        }

        /// <summary>
        /// Packs a segment selection of at most 8 bits
        /// </summary>
        public byte this[int offset, int count, byte t]
        {
            [MethodImpl(Inline)]
            get => BitSpans.bitslice<byte>(this, offset, count);
        }

        /// <summary>
        /// Packs a segment selection of at most 16 bits
        /// </summary>
        public ushort this[int offset, int count, ushort t]
        {
            [MethodImpl(Inline)]
            get => BitSpans.bitslice<ushort>(this, offset, count);
        }

        /// <summary>
        /// Packs a segment selection of at most 32 bits
        /// </summary>
        public uint this[int offset, int count, uint t]
        {
            [MethodImpl(Inline)]
            get => BitSpans.bitslice<uint>(this, offset, count);
        }

        /// <summary>
        /// Packs a segment selection of at most 64 bits
        /// </summary>
        public ulong this[int offset, int count, ulong t]
        {
            [MethodImpl(Inline)]
            get => BitSpans.bitslice<ulong>(this, offset, count);
        }

        [MethodImpl(Inline)]
        public string Format(BitFormat? fmt = null)
            => format(this, fmt);

        [MethodImpl(Inline)]
        public bool Equals(in BitSpan rhs)
            => same(this, rhs);

        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object rhs)
            => throw new NotSupportedException();
    }
}