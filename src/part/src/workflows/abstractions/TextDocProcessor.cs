//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public abstract class TextDocProcessor<P,T> : DataProcessor<TextDoc,T>
        where P : TextDocProcessor<P,T>, new()
    {
        public static P create()
            => new P();

        public abstract T Processing(in TextDoc src);

        public override Outcome Process(in TextDoc src, out T dst)
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
                    root.@throw(result.Message);
                Processed(line, _processed, ref dst);
            }
            return default;
        }

        protected abstract ITextLineProcessor Processor(in TextLine src);

        protected abstract void Processed(in TextLine src, dynamic output, ref T dst);
    }
}