//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FixedCell8 : INumericCell<FixedCell8,W8,byte>
    {
        internal readonly byte Data;

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static FixedCell8 From(byte src)
            => new FixedCell8(src);

        [MethodImpl(Inline)]
        public static FixedCell8 From(sbyte src)
            => new FixedCell8((byte)src);

        [MethodImpl(Inline)]
        public static FixedCell8 From(int src)
            => new FixedCell8((byte)(sbyte)src);

        [MethodImpl(Inline)]
        public static FixedCell8 From(uint src)
            => new FixedCell8((byte)src);

        public FixedCell8 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        FixedCell8(byte x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator byte(FixedCell8 src)
            => (byte)src.Data;

        [MethodImpl(Inline)]
        public static implicit operator FixedCell8(byte src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell8(sbyte x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell16(FixedCell8 x)
            => FixedCell16.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(FixedCell8 x)
            => Fixed32.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell64(FixedCell8 x)
            => FixedCell64.From(x.Data);

        [MethodImpl(Inline)]
        public static explicit operator FixedCell8(int x)
            => new FixedCell8((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator FixedCell8(uint x)
            => new FixedCell8((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(FixedCell8 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(FixedCell8 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(FixedCell8 x)
            => (uint)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(FixedCell8 x)
            => (long)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(FixedCell8 x)
            => (ulong)x.Data;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
              => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(FixedCell8 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(byte src)
            => Data == src;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is FixedCell8 x && Equals(x);

        public static FixedCell8 Empty => default;
    }
}