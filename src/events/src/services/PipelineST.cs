//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class Pipeline<S,T> : Pipeline, IPipeline<Pipeline<S,T>,S,T>
    {
        public IEmitter<S> Emitter {get; set;}

        public IProjector<S,T> Projector {get; set;}

        public IReceiver<T> Receiver {get; set;}

        public bool Connected {get; set;}

        uint Counter;

        public Pipeline(EventSignal signal)
            : base(signal)
        {

        }

        public override void Run()
        {
            if(Connected)
            {
                while(Emitter.Emit(out var src))
                {
                    Receiver.Deposit(Projector.Project(src));
                    Counter++;
                }
            }
        }
    }
}