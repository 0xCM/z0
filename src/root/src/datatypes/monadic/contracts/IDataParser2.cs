//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDataParser2<T> : ITextParser2<T>
        where T : unmanaged
    {
        ParseResult<T[]> ParseData(string text);

        T Succeed(string src)
            => new ParseAdapter2<string,T>(this).Succeed(src, default(T));

        T[] ParseData(string text, T[] @default)
            => ParseData(text).ValueOrDefault(@default);
    }
}