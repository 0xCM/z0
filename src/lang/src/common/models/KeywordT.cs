//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies a keyword
    /// </summary>
    public readonly struct Keyword<T>
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public Keyword(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public static implicit operator Keyword<T>(string name)
            => new Keyword<T>(name);
    }
}