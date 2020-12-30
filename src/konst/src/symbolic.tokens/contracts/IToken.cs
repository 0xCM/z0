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
    public interface IToken<S> : IToken
        where S : unmanaged, ISymbol
    {
        ReadOnlySpan<S> Symbols {get;}

    }

    [Free]
    public interface IToken<K,S> : IToken<S>, IKinded<K>
        where S : unmanaged, ISymbol
        where K : unmanaged
    {
    }
}