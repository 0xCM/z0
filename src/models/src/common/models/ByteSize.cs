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
    /// Defines size with respect to bytes
    /// </summary>
    public readonly struct ByteSize
    {
        /// <summary>
        /// Specifies a number of bytes
        /// </summary>
        public readonly int Count;

        [MethodImpl(Inline)]
        public static ByteSize Define(int count)
            => new ByteSize(count);

        [MethodImpl(Inline)]
        public static bool operator ==(ByteSize lhs, ByteSize rhs)
            => lhs.Count == rhs.Count;

        [MethodImpl(Inline)]
        public static bool operator !=(ByteSize lhs, ByteSize rhs)
            => lhs.Count != rhs.Count;

        [MethodImpl(Inline)]
        public static ByteSize operator +(ByteSize lhs, ByteSize rhs)
            => lhs.Count + rhs.Count;

        [MethodImpl(Inline)]
        public static ByteSize operator -(ByteSize lhs, ByteSize rhs)
            => lhs.Count - rhs.Count;

        [MethodImpl(Inline)]
        public static ByteSize operator *(ByteSize lhs, ByteSize rhs)
            => lhs.Count * rhs.Count;

        [MethodImpl(Inline)]
        public static ByteSize operator /(ByteSize lhs, ByteSize rhs)
            => lhs.Count / rhs.Count;

        [MethodImpl(Inline)]
        public static ByteSize operator %(ByteSize lhs, ByteSize rhs)
            => lhs.Count % rhs.Count;

        [MethodImpl(Inline)]
        public static implicit operator int(ByteSize src)
            => src.Count;

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteSize src)
            => (uint)src.Count;

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(int src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(ulong src)
            => new ByteSize((int)src);

        [MethodImpl(Inline)]
        public ByteSize(int count)
            => Count = count;

        [MethodImpl(Inline)]
        public ulong ToBits()
            => (ulong)Count * 8ul;

        public override string ToString()
            => Count.ToString();

        public override int GetHashCode()
            => Count.GetHashCode();

        public bool Equals(ByteSize rhs)
            => Count == rhs.Count;
    
        public override bool Equals(object obj)
            => obj is ByteSize ? Equals((ByteSize)obj) : false;
    }
}