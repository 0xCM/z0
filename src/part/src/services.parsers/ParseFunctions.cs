//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines the signature of a canonical text -> T parser
    /// </summary>
    /// <param name="src">The source text</param>
    /// <typeparam name="T">The target type</typeparam>
    public delegate ParseResult<T> Parse<T>(string text);
}