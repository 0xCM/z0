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
    public readonly struct StringParser<T> : IStringParser<T>
    {        
        readonly Parse<string,T> F;

        [MethodImpl(Inline)]
        public StringParser(Parse<string,T> f)
            => F = f;
        
        [MethodImpl(Inline)]
        public ParseResult<string,T> Parse(string src)
            => F(src);
    }
}