//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EventLevel : ITextual
    {
        readonly FlairKind Kind;

        [MethodImpl(Inline)]
        internal EventLevel(FlairKind flair)
            => Kind = flair;

        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator EventLevel(FlairKind src)
            => new EventLevel(src);

        [MethodImpl(Inline)]
        public static implicit operator FlairKind(EventLevel src)
            => src.Kind;
    }
}