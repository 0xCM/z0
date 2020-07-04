//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using H = Hex5;
    using K = HexKind5;

    public readonly struct Hex5 : IHexNumber<H,K>
    {                
        public readonly K Value;

        [MethodImpl(Inline)]
        public Hex5(K src)
             => Value = src & Max;

        [MethodImpl(Inline)]
        public Hex5(byte src)
            => Value = (K)src & Max;

        public const byte Width = 5;

        public const K Min = K.x00;

        public const K Max = K.x1f;

        public string Text
        {
            [MethodImpl(Inline)]
            get => $"{Value}";
        }


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

        public static H Zero 
            => default;

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

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}