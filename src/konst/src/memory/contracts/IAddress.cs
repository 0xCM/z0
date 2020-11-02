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

    public interface IAddress<T> : IAddress
        where T : unmanaged
    {
        T Location {get;}

        bool INullity.IsEmpty
            => Location.Equals(z.zero<T>());
    }

    public interface IAddress<W,T> : IAddress<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IAddress<F,W,T> : IAddress<W,T>, INullary<F>, IEquatable<F>, IComparable<F>
        where W : unmanaged, IDataWidth
        where F : struct, IAddress<F,W,T>
        where T : unmanaged
    {

    }
}