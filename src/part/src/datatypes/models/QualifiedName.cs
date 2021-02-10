//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a componentized name
    /// </summary>
    public readonly struct QualifiedName : ITextual
    {
        public Index<Name> Components {get;}

        [MethodImpl(Inline)]
        public QualifiedName(Index<Name> src)
            => Components = src;

        public string Format(string sep)
            => string.Join(sep, Components.Storage);

        public string Format(char sep)
            => string.Join(sep, Components.Storage);

        public string Format()
            => Format(Chars.Dot);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator QualifiedName(Name[] src)
            => new QualifiedName(src);

        [MethodImpl(Inline)]
        public static implicit operator QualifiedName(string[] src)
            => new QualifiedName(src.Select(s => (Name)s));
    }
}