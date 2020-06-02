//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a parser that yields values of a parametrically-identified type
    /// </summary>
    /// <typeparam name="T">The type of value that the parser can parse</typeparam>
    public interface ISequentialParser<T> : ITextParser<T>
        where T : ISequential
    {
        ParseResult<T> Parse(string src, ref int seq);
        
        ParseResult<T> ITextParser<T>.Parse(string src)
        {
            var seq = 0;
            return Parse(src, ref seq);
        }
    }

    /// <summary>
    /// Characterizes a parser that yields values of sequential aspect
    /// </summary>
    /// <typeparam name="T">The type of value that the parser can parse</typeparam>
    public interface ISequentialParser<S,T> : IParser<S,T>
        where T : ISequential
    {
        ParseResult<S,T> Parse(S src, ref int seq);
        
        ParseResult<S,T> IParser<S,T>.Parse(S src)
        {
            var seq = 0;
            return Parse(src, ref seq);
        }
    }
}