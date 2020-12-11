//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexParser : IParser<char,byte>
    {
        bool HasPreSpec(string src);

        bool HasPostSpec(string src);

    }

    public interface IHexParser<T> : IHexParser, IDataParser<T>
        where T : unmanaged
    {

        Type ITransformer.SourceType => typeof(string);

        Type ITransformer.TargetType => typeof(T);
    }
}