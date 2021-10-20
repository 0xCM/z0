//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISymbol : IExpr
    {

    }
    
    [Free]
    public interface ISymbol<S> : ISymbol, IComparable<S>, IEquatable<S>
        where S : unmanaged, ISymbol<S>
    {    
        uint Key {get;}
    }

    [Free]
    public interface ISymbol<S,K> : ISymbol<S>
        where S : unmanaged, ISymbol<S>
        where K : unmanaged
    {
        K Value {get;}
    }
}