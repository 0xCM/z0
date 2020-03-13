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

    public interface IPointed
    {
        
    }

    public interface IPoint
    {

    }


    public interface INatPoint<N,P,T> 
        where N : unmanaged, ITypeNat
        where P : unmanaged, IPointed
        where T : unmanaged
    {

        Span<T> Components {get;}

    }


    public interface IPointed<X> : IPointed
        where X : unmanaged, IPointed<X>

    {
        
    }

    public interface IPointed<X0,X1> : IPointed<X0>
        where X0 : unmanaged, IPointed<X0>
        where X1 : unmanaged, IPointed<X0,X1>
    {

    }

    public interface IPointed<X0,X1,X2> : IPointed<X0,X2>
        where X0 : unmanaged, IPointed<X0>
        where X1 : unmanaged, IPointed<X0,X1>
        where X2 : unmanaged, IPointed<X0,X1,X2>
    {

    }


     public interface IPoint<X0> : IPoint
        where X0 : unmanaged
    {


    }

     public interface IPoint<X0,X1> : IPoint
        where X0 : unmanaged
        where X1 : unmanaged
    {


    }

     public interface IPoint<X0,X1,X3> : IPoint
        where X0 : unmanaged
        where X1 : unmanaged
        where X3 : unmanaged
    {


    }

    public interface IPointCell<P> : IPointed, IFormattable<P>
        where P : unmanaged, IPointed        
    {
          
    }

}