//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    public unsafe ref struct BitEditor<T>
        where T : unmanaged
    {
        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        readonly Span<byte> Data;

        [MethodImpl(Inline)]
        public BitEditor(in T src)
            => Data = @bytes(src);

        /// <summary>
        /// The total number of represented bytes
        /// </summary>
        public ByteSize ByteCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
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
        /// Queries/Manipulates the source at the bit-level
        /// </summary>
        public bit this[ByteSize offset, byte pos]
        {
            [MethodImpl(Inline)]
            get => bit.test(Data[offset], pos);

            [MethodImpl(Inline)]
            set => Data[offset] = bit.set(Data[offset], pos, value);
        }


        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public static bool operator ==(BitEditor<T> lhs, BitEditor<T> rhs)
            => lhs.Data.ValuesEqual(rhs.Data);

        [MethodImpl(Inline)]
        public static bool operator !=(BitEditor<T> lhs, BitEditor<T> rhs)
            => !(lhs == rhs);
    }
}