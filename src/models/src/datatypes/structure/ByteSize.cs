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
    /// Specifies data size in bytes
    /// </summary>
    public readonly struct ByteSize
    {
        /// <summary>
        /// Specifies a byte count
        /// </summary>
        public readonly uint Count;
        
        [MethodImpl(Inline)]
        public static ByteSize Define(int count)
            => new ByteSize(count);

        [MethodImpl(Inline)]
        public static ByteSize init(uint count)
            => new ByteSize(count);

        [MethodImpl(Inline)]
        public static implicit operator int(ByteSize src)
            => (int)src.Count;

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteSize src)
            => (uint)src.Count;

        [MethodImpl(Inline)]
        public static explicit operator ByteSize(DataWidth src)
            => new ByteSize((uint)src/8);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(TypeWidth src)
            => new ByteSize((uint)src/8);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(VectorWidth src)
            => new ByteSize((uint)src/8);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(int src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(ulong src)
            => new ByteSize((int)src);

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
        public ByteSize(int count)
            => Count = (uint)count;

        [MethodImpl(Inline)]
        public ByteSize(uint count)
            => Count = count;

        public BitSize Bits
        {
            [MethodImpl(Inline)]
            get => Count/8;
        }


        public override string ToString()
            => Count.ToString();

        public override int GetHashCode()
            => Count.GetHashCode();

        public bool Equals(ByteSize rhs)
            => Count == rhs.Count;
    
        public override bool Equals(object obj)
            => obj is ByteSize ? Equals((ByteSize)obj) : false;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Count != 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Count != 0;
        }

        public static ByteSize Empty 
            => default;
    }
}