//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IEventHub
    {
        ref readonly E Broadcast<E>(in E e)
            where E : struct, IAppEvent;

        Outcome Subscribe<E>(E e, HubEventReceiver<E> receiver)
            where E : struct, IAppEvent;
    }
}