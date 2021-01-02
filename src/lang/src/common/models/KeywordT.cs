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
        public T Name {get;}

        [MethodImpl(Inline)]
        public Keyword(T src)
            => Name = src;

        [MethodImpl(Inline)]
        public static implicit operator Keyword<T>(T name)
            => new Keyword<T>(name);
    }
}