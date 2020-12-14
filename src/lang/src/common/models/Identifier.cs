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
    /// Represents a legal identifier
    /// </summary>
    public readonly struct Identifier
    {
        public string Value {get;}

        [MethodImpl(Inline)]
        public Identifier(string src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator Identifier(string src)
            => new Identifier(src);
    }
}