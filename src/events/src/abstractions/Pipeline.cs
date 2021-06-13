//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class Pipeline : IPipeline
    {
        public EventSignal Signal {get;}

        public abstract void Run();

        protected Pipeline(EventSignal signal)
        {
            Signal = signal;
        }
    }
}