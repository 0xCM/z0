//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using static Seed;

    public interface IHexParser : IParser
    {
        bool HasPreSpec(string src) => src.TrimStart().StartsWith(HexSpecs.PreSpec);

        bool HasPostSpec(string src) => src.TrimEnd().EndsWith(HexSpecs.PostSpec);

        ParseResult<byte> Parse(char c) => HexSpecs.Parse(c);
    }

    public interface IHexParser<T> : IHexParser, IDataParser<T>
        where T : unmanaged
    {
        
    }
}