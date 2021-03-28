//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public readonly struct NasmListing : IRenderCapable<NasmListing>
    {
        public FS.FilePath Source {get;}

        public Index<TextLine> Lines {get;}

        [MethodImpl(Inline)]
        public NasmListing(FS.FilePath src, Index<TextLine> lines)
        {
            Source = src;
            Lines = lines;
        }

        public void Render(ITextBuffer dst)
        {
            var src = Lines.View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(src,i);
                dst.AppendLine(line.Format());
            }
        }

        public string Format()
            => RenderCapable.format(this);


        public override string ToString()
            => Format();
    }
}