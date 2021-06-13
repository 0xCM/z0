//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class TextProcessor<H,T> : ProcessService<H,T>, ITextProcessor<T>
        where H : TextProcessor<H,T>, new()
    {
        public Outcome<T> ProcessLine(uint number, ReadOnlySpan<char> data)
        {
            var result = Process(number, data);
            if(result.Ok)
                Receiver(result.Data);
            return result;
        }

        public abstract void ProcessFile(FS.FilePath src);

        protected abstract Outcome<T> Process(uint number, ReadOnlySpan<char> chars);

        protected static MsgPattern<Count,FS.FileUri> ProcessedLines
            => "Processed {0} lines from {1}";
    }
}