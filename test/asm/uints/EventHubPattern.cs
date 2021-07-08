//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct HubClientExample : IHubClientExample
    {
        [MethodImpl(Inline), Op]
        public static EventHub create(IDataEventSink sink)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, sink);
            return hub;
        }

        [MethodImpl(Inline), Op]
        public static Action connector(IEventHubClient client)
            => client.Connect;

        public IEventHub Hub {get;}

        public IDataEventSink Sink {get;}

        public void Deposit(IWfEvent e)
            => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public HubClientExample(IEventHub hub, IDataEventSink sink)
        {
            Hub = hub;
            Sink = sink;
            (this as IEventHubClient).Connect();
        }
    }

    public readonly struct ExampleEvents : IExampleEvents
    {
        public static IExampleEvents Examples
            => default(ExampleEvents);
    }

    public readonly struct ExampleEvent1 : IDataEvent<ExampleEvent1>
    {

        public BinaryCode Encoded {get;}

        public ulong Id {get;}

        [MethodImpl(Inline)]
        public ExampleEvent1 Define(ulong id, BinaryCode data)
            => new ExampleEvent1(id, data);

        [MethodImpl(Inline)]
        public ExampleEvent1(ulong id, BinaryCode data)
        {
            Id = id;
            Encoded = data;
        }
    }

    public readonly struct ExampleEvent2 : IDataEvent<ExampleEvent2>
    {
        [MethodImpl(Inline)]
        public ExampleEvent2 Define(ulong id, BinaryCode data)
            => new ExampleEvent2(id, data);

        public ulong Id {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ExampleEvent2(ulong id, BinaryCode data)
        {
            Id = id;
            Encoded = data;
        }
    }

    public readonly struct ExampleEvent3 : IDataEvent<ExampleEvent3>
    {
        [MethodImpl(Inline)]
        public ExampleEvent3 Define(ulong id, BinaryCode data)
            => new ExampleEvent3(id,data);

        public ulong Id {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ExampleEvent3(ulong id, BinaryCode data)
        {
            Id = id;
            Encoded = data;
        }
    }

    public interface IExampleEvents
    {
        ExampleEvent1 Event1 => default;

        ExampleEvent2 Event2 => default;

        ExampleEvent3 Event3 => default;
    }

    public interface IHubClientExample : IExampleEvents, IEventHubClient
    {
        void OnEvent(in ExampleEvent1 e)
            => Deposit(e);

        void OnEvent(in ExampleEvent2 e)
            => Deposit(e);

        void OnEvent(in ExampleEvent3 e)
            => Deposit(e);

        void IEventHubClient.Connect()
        {
            Hub.Subscribe(Event1, OnEvent);
            Hub.Subscribe(Event2, OnEvent);
            Hub.Subscribe(Event3, OnEvent);
        }
    }
}