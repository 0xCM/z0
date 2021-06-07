//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class AsciLineProcessor<T> : TextProcessor<T>
    {
        protected AsciLineProcessor(IEventSink sink)
            : base(sink)
        {
        }
    }
}