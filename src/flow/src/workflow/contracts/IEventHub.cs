//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IEventHub
    {
        ref readonly E Broadcast<E>(in E e)
            where E : struct, IDataEvent;

        void Subscribe<E>(E e, EventReceiver<E> receiver)
            where E : struct, IDataEvent;
    }
}