//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate void DataReceiver<T>(T data);

    [SuppressUnmanagedCodeSecurity]
    public delegate void DataReceiver<C,T>(C context,T data);


    /// <summary>
    /// Canonical signature for a function that projects the values of an enumeration onto a contiguous and strictly monotonic sequence
    /// of integers [0,.., n - 1] where n denotes the maximum number of indexed items
    /// </summary>
    /// <param name="kind">The enum literal to map to an integer value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate int IndexFunction<E>(E kind)
        where E : unmanaged, Enum;


    [SuppressUnmanagedCodeSecurity]
    public delegate void EventReceiver(IDataEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void EventReceiver<E>(in E e)
        where E : struct, IDataEvent;
}