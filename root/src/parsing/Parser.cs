//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public delegate object Parse(string text);

    public delegate T Parse<T>(string text);
    
    public readonly struct Parser<T> : IParser<T>
    {        
        [MethodImpl(Inline)]
        public static IParser<T> Define(Parse<T> f)
            => new Parser<T>(f);

        readonly Parse<T> parse;
        
        [MethodImpl(Inline)]
        Parser(Parse<T> parse)
        {
            this.parse = parse;
        }
        public T Parse(string text)
            => parse(text);
    }
}