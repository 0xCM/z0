//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IKnownOpType
    {
        string Name {get;}
    }

    public interface IKnownOpType<K> : IKnownOpType
        where K : unmanaged, IKnownOpType<K>
    {
        string IKnownOpType.Name => typeof(K).Name.ToLower();
    }    
}