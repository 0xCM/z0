//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IAddress : ITextual, INullity
    {

    }
    
    public interface IAddress<W> : IAddress, ISized<W>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IAddress<W,T> : IAddress<W>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        T Location {get;}

        bool INullity.IsEmpty 
            => Location.Equals(default);
    }

    public interface IAddress<F,W,T> : IAddress<W,T>, INullary<F>, IEquatable<F>
        where W : unmanaged, IDataWidth
        where F : unmanaged, IAddress<F,W,T>
        where T : unmanaged
    {
        
    }
}