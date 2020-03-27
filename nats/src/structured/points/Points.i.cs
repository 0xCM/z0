//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;


    public interface IPoint
    {

    }

    public interface IPoint<X0> : IPoint
    {


    }

    public interface IPoint<N,T> : IPoint
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        int Dimension => (int)Nats.nateval<N>();

        Span<T> Components {get;}
    }


    public interface IMixedPoint<X0,X1> : IPoint
    {


    }

    public interface IMixedPoint<X0,X1,X3> : IPoint
    {


    }

    public interface IPointCell<P> : ICustomFormattable
    {
          
    }

}