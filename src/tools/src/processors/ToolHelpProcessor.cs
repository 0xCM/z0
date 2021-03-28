//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class ToolHelpProcessor : TextDocProcessor<ToolHelpProcessor,ToolHelp>
    {
        public override ToolHelp Processing(in TextDoc src)
            => new ToolHelp((uint)src.RowCount);

        protected override void Processed(in TextLine src, dynamic output, ref ToolHelp dst)
            => dst[src.LineNumber] = output;

        protected override ITextLineProcessor Processor(in TextLine src)
            => new DefaultLineProcessor();
    }

    readonly struct DefaultLineProcessor : ITextLineProcessor
    {
        public Outcome Process(in TextLine src, out dynamic dst)
        {
            dst = src.Content;
            return true;
        }
    }
}