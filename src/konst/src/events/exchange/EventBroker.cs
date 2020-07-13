//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static Konst;

    public class EventBroker : IPersistentBroker
    {
        readonly Dictionary<Type,ISink> Subscriptions;
        
        public FilePath TargetPath {get;}

        readonly StreamWriter OutStream;

        object locker;

        [MethodImpl(Inline)]
        public EventBroker(FilePath target)
        {
            TargetPath = target ?? FilePath.Empty;
            Subscriptions = new Dictionary<Type,ISink>();
            if(!TargetPath.IsNonEmpty)
                OutStream = TargetPath.Writer();
            locker = new object();
        }

        public void Dispose()
        {
            if(OutStream != null)
                OutStream.Dispose();
        }

        Outcome Subscribe<S,E>(S sink, E model)
            where E : IAppEvent
            where S : ISink
        {
            if(Subscriptions.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously added for {sink}"));
        }

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent                 
                => Subscribe(AppEvents.sink(receiver), model);

        [MethodImpl(Inline)]
        Outcome IEventBroker.Subscribe<S,E>(S sink, E model)
            => Subscribe(sink,model);

        void Emit(IAppEvent e)
        {
            if(OutStream != null)
                lock(locker)
                    OutStream.WriteLine(e.Format());
        }
        
        ref readonly E IEventBroker.Raise<E>(in E e)
        {                
            Emit(e);
            
            if(Subscriptions.TryGetValue(e.GetType(), out var sink))
                ((IAppEventSink<E>)sink).Deposit(e);
            else
                term.print(e, e.Flair);
            return ref e;
        }

        public Outcome Subscribe(Action<IAppEvent> receiver, IAppEvent model)
        {
            if(Subscriptions.TryAdd(model.GetType(), AppEvents.sink(receiver)))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        }
    }
}