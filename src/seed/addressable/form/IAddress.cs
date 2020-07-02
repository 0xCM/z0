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
    
    public interface IAddress<T> : IAddress, ISized
        where T : unmanaged
    {
        T Location {get;}

        BitSize ISized.Width 
            => Root.bitsize<T>();
        
        bool INullity.IsEmpty 
            => Location.Equals(As.zero<T>());
    }

    public interface IAddress<W,T> : IAddress<T>, ISized<W>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        BitSize ISized.Width 
            => Widths.data<W>();
    }

    public interface IAddress<F,W,T> : IAddress<W,T>, INullary<F>, IEquatable<F>, IComparable<F>
        where W : unmanaged, IDataWidth
        where F : unmanaged, IAddress<F,W,T>
        where T : unmanaged
    {
        
    }
}