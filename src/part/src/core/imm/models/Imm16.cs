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
    [Datatype("imm16")]
    public readonly struct Imm16 : IImm<I,ushort>
    {
        public ushort Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm16(ushort src)
            => Content = src;

        public ImmWidth Width => ImmWidth.W16;

        public ImmKind Kind => ImmKind.Imm16;

        public string Format()
            => HexFormat.format(W, Content);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => FastHash.calc(Content);
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

        [MethodImpl(Inline)]
        public static implicit operator ushort(I src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm<ushort>(Imm16 src)
            => new Imm<ushort>(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(I src)
            => new Cell16(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator I(ushort src)
            => new I(src);
     }
}