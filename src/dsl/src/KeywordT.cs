//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Keyword<T>
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public Keyword(string src)
            => Name = src;

        public static implicit operator Keyword<T>(string name)
            => new Keyword<T>(name);
    }
}