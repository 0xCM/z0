//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexKind;

    using H = Hex8;
    using K = HexKind;

    public readonly struct Hex8
    {                        
        public const ushort Width = 8;

        public const K Min = x00;

        public const K Max = xff;

        readonly K Value;
        
        [MethodImpl(Inline), Op]
        public static ref readonly H view(in byte src)
            => ref view<byte,H>(src);

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
        public static implicit operator H(byte src)
            => new Hex8((HexKind)src);

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

        [MethodImpl(Inline)]
        public Hex8(K src)
        {
            Value = src & Max;
        }

        [MethodImpl(Inline)]
        public Hex8(byte src)
        {
             Value = (K)src & Max;
        }        

        public static H Zero 
            => default;

        [MethodImpl(Inline)]
        internal static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));                
    }
}