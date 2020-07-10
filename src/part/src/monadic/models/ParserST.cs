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
    /// Defines a parser predicated on a supplied parse function
    /// </summary>
    public readonly struct Parser<S,T> : IParser<S,T>
    {        
        readonly Parse<S,T> F;

        [MethodImpl(Inline)]
        public Parser(Parse<S,T> f)
            => F = f;
        
        [MethodImpl(Inline)]
        public ParseResult<S,T> Parse(S src)
            => F(src);
    }
}