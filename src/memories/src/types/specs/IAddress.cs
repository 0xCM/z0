//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;    

    public interface IAddress : ITextual, INullaryKnown
    {

    }
    
    public interface IAddress<T> : IAddress
        where T : unmanaged
    {
        T Location {get;}
        
    }

    public interface IAddress<W,T> : IAddress<T>, ISized<W>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
    }

    public interface IAddress<F,W,T> : IAddress<W,T>, INullary<F>
        where W : unmanaged, IDataWidth
        where F : unmanaged, IAddress<F,W,T>
        where T : unmanaged
    {
        
    }
}