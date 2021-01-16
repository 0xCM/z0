//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Chracterizes a data type with non-variable width
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    [Free]
    public interface IFixedDataType<T> : IDataType<T>
    {
        bool IDataType.IsFixedWidth
            => true;
    }

    /// <summary>
    /// Chracterizes a data type with non-variable width
    /// </summary>
    /// <typeparam name="C">The container type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    [Free]
    public interface IFixedDataType<C,T> : IFixedDataType<T>, IDataType<C,T>
        where C : IFixedDataType<C,T>
    {

    }
}