//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using System;

    [Free]
    public interface ICellularOp : IOperational
    {
        TypeWidth Width {get;}
    }

    [Free]
    public interface ICellularOp<F,E> : IOperational<E>, IOperational
        where F : struct, ICellularOp<F,E>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface ICellularOp<F,W,E> : ICellularOp, IOperationalF<F,E>
        where F : struct, ICellularOp<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth ICellularOp.Width => Widths.type<W>();
    }
}