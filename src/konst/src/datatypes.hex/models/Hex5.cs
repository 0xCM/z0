//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using H = Hex5;
    using K = Hex5Seq;
    using W = W5;

    public readonly struct Hex5 : IHexNumber<H,W,K>
    {
        public readonly K Value;

        [MethodImpl(Inline)]
        public Hex5(K src)
             => Value = src & KMax;

        [MethodImpl(Inline)]
        public Hex5(byte src)
            => Value = (K)src & KMax;

        public const byte Width = 5;

        public const uint Count = 32;

        public const K KMin = K.x00;

        public const K KMax = K.x1f;

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