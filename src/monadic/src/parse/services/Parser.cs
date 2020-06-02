//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Monadic;
        
    /// <summary>
    /// Defines a parser predicated on a supplied parse function
    /// </summary>
    public readonly struct Parser<S,T> : IParser<S,T>
    {        
        readonly Parse<S,T> ParseFx;

        [MethodImpl(Inline)]
        public Parser(Parse<S,T> f)
            => ParseFx = f;
        
        [MethodImpl(Inline)]
        public ParseResult<S,T> Parse(S src)
            => ParseFx(src);
    }
}