//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate void DataReceiver<T>(T data);

    [Free]
    public delegate void EventReceiver(IDataEvent e);

    [Free]
    public delegate void EventReceiver<E>(in E e)
        where E : struct, IDataEvent;
}