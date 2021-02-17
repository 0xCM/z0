//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = W64;
    using I = Imm64;

    /// <summary>
    /// Defines a 64-bit immediate value
    /// </summary>
    [Datatype("imm64")]
    public readonly struct Imm64 : IImmediate<I,W64,ulong>
    {
        public ulong Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm64(ulong src)
            => Content = src;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Content);
        }


        public override int GetHashCode()
            => (int)Hash;

        public string Format()
            => HexFormat.format(Content, W);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Content == src.Content ? 0 : Content < src.Content ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Content == src.Content;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator ulong(I src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Cell64(I src)
            => new Cell64(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator I(ulong src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Content < b.Content;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Content > b.Content;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Content <= b.Content;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Content >= b.Content;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Content == b.Content;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Content != b.Content;
    }
}