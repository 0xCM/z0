//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToken
    {

    }

    [Free]
    public interface IToken<K> : IToken, IIdentified<K>
        where K : unmanaged
    {

    }

    [Free]
    public interface IToken<K,S> : IToken<K>
        where S : unmanaged, ISymbol
        where K : unmanaged
    {
        ReadOnlySpan<S> Symbols {get;}
    }
}