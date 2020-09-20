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


    [SuppressUnmanagedCodeSecurity]
    public delegate void EventReceiver(IDataEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void EventReceiver<E>(in E e)
        where E : struct, IDataEvent;
}