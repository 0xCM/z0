//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexKind3;

    using H = Hex3;
    using K = HexKind3;

    public readonly struct Hex3
    {                
        public const ushort Width = 3;

        public const K Min = x0;

        public const K Max = x3;

        readonly K Value;
        
        [MethodImpl(Inline)]
        public static ref readonly H view(in byte src)
            => ref Hex8.view<byte,H>(src);

        public string Text
        {
            [MethodImpl(Inline)]
            get => $"{Value}";
        }

        [MethodImpl(Inline)]
        public bool Equals(H src)
            => Value == src.Value;

        public override int GetHashCode()
            => (int)Value;

        public override bool Equals(object src)
            => src is H c && Equals(c);

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
        public static implicit operator Hex4(Hex3 src)
            => new Hex4((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex5(Hex3 src)
            => new Hex5((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Hex8(Hex3 src)
            => new Hex8((byte)src.Value);

        [MethodImpl(Inline)]
        public static implicit operator HexKind4(Hex3 src)
            => (HexKind4)src;

        [MethodImpl(Inline)]
        public static implicit operator HexKind5(Hex3 src)
            => (HexKind5)src;

        [MethodImpl(Inline)]
        public static implicit operator HexKind(Hex3 src)
            => (HexKind)src;

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

        [MethodImpl(Inline)]
        public static implicit operator H(HexKind2 src)
            => new H((byte)src);

        [MethodImpl(Inline)]
        public Hex3(K src)
        {
            Value = src & Max;
        }

        [MethodImpl(Inline)]
        public Hex3(byte src)
        {
            Value = (K)src & Max;
        }        

        public static H Zero 
            => default;
    }
}