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
        public ulong Storage {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm64(ulong src)
            => Storage = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Storage, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Storage);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Storage == src.Storage ? 0 : Storage < src.Storage ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Storage;

        [MethodImpl(Inline)]
        public static implicit operator ulong(I src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator I(ulong src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Storage < b.Storage;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Storage > b.Storage;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Storage <= b.Storage;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Storage >= b.Storage;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Storage == b.Storage;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Storage != b.Storage;
    }
}