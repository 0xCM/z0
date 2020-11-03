//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfEventHub
    {
        ref readonly E Broadcast<E>(in E e)
            where E : struct, IDataEvent;

        void Subscribe<E>(E e, EventReceiver<E> receiver)
            where E : struct, IDataEvent;
    }
}