//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = W32;
    using I = Imm32;

    /// <summary>
    /// Defines a 32-bit immediate value
    /// </summary>
    [Datatype]
    public readonly struct Imm32 : IImmediate<I,W32,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public Imm32(uint src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Content, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Content);
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
        public static implicit operator uint(I src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator I(uint src)
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

        public static W W => default;
    }
}