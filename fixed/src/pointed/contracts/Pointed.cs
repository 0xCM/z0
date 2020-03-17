//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public interface IPointed
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPointed<X> : IPointed
        where X : IPoint
    {
        X Point {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPointed<X0,X1> : IPointed<MixedPoint<X0,X1>>
        
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPointed<X0,X1,X2> : IPointed<MixedPoint<X0,X1,X2>>
        
    {
        
    }

}