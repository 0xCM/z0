//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    public interface IEventHub
    {
        ref readonly E Broadcast<E>(in E e)
            where E : struct, IDataEvent;

        void Subscribe<E>(E e, EventReceiver<E> receiver)
            where E : struct, IDataEvent;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataSink : ISink
    {
       void Deposit(IDataEvent e);

       void Deposit<S>(in S e)        
            where S : struct, IDataEvent
                => Deposit((IDataEvent)e);
    }        

    public interface IHubClient : IDataSink
    {
        IEventHub Hub {get;}
        
        void Connect();
    }    
}