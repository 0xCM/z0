//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class EventBroker<F,E> : EventBroker
        where F : EventBroker<F,E>, E, new()
        where E : IEventBroker
    {        
        public static E New => new F();
    }
}