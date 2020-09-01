//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using H = Hex1;
    using K = Hex1Kind;

    public readonly struct Hex1 : IHexNumber<H,K>
    {
        public readonly K Value;

        [MethodImpl(Inline)]
        public Hex1(K src)
            => Value = src & KMax;

        [MethodImpl(Inline)]
        public Hex1(byte src)
            => Value = (K)src & KMax;

        public const string On = "1";

        public const string Off = "0";

        public const byte Width = 1;

        public const uint Count = 2;

        public const K KMin = K.x00;

        public const K KMax = K.x01;

        public const K KOne = K.x01;

        public static H Zero => KMin;

        public static H One => KOne;

        public static H Min => KMin;

        public static H Max => KMax;

        [MethodImpl(Inline)]
        public static implicit operator Hex1(bit src)
            => new Hex1((byte)(src ? 1 : 0));

        [MethodImpl(Inline)]
        public static implicit operator Hex1(bool src)
            => new Hex1(z.@byte(src));

        [MethodImpl(Inline)]
        public static implicit operator H(K src)
            => new H(src);

        [MethodImpl(Inline)]
        public static implicit operator K(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Hex2(Hex1 src)
            => new Hex2((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex3(Hex1 src)
            => new Hex3((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex4(Hex1 src)
            => new Hex4((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex5(Hex1 src)
            => new Hex5((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex8(Hex1 src)
            => new Hex8((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator H(byte src)
            => new H((K)src);

        [MethodImpl(Inline)]
        public static implicit operator byte(H src)
            => (byte)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator uint(H src)
            => (uint)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator ushort(H src)
            => (ushort)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator ulong(H src)
            => (ulong)src.Value;

        K IHexNumber<K>.Value
            => Value;

        [MethodImpl(Inline)]
        public bool Equals(H src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is H x && Equals(x);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Value;
        }

        public override int GetHashCode()
            => (int)Hash;

        public string Text
        {
            [MethodImpl(Inline)]
            get => Value == One ? On : Off;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}