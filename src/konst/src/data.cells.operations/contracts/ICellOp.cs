//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using System;

    [Free]
    public interface ICellOp : IOperational
    {
        TypeWidth Width {get;}
    }

    [Free]
    public interface ICellOp<F,E> : IOperational<E>, IOperational
        where F : struct, ICellOp<F,E>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface ICellOp<F,W,E> : ICellOp, IOperationalF<F,E>
        where F : struct, ICellOp<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth ICellOp.Width => Widths.type<W>();
    }
}