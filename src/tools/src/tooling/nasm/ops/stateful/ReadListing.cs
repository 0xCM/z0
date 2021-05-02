//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        [Op]
        public NasmListing ReadListing(FS.FilePath src)
        {
            var flow = Wf.Running(Msg.ReadingNasmListing.Format(src));
            var dst = root.list<NasmListLine>();
            using var reader = src.Reader();
            var i = 1u;
            while(!reader.EndOfStream)
                dst.Add(new NasmListLine(new TextLine(i++, reader.ReadLine())));
            var lines = dst.ToArray();
            Wf.Ran(flow, Msg.ReadNasmListing.Format(lines.Length, src));
            return new NasmListing(src, lines);
        }
    }
}