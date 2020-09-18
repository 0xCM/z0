//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IKindedArrow<K> : IArrow
        where K : unmanaged, Enum
    {
        K Kind {get;}
    }

    [Free]
    public interface IKindedArrow<K,S,T> : IKindedArrow<K>, IArrow<S,T>
        where K : unmanaged, Enum
    {

    }

    [Free]
    public interface IKindedArrowHost<H,K,S,T> : IKindedArrow<K,S,T>
        where H : struct, IKindedArrowHost<H,K,S,T>
        where K : unmanaged, Enum
    {

    }
}