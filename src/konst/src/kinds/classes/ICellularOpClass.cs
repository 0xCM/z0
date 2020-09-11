//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICellularOpClass : IOperational
    {
        TypeWidth Width {get;}
    }


    public interface ICellularOpClass<F,E> : IOperational<E>, IOperational
        where F : struct, ICellularOpClass<F,E>
        where E : unmanaged, Enum
    {

    }

    public interface ICellularOpClass<F,W,E> : ICellularOpClass, IOperationalF<F,E>
        where F : struct, ICellularOpClass<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth ICellularOpClass.Width => Widths.type<W>();
    }
}