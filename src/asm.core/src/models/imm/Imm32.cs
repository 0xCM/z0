//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using W = W32;
    using I = Imm32;

    /// <summary>
    /// Defines a 32-bit immediate value
    /// </summary>
    [DataType("imm32")]
    public readonly struct Imm32 : IImm<I,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public Imm32(uint src)
            => Content = src;

        public ImmWidth Width => ImmWidth.W32;

        public ImmKind Kind => ImmKind.Imm32;

        public string Format()
            => HexFormatter.format(W, Content);

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
        public Address32 ToAddress()
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
        public static implicit operator uint(I src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm<uint>(I src)
            => new Imm<uint>(src);

        [MethodImpl(Inline)]
        public static implicit operator I(uint src)
            => new I(src);
        public static W W => default;
    }
}