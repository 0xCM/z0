//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ContentName : ITextual
    {
        readonly string Value;

        [MethodImpl(Inline)]
        internal ContentName(string src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ContentName(string src)
            => new ContentName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ContentName src)
            => src.Value ?? EmptyString;
    }
}