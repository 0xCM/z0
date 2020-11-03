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
        public static WfEventHub create(IDataSink sink)
        {
            var hub = EventHubs.hub();
            var client = new HubClientExample(hub, sink);
            return hub;
        }

        [MethodImpl(Inline), Op]
        public static Action connector(IWfHubClient client)
            => client.Connect;

        public IWfEventHub Hub {get;}

        public IDataSink Sink {get;}

        public void Deposit(IDataEvent e)
            => Sink.Deposit(e);

        public void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public HubClientExample(IWfEventHub hub, IDataSink sink)
        {
            Hub = hub;
            Sink = sink;
            (this as IWfHubClient).Connect();
        }
    }

    public readonly struct ExampleEvents : IExampleEvents
    {
        public static IExampleEvents Examples
            => default(ExampleEvents);
    }

    public readonly struct ExampleEvent1 : IDataEvent<ExampleEvent1>
    {
        public StringRef Id {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ExampleEvent1 Define(StringRef id, BinaryCode data)
            => new ExampleEvent1(id,data);

        [MethodImpl(Inline)]
        public ExampleEvent1(StringRef id, BinaryCode data)
        {
            Id = id;
            Encoded = data;
        }
    }

    public readonly struct ExampleEvent2 : IDataEvent<ExampleEvent2>
    {
        [MethodImpl(Inline)]
        public ExampleEvent2 Define(StringRef id, BinaryCode data)
            => new ExampleEvent2(id,data);

        public StringRef Id {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ExampleEvent2(StringRef id, BinaryCode data)
        {
            Id = id;
            Encoded = data;
        }
    }

    public readonly struct ExampleEvent3 : IDataEvent<ExampleEvent3>
    {
        [MethodImpl(Inline)]
        public ExampleEvent3 Define(StringRef id, BinaryCode data)
            => new ExampleEvent3(id,data);

        public StringRef Id {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ExampleEvent3(StringRef id, BinaryCode data)
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

    public interface IHubClientExample : IExampleEvents, IWfHubClient
    {
        void OnEvent(in ExampleEvent1 e)
            => Deposit(e);

        void OnEvent(in ExampleEvent2 e)
            => Deposit(e);

        void OnEvent(in ExampleEvent3 e)
            => Deposit(e);


        void IWfHubClient.Connect()
        {
            Hub.Subscribe(Event1, OnEvent);
            Hub.Subscribe(Event2, OnEvent);
            Hub.Subscribe(Event3, OnEvent);
        }
    }
}