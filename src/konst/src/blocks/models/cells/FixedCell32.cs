//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Fixed32 : INumericCell<Fixed32,W32,uint>
    {
        internal readonly uint Data;

        [MethodImpl(Inline)]
        public static Fixed32 init(uint src)
            => new Fixed32(src);

        [MethodImpl(Inline)]
        public static Fixed32 init(byte src)
            => new Fixed32(src);

        [MethodImpl(Inline)]
        public static Fixed32 init(ushort src)
            => new Fixed32(src);

        [MethodImpl(Inline)]
        public static Fixed32 init(FixedCell8 src)
            => new Fixed32(src.Data);

        [MethodImpl(Inline)]
        public static Fixed32 init(FixedCell16 src)
            => new Fixed32(src.Data);

        [MethodImpl(Inline)]
        public static Fixed32 init(int src)
            => new Fixed32((uint)src);

        public uint Content
        {
            [MethodImpl(Inline)] get => Data;
        }

        public FixedCell16 Lo
        {
            [MethodImpl(Inline)]
            get => (ushort)Data;
        }

        public FixedCell16 Hi
        {
            [MethodImpl(Inline)]
            get => (ushort)(Data >> 16);
        }

        public Fixed32 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        Fixed32(uint x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(uint x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(int x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Fixed32 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Fixed32 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Fixed32 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Fixed32 x)
            => (ushort)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed32 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed32 x)
            => (ulong)x.Data;


        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
              => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Fixed32 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(uint src)
            => Data == src;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Fixed32 x && Equals(x);

        public static Fixed32 Empty => default;

    }
}