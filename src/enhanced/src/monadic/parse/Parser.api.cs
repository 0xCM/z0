//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Parser
    {

        [MethodImpl(Inline)]
        public static T apply<P,S,T>(P parser, S src) 
            where T : struct
            where P : IParser<S,T>
                => parser.Parse(src).ValueOrDefault(default(T));

    }
}