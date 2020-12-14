//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Specifies a dsl keyword
    /// </summary>
    public readonly struct Keyword : IKeyword
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public unsafe Keyword(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public static implicit operator Keyword(string name)
            => new Keyword(name);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();
    }
}