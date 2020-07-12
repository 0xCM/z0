//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class EventBroker<F,E> : EventBroker
        where F : EventBroker<F,E>, E
        where E : IEventBroker
    {        
        protected EventBroker(FilePath target)
            : base(target)
        {

        }   
    }
}