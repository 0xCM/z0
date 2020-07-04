//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using H = Hex8;
    using K = HexKind8;

    public readonly struct Hex8 : IHexNumber<H,K>
    {                        
        public readonly K Value;
        
        [MethodImpl(Inline)]
        public Hex8(K src)
            => Value = src;

        [MethodImpl(Inline)]
        public Hex8(byte src)
            => Value = (K)src;

        public const byte Width = 8;

        public const K Min = K.x00;

        public const K Max = K.xff;

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
            => new Hex8((HexKind8)src);

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

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind2 src)
            => new H((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind3 src)
            => new H((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind4 src)
            => new H((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind5 src)
            => new H((byte)src);

        public static H Zero 
            => default;

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

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}