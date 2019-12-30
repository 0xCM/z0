//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines an anti-succinct data structure for bit representation
    /// </summary>
    public readonly ref partial struct BitSpan
    {
        readonly Span<bit> bits;

        [MethodImpl(Inline)]
        public static BitSpan operator +(in BitSpan head, in BitSpan tail)
            => concat(head,tail);

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

        [MethodImpl(Inline)]
        public string Format(BitFormat? fmt = null)
            => format(this, fmt);

        [MethodImpl(Inline)]
        public bool Equals(in BitSpan rhs)
            => same(this,rhs);

    }
}