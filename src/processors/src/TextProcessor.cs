//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class TextProcessor<T> : ProcessService<T>, ITextProcessor<T>
    {
        public Outcome<T> ProcessLine(uint number, ReadOnlySpan<char> chars)
        {
            var result = Process(number, chars);
            if(result.Ok)
                Receiver(result.Data);
            return result;
        }

        public abstract void ProcessFile(FS.FilePath src);

        protected TextProcessor(IEventSink sink)
            : base(sink)
        {
        }

        protected TextProcessor(IEventSink sink, Receiver<T> receiver)
            : base(sink, receiver)
        {

        }

        protected abstract Outcome<T> Process(uint number, ReadOnlySpan<char> chars);

        protected static MsgPattern<Count,FS.FileUri> ProcessedLines => "Processed {0} lines from {1}";
    }
}