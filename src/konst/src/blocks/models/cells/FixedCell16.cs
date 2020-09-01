//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FixedCell16 : INumericCell<FixedCell16,W16,ushort>
    {
        internal readonly ushort Data;

        public ushort Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public FixedCell8 Lo
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        public FixedCell8 Hi
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 8);
        }

        public FixedCell16 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public static FixedCell16 From(byte src)
            => new FixedCell16(src);

        [MethodImpl(Inline)]
        public static FixedCell16 From(ushort src)
            => new FixedCell16(src);


        [MethodImpl(Inline)]
        public static FixedCell16 From(FixedCell8 src)
            => new FixedCell16(src.Data);

        [MethodImpl(Inline)]
        public static FixedCell16 From(short src)
            => new FixedCell16((ushort)src);

        [MethodImpl(Inline)]
        public static FixedCell16 From(int src)
            => new FixedCell16((ushort)(short)src);

        [MethodImpl(Inline)]
        public static FixedCell16 From(uint src)
            => new FixedCell16((ushort)src);

        [MethodImpl(Inline)]
        FixedCell16(ushort x)
            => Data = x;

        [MethodImpl(Inline)]
        public static implicit operator ushort(FixedCell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator uint(FixedCell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(FixedCell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator FixedCell16(ushort x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell16(FixedCell8 x)
            => From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(FixedCell16 x)
            => Fixed32.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell64(FixedCell16 x)
            => FixedCell64.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell16(byte x)
            => From((ushort)x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell16(short x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator FixedCell16(int x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator FixedCell16(uint x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(FixedCell16 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(FixedCell16 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(FixedCell16 x)
            => (short)x.Data;


        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(FixedCell16 src)
            => Data == src.Data;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => Data == src;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is FixedCell16 x && Equals(x);


        public static FixedCell16 Empty
            => default(FixedCell16);

   }
}