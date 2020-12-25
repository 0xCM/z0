//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies data size in bytes
    /// </summary>
    [ApiType, Datatype]
    public readonly struct ByteSize : IDataType<ulong>
    {
        [MethodImpl(Inline)]
        public static string format(ByteSize src)
            => src.Content == 0 ? "0" : src.Content.ToString("#,#");

        /// <summary>
        /// Specifies a byte count
        /// </summary>
        public ulong Content {get;}

        [MethodImpl(Inline)]
        public ByteSize(int count)
            => Content = (ulong)count;

        [MethodImpl(Inline)]
        public ByteSize(long count)
            => Content = (ulong)count;

        [MethodImpl(Inline)]
        public ByteSize(uint count)
            => Content = count;

        [MethodImpl(Inline)]
        public ByteSize(ulong count)
            => Content = count;

        public ulong Bits
        {
            [MethodImpl(Inline)]
            get => Content*8;
        }

        [MethodImpl(Inline),Ignore]
        public string Format(string pattern)
            => format(this);

        [MethodImpl(Inline),Ignore]
        public string Format()
            => Content == 0 ? "0" : Format("#,#");

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public bool Equals(ByteSize src)
            => Content == src.Content;

        public override bool Equals(object obj)
            => obj is ByteSize ? Equals((ByteSize)obj) : false;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content != 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Content != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(sbyte src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(byte src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(short src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(ushort src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(int src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(uint src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(ulong src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator long(ByteSize src)
            => (long)src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(long src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator int(ByteSize src)
            => (int)src.Content;

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteSize src)
            => (uint)src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ulong(ByteSize src)
            => src.Content;

        [MethodImpl(Inline)]
        public static explicit operator ByteSize(DataWidth src)
            => new ByteSize((ulong)src/8);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(ByteSize src)
            => (IntPtr)src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(IntPtr src)
            => new ByteSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(TypeWidth src)
            => new ByteSize((ulong)src/8);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(VectorWidth src)
            => new ByteSize((ulong)src/8);

        [MethodImpl(Inline)]
        public static bool operator ==(ByteSize a, ByteSize b)
            => a.Content == b.Content;

        [MethodImpl(Inline)]
        public static bool operator !=(ByteSize a, ByteSize b)
            => a.Content != b.Content;

        [MethodImpl(Inline)]
        public static ByteSize operator +(ByteSize a, ByteSize b)
            => a.Content + b.Content;

        [MethodImpl(Inline)]
        public static ByteSize operator -(ByteSize a, ByteSize b)
            => a.Content - b.Content;

        [MethodImpl(Inline)]
        public static ByteSize operator *(ByteSize a, ByteSize b)
            => a.Content * b.Content;

        [MethodImpl(Inline)]
        public static ByteSize operator /(ByteSize a, ByteSize b)
            => a.Content/b.Content;

        [MethodImpl(Inline)]
        public static ByteSize operator %(ByteSize a, ByteSize b)
            => a.Content % b.Content;

        public static ByteSize Empty
            => default;

        public static ByteSize Zero
            => default;
    }
}