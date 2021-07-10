//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using Z0.Asm;

    using static core;

    partial class Nasm
    {
        public void ShowListings()
        {
            using var log = ShowLog(Id.Format() + "." + "listings", FS.Log);
            log.Title("List");

            var listings = Listings();
            foreach(var path in listings)
            {
                var listing = ReadListing(path);
                var entries = list<NasmListEntry>();
                var lines = listing.Lines.View;
                log.Title(path.ToUri());
                var count = lines.Length;
                for(var j=0; j<count; j++)
                {
                    ref readonly var line = ref skip(lines,j);
                    var content = span(line.Content);

                    if(!Nasm.entry(line, out var _entry))
                        Wf.Error("Parse entry failed");
                    else
                    {
                        RenderListEntry(_entry, log.Buffer);
                        log.ShowBuffer();
                    }
                }
            }
        }

        public ReadOnlySpan<NasmCodeBlock> ShowListedBlocks(Identifier name)
        {
            var blocks = LoadListedBlocks(name).View;
            var count = blocks.Length;
            using var log = ShowLog(name, FS.Log);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                RenderCodeBlock(block, log.Buffer);
                log.ShowBuffer();
            }
            return blocks;
        }
    }
}