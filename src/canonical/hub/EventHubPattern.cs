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
        public static EventHub create(DataEventReceiver receiver)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, EventHubs.relay(receiver));
            return hub;            
        }

        [MethodImpl(Inline), Op]
        public static EventHub create(IDataEventSink sink)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, sink);            
            return hub;            
        }

        public EventHub Hub {get;}

        public IDataEventSink Sink {get;}

        public void Deposit(IDataEvent e)
            => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public HubClientExample(EventHub hub, IDataEventSink sink)
        {
            Hub = hub;
            Sink = sink;
            (this as IHubClient).Connect();
        }
    }

    public readonly struct ExampleEvents : IExampleEvents
    {
        public static IExampleEvents Examples 
            => default(ExampleEvents);
    }

    public interface IDataEvent : IAppEvent
    {
        StringRef Id {get;}

        BinaryCode Data {get;}    

        string ITextual.Format()
        {
            var dst = text.build();
            dst.Append(Id);
            dst.Append(Chars.Space);
            dst.Append(Chars.Pipe);
            dst.AppendLine(Data.Format());
            return dst.ToString();
        }    
    }

    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IDataEvent<F> : IDataEvent, IAppEvent<F>
        where F : struct, IDataEvent<F>
    {


    }

    public readonly struct ExampleEvent1 : IDataEvent<ExampleEvent1>
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

    public readonly struct ExampleEvent2 : IDataEvent<ExampleEvent2>
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

    public readonly struct ExampleEvent3 : IDataEvent<ExampleEvent3>
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

    public interface IHubClientExample : IExampleEvents, IHubClient, IDataEventSink
    {
        void OnEvent(in ExampleEvent1 e) 
            => Deposit(e);

        void OnEvent(in ExampleEvent2 e) 
            => Deposit(e);

        void OnEvent(in ExampleEvent3 e) 
            => Deposit(e);

        void IHubClient.Connect()
        {
            Hub.Subscribe(Event1, OnEvent);
            Hub.Subscribe(Event2, OnEvent);
            Hub.Subscribe(Event3, OnEvent);                
        }        
    }
}