//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using H = Hex2;
    using K = HexKind2;

    public readonly struct Hex2 : IHexNumber<H,K>
    {                
        public readonly K Value;

        [MethodImpl(Inline)]
        public Hex2(K src)
            => Value = src & Max;

        [MethodImpl(Inline)]
        public Hex2(byte src)
            => Value = (K)src & Max;

        public const byte Width = 2;

        public const K Min = K.x00;

        public const K Max = K.x03;
        
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
        public static implicit operator Hex3(Hex2 src)
            => new Hex3((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex4(Hex2 src)
            => new Hex4((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex5(Hex2 src)
            => new Hex5((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex8(Hex2 src)
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

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind1 src)
            => new H((byte)src);

        public static H Zero 
            => default;

        K IHexNumber<K>.Value 
            => Value;

        [MethodImpl(Inline)]
        public bool Equals(H src)
            => Value == src.Value;


        public override bool Equals(object src)
            => src is H c && Equals(c);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Value;
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}