//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public delegate ParseResult Parse(string text);

    /// <summary>
    /// Defines the signature of a canonical text -> T parser
    /// </summary>
    /// <param name="src">The source text</param>
    /// <typeparam name="T">The target type</typeparam>
    public delegate ParseResult<T> Parse<T>(string text);

    /// <summary>
    /// Defines the signature of a canonical S -> T parser
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate ParseResult<S,T> Parse<S,T>(S src);

}