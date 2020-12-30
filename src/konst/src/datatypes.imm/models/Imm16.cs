//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = W16;
    using I = Imm16;

    /// <summary>
    /// Defines a 16-bit immediate value
    /// </summary>
    [Datatype]
    public readonly struct Imm16 : IImmValue<I,W16,ushort>
    {
        public ushort Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm16(ushort src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Content, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Content);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Content == src.Content ? 0 : Content < src.Content ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Content == src.Content;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address16 ToAddress()
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator ushort(I src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator I(ushort src)
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