//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;
    using static memory;

    partial class Nasm
    {
        [MethodImpl(Inline), Op]
        public NasmSource Source(Index<AsmExpr> expr, bool x64 = true)
            => source(expr,x64);

        [Op]
        public NasmListing Listing(FS.FilePath src)
        {
            var flow = Wf.Running(string.Format("Loading list lines from {0}", src.ToUri()));
            var dst = root.list<NasmListLine>();
            using var reader = src.Reader();
            var i = 1u;
            while(!reader.EndOfStream)
                dst.Add(new NasmListLine(new TextLine(i++, reader.ReadLine())));
            var lines = dst.ToArray();
            Wf.Ran(flow, string.Format("Loaded {0} list lines from {1}", lines.Length, src.ToUri()));
            return new NasmListing(src, lines);
        }
    }
}