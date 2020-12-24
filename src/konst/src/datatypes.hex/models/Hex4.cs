//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using H = Hex4;
    using K = Hex4Seq;
    using W = W4;

    public readonly struct Hex4 : IHexNumber<H,W,K>
    {
        public K Value {get;}

        [MethodImpl(Inline)]
        public Hex4(K src)
            => Value = src & KMax;

        [MethodImpl(Inline)]
        public Hex4(byte src)
             => Value = (K)src & KMax;

        public const byte Width = 4;

        public const uint Count = 16;

        public const K KMin = K.x00;

        public const K KMax = K.x0F;

        public const K KOne = K.x01;

        public static H Zero => KMin;

        public static H One => KOne;

        public static H Min => KMin;

        public static H Max => KMax;

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

        [MethodImpl(Inline)]
        public static implicit operator H(K src)
            => new H(src);

        [MethodImpl(Inline)]
        public static implicit operator K(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator H(byte src)
            => new H((K)src);

        [MethodImpl(Inline)]
        public static implicit operator Hex5(Hex4 src)
            => new Hex5((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex8(Hex4 src)
            => new Hex8((byte)src.Value);

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

        [MethodImpl(Inline)]
        public static implicit operator H(Hex3Seq src)
            => new H((byte)src);
    }
}