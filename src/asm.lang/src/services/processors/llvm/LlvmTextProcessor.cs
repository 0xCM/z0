//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public abstract class LlvmTextProcessor<T> : AsciTextProcessor<T>
    {
        protected LlvmTextProcessor(IEventSink sink)
            : base(sink)
        {

        }

        protected override void Receive(in T src)
        {

        }
    }
}