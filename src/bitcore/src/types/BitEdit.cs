//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public static class BitEdit
    {
        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        public static BitEdit<T> Over<T>(ref T src)
            where T : unmanaged
                => new BitEdit<T>(ref src);
    }

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    public unsafe ref struct BitEdit<T>
        where T : unmanaged
    {
        /// <summary>
        /// The data over which the view is constructed
        /// </summary>
        public readonly Span<byte> Bytes;

        [MethodImpl(Inline)]
        public static bool operator ==(BitEdit<T> lhs, BitEdit<T> rhs)
            => lhs.Bytes.ValuesEqual(rhs.Bytes);

        [MethodImpl(Inline)]
        public static bool operator !=(BitEdit<T> lhs, BitEdit<T> rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public BitEdit(ref T src)
        {
            Bytes = new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<T>());
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
        public ref byte this[ByteSize offset]
        {
            [MethodImpl(Inline)]
            get => ref Bytes[offset];
        }

        /// <summary>
        /// Queries/Manipulates the source at the bit-level
        /// </summary>
        public bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => bit.test(Bytes[offset], pos);
            
            [MethodImpl(Inline)]
            set => Bytes[offset] = bit.set(Bytes[offset], pos, value);                
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