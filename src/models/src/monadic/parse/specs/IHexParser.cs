//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexParser : ITextParser
    {
        bool HasPreSpec(string src);

        bool HasPostSpec(string src);

        ParseResult<byte> Parse(char c);
    }

    public interface IHexParser<T> : IHexParser, IDataParser<T>
        where T : unmanaged
    {
        
    }
}