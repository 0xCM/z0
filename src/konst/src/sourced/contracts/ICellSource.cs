//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellSource<T> : IValueSource<T>
        where T : struct, IDataCell
    {

    }

    [Free]
    public interface ICellSource : IValueSource
    {

    }

    [Free]
    public interface IBoundCellSource<T> : IBoundValueSource<T>
        where T : struct, IDataCell
    {

    }

    [Free]
    public interface IBoundCellSource : IBoundValueSource
    {

    }
}