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

    using static Root;


    public interface IPoint
    {

    }


    public interface INatPoint<N,P,T> 
        where N : unmanaged, ITypeNat
        where P : unmanaged
        where T : unmanaged
    {

        Span<T> Components {get;}

    }



    public interface IPoint<X0> : IPoint
    {


    }

    public interface IPoint<X0,X1> : IPoint
    {


    }

    public interface IPoint<X0,X1,X3> : IPoint
    {


    }

    public interface IPointCell<P> : IFormattable<P>
    {
          
    }

}