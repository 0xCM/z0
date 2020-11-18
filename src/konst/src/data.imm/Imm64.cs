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
    public readonly struct Imm64 : IImmValue<I,W64,ulong>
    {
        public readonly ulong Data;

        public static W W => default;

        public ulong Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public Imm64(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Data, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Data);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Data == src.Data ? 0 : Data < src.Data ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is I x && Equals(x);


        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(I src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator I(ulong src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Data < b.Data;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Data > b.Data;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Data <= b.Data;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Data >= b.Data;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Data == b.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Data != b.Data;
    }
}