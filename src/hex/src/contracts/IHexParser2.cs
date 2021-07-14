//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexParser2 : IParser2<char,byte>
    {
    }

    public interface IHexParser2<T> : IHexParser2, IDataParser2<T>
        where T : unmanaged
    {
        Type ITransformer2.SourceType
            => typeof(string);

        Type ITransformer2.TargetType
            => typeof(T);
    }
}