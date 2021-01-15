//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IOperand : IPositioned
    {
        dynamic Content {get;}
    }

    [Free]
    public interface IOperand<T> : IOperand
    {
        new T Content {get;}

        dynamic IOperand.Content
            => Content;
    }

    [Free]
    public interface IKindedOperand<K> : IOperand, IKinded<K>
        where K : unmanaged
    {

    }

    [Free]
    public interface IOperand<K,T> : IOperand<T>, IKindedOperand<K>
        where K : unmanaged
    {

    }
}