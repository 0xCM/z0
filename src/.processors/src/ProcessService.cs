//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class ProcessService<H,T> : Service<H>
        where H : ProcessService<H,T>,  new()
    {
        public static H create(IServiceContext context, Receiver<T> receiver)
        {
            var service = create(context);
            service.Receiver = receiver;
            return service;
        }

        protected ProcessService()
        {

        }

        protected Receiver<T> Receiver {get; private set;}
    }
}