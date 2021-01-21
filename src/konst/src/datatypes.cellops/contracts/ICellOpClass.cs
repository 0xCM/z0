//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static OperationClasses;

    [Free]
    public interface ICellOpClass<F,W,E> : ICellClass, IOperationClassHost<F,E>
        where F : struct, ICellOpClass<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth ICellClass.Width
            => Widths.type<W>();
    }
}