//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Parser
    {

        [MethodImpl(Inline)]
        public static ParseResult<T> lower<S,T>(ParseResult<S,T> src)
            => src
            ? ParseResult<T>.Fail(src.Source.ToString(), src.Reason.ValueOrDefault(string.Empty))
            : ParseResult<T>.Success(src.Source.ToString(), src.Value);

        [MethodImpl(Inline)]
        public static ParseResult<S,T> lift<S,T>(ParseResult<T> src)
            => src
               ? ParseResult<S,T>.Success(memory.@as<string,S>(src.Source), src.Value)
               : ParseResult<S,T>.Fail(memory.@as<string,S>(src.Source), src.Message);


        [MethodImpl(Inline)]
        public static T apply<P,S,T>(P parser, S src)
            where T : struct
            where P : IParser<S,T>
                => parser.Parse(src).ValueOrDefault(default(T));

    }
}