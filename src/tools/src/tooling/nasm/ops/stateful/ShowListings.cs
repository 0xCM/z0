//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class Nasm
    {
        public void ShowListings()
        {
            using var log = ShowLog(Id.Format() + "." + "listings", FS.Log);
            log.Title(NasmFileKind.Listing);

            var listings = Listings();
            foreach(var path in listings)
            {
                var listing = ReadListing(path);
                var entries = root.list<NasmListEntry>();
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
    }
}