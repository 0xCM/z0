//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public abstract class TextDocTransformer<P,T> : DataTransformer<TextGrid,T>
        where P : TextDocTransformer<P,T>, new()
    {
        public static P create()
            => new P();

        public abstract T Processing(in TextGrid src);

        public override Outcome Process(in TextGrid src, out T dst)
        {
            dst = Processing(src);
            var rows = src.Rows;
            var count = rows.Length;
            for(var i=0u; i<count; i++)
            {
                var line = text.line(i, skip(rows,i));
                var processor = Processor(line);
                var result = processor.Process(line, out var _processed);
                if(!result)
                    Throw.sourced(result.Message);
                Processed(line, _processed, ref dst);
            }
            return default;
        }

        protected abstract ITextLineTransformer Processor(in TextLine src);

        protected abstract void Processed(in TextLine src, dynamic output, ref T dst);
    }
}