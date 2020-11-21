//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellOpClass : IOperationalClass
    {
        TypeWidth Width {get;}
    }

    [Free]
    public interface ICellOpClass<F,E> : IOperationalClass<E>, IOperationalClass
        where F : struct, ICellOpClass<F,E>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface ICellOpClass<F,W,E> : ICellOpClass, IOperationalClassHost<F,E>
        where F : struct, ICellOpClass<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth ICellOpClass.Width
            => Widths.type<W>();
    }
}