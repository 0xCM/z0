//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IKeyword<T>
        where T : struct, IKeyword<T>
    {
        string Name {get;}
    }

    public interface IKeyword<K,T> : IKeyword<T>
        where T : struct, IKeyword<K,T>
        where K : unmanaged
    {
        K Kind {get;}
    }
}