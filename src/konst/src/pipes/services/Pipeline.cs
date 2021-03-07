//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    public class Pipeline<S,T> : WfService<Pipeline<S,T>>, IPipeline<Pipeline<S,T>,S,T>
    {
        public IEmitter<S> Emitter {get; private set;}

        public IProjector<S,T> Projector {get; private set;}

        public IReceiver<T> Receiver {get; private set;}

        public bool Connected {get; private set;}

        uint Counter;

        public void Run()
        {
            if(Connected)
            {
                while(Emitter.Next(out var src))
                {
                    Receiver.Deposit(Projector.Project(src));
                    Counter++;
                }
            }
        }

        public Pipeline<S,T> Connect(IEmitter<S> emitter, IProjector<S,T> projector, IReceiver<T> receiver)
        {
            var connection = create(Wf);
            connection.Emitter = emitter;
            connection.Projector = projector;
            connection.Receiver = receiver;
            connection.Connected = true;
            return connection;
        }
    }
}