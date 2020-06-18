//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;
    using static BitSpans;

    public readonly ref struct BitSpan8
    {
        public static BitSpan8 Empty => default;
        
        internal readonly Span<byte> Data;

        [MethodImpl(Inline)]
        public BitSpan8(Span<byte> src)
        {
            Data = src;
        }
    }

    /// <summary>
    /// Defines an anti-succinct data structure for bit representation
    /// </summary>
    public readonly ref partial struct BitSpan
    {
        internal readonly Span<bit> bits;

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
        public BitSpan(Span<bit> bits)
            => this.bits = bits;
        
        public Span<bit> Bits
        {
            [MethodImpl(Inline)]
            get => bits;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => bits.Length;
        }

        ref bit Head
        {
            [MethodImpl(Inline)]
            get => ref head(bits);
        }

        /// <summary>
        /// Queries/Manipulates an index-identified bit
        /// </summary>
        public ref bit this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(ref Head, index);
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

        internal Span<uint> Bit32
            => bits.As<bit,uint>();

        [MethodImpl(Inline)]
        public string Format(BitFormatConfig? fmt = null)
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