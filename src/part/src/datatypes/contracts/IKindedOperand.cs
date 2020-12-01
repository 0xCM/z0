//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IKindedOperand<K> : IOperand, IKinded<K>
        where K : unmanaged
    {

    }
    [Free]
    public interface IKindedOperand<K,T> : IOperand<T>, IKindedOperand<K>
        where K : unmanaged
    {

    }
}