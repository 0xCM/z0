//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public interface IOpKind
    {
        string Name {get;}
    }

    public interface IOpKind<K> : IOpKind
        where K : unmanaged, IOpKind<K>
    {
        string IOpKind.Name => typeof(K).Name.ToLower();
    }
}