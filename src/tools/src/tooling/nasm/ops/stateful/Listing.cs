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

    partial class Nasm
    {
        public NasmListing Listing(FS.FilePath src)
        {
            var dst = root.list<NasmListLine>();
            using var reader = src.Reader();
            var i = 1u;
            while(!reader.EndOfStream)
                dst.Add(new NasmListLine(new TextLine(i++, reader.ReadLine())));
            return new NasmListing(src, dst.ToArray());
        }
    }
}