//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using H = Hex64;
    using W = W64;
    using K = System.UInt64;

    public readonly struct Hex64 : IHexNumber<H,W,K>
    {
        public K Value {get;}

        [MethodImpl(Inline)]
        public Hex64(K offset)
            => Value = offset;

        public static W W
            => default;

        public bool IsZero
        {
             [MethodImpl(Inline)]
             get => Value == 0;
        }

        public bool IsNonZero
        {
             [MethodImpl(Inline)]
             get => Value != 0;
        }

        public Hex32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)Value;
        }

        public Hex32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)(Value >> 32);
        }

        [MethodImpl(Inline)]
        public bool Equals(H src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is H a && Equals(a);

        [MethodImpl(Inline)]
        public int CompareTo(H src)
            => Value == src.Value ? 0 : Value < src.Value ? -1 : 1;

        [MethodImpl(Inline)]
        public string Format()
            => HexFormat.format(Value, W, true);

        public override string ToString()
            => HexFormatter.format<ulong>(Value, false, true, false, false);

        public override int GetHashCode()
            => Value.GetHashCode();

        [MethodImpl(Inline)]
        public static implicit operator H(K src)
            => new H(src);

        [MethodImpl(Inline)]
        public static implicit operator K(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator H(int src)
            => new H((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator Address64(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator H(Address64 src)
            => new H(src.Location);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(H src)
            => src.Value;

        [MethodImpl(Inline)]
        public static explicit operator H(MemoryAddress src)
            => new H((uint)src.Location);

        [MethodImpl(Inline)]
        public static H operator+(H x, K y)
            => new H((K)(x.Value + y));

        [MethodImpl(Inline)]
        public static bool operator <(H a, H b)
            => a.Value < b.Value;

        [MethodImpl(Inline)]
        public static bool operator >(H a, H b)
            => a.Value > b.Value;

        [MethodImpl(Inline)]
        public static bool operator <=(H a, H b)
            => a.Value <= b.Value;

        [MethodImpl(Inline)]
        public static bool operator >=(H a, H b)
            => a.Value >= b.Value;

        [MethodImpl(Inline)]
        public static bool operator==(H x, H y)
            => x.Value == y.Value;

        [MethodImpl(Inline)]
        public static bool operator!=(H x, H y)
            => x.Value != y.Value;

        public static H Zero
        {
             [MethodImpl(Inline)]
             get => default;
        }
    }
}