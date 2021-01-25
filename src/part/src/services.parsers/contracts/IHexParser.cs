//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexParser : IParser<char,byte>
    {
    }

    public interface IHexParser<T> : IHexParser, IDataParser<T>
        where T : unmanaged
    {

        Type ITransformer.SourceType => typeof(string);

        Type ITransformer.TargetType => typeof(T);
    }
}