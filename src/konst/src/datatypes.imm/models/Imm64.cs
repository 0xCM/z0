//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W64;
    using I = Imm64;

    /// <summary>
    /// Defines a 64-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm64 : IImmValue<I,W64,ulong>
    {
        public ulong Value {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm64(ulong src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Value, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Value);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Value == src.Value ? 0 : Value < src.Value ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(I src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator I(ulong src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Value < b.Value;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Value > b.Value;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Value <= b.Value;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Value >= b.Value;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Value == b.Value;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Value != b.Value;
    }
}