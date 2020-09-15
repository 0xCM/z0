//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ICellSource<T> : IValueSource<T>
        where T : struct, IDataCell
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ICellSource : IValueSource
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBoundCellSource<T> : IBoundValueSource<T>
        where T : struct, IDataCell
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBoundCellSource : IBoundValueSource
    {

    }
}