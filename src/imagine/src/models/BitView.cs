//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    public unsafe ref struct BitView<T>
        where T : unmanaged
    {
        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        public readonly ReadOnlySpan<byte> Bytes;

        [MethodImpl(Inline)]
        public static bool operator ==(BitView<T> lhs, BitView<T> rhs)
            => lhs.Bytes.SequenceEqual(rhs.Bytes);

        [MethodImpl(Inline)]
        public static bool operator !=(BitView<T> lhs, BitView<T> rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public BitView(in T src)
        {
            Bytes =  As.bytes(src);
        }

        /// <summary>
        /// The total number of represented bytes
        /// </summary>
        public ByteSize ByteCount
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        /// <summary>
        /// The total number of represented bits
        /// </summary>
        public BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => (BitSize)ByteCount;
        }
        
        /// <summary>
        /// Selects an offset-identified byte
        /// </summary>
        public ref readonly byte this[ByteSize offset]
        {
            [MethodImpl(Inline)]
            get => ref Bytes[offset];
        }

        /// <summary>
        /// Queries/Manipulates the source at the bit-level
        /// </summary>
        public Bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => BitTest.test(Bytes[offset], pos);
        }

        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst, int offset = 0)
            => Bytes.CopyTo(dst,offset);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}