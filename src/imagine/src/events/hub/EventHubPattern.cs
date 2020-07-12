//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct HubClientExample : IHubClientExample
    {
        [MethodImpl(Inline), Op]
        public static EventHub create(EncodedEventReceiver receiver)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, EventHubs.relay(receiver));
            return hub;            
        }

        [MethodImpl(Inline), Op]
        public static EventHub create(IEncodedEventSink sink)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, sink);            
            return hub;            
        }

        public EventHub Hub {get;}

        public IEncodedEventSink Sink {get;}

        public void Deposit(IEncodedEvent e)
            => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public HubClientExample(EventHub hub, IEncodedEventSink sink)
        {
            Hub = hub;
            Sink = sink;
            (this as IEncodedEventClient).Connect();
        }
    }

    public readonly struct ExampleEvents : IExampleEvents
    {
        public static IExampleEvents Examples 
            => default(ExampleEvents);
    }
    
    public readonly struct ExampleEvent1 : IEncodedEvent<ExampleEvent1>
    {
        [MethodImpl(Inline)]
        public ExampleEvent1 Define(StringRef id, BinaryCode data)
            => new ExampleEvent1(id,data);
        
        public StringRef Id {get;}

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public ExampleEvent1(StringRef id, BinaryCode data)
        {
            Id = id;
            Data = data;
        }        
    }    

    public readonly struct ExampleEvent2 : IEncodedEvent<ExampleEvent2>
    {
        [MethodImpl(Inline)]
        public ExampleEvent2 Define(StringRef id, BinaryCode data)
            => new ExampleEvent2(id,data);

        public StringRef Id {get;}

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public ExampleEvent2(StringRef id, BinaryCode data)
        {
            Id = id;
            Data = data;
        }
    }    

    public readonly struct ExampleEvent3 : IEncodedEvent<ExampleEvent3>
    {
        [MethodImpl(Inline)]
        public ExampleEvent3 Define(StringRef id, BinaryCode data)
            => new ExampleEvent3(id,data);

        public StringRef Id {get;}

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public ExampleEvent3(StringRef id, BinaryCode data)
        {
            Id = id;
            Data = data;
        }
    }    
    
    public interface IExampleEvents
    {
        ExampleEvent1 Event1 => default;

        ExampleEvent2 Event2 => default;

        ExampleEvent3 Event3 => default;            
    }

    public interface IHubClientExample : IExampleEvents, IEncodedEventClient, IEncodedEventSink
    {
        void OnEvent(in ExampleEvent1 e) 
            => Deposit(e);

        void OnEvent(in ExampleEvent2 e) 
            => Deposit(e);

        void OnEvent(in ExampleEvent3 e) 
            => Deposit(e);

        void IEncodedEventClient.Connect()
        {
            Hub.Subscribe(Event1, OnEvent);
            Hub.Subscribe(Event2, OnEvent);
            Hub.Subscribe(Event3, OnEvent);                
        }        
    }
}