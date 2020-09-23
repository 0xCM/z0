//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using H = Hex3;
    using K = Hex3Seq;

    public readonly struct Hex3 : IHexNumber<H,K>
    {
        public readonly K Value;

        [MethodImpl(Inline)]
        public Hex3(K src)
            => Value = src & KMax;

        [MethodImpl(Inline)]
        public Hex3(byte src)
             => Value = (K)src & KMax;

        public const byte Width = 3;

        public const uint Count = 8;

        public const K KMin = K.x00;

        public const K KMax = K.x03;

        public const K KOne = K.x01;

        public static H Zero => KMin;

        public static H One => KOne;

        public static H Min => KMin;

        public static H Max => KMax;

        [MethodImpl(Inline)]
        public static implicit operator H(K src)
            => new H(src);

        [MethodImpl(Inline)]
        public static implicit operator K(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Hex4(Hex3 src)
            => new Hex4((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex5(Hex3 src)
            => new Hex5((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex8(Hex3 src)
            => new Hex8((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex4Seq(Hex3 src)
            => (Hex4Seq)src;

        [MethodImpl(Inline)]
        public static implicit operator Hex5Seq(Hex3 src)
            => (Hex5Seq)src;

        [MethodImpl(Inline)]
        public static implicit operator Hex8Seq(Hex3 src)
            => (Hex8Seq)src;

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

        [MethodImpl(Inline)]
        public static implicit operator H(Hex1Seq src)
            => new H((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator H(Hex2Seq src)
            => new H((byte)src);

        K IHexNumber<K>.Value
            => Value;

        [MethodImpl(Inline)]
        public bool Equals(H src)
            => Value == src.Value;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Value;
        }

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is H c && Equals(c);

        public string Text
        {
            [MethodImpl(Inline)]
            get => $"{Value}";
        }

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}