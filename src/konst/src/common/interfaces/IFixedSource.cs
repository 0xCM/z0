//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedSource<T> : IValueSource<T>
        where T : struct, IFixedCell
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedSource : IValueSource
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBoundFixedSource<T> : IBoundValueSource<T>
        where T : struct, IFixedCell
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBoundFixedSource : IBoundValueSource
    {

    }
}