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
        public void ShowListings()
        {
            using var log = ShowLog(Id.Format() + "." + "listings", FS.Log);
            log.Title(NasmFileKind.Listing);

            var listings = Listings();
            foreach(var path in listings)
            {
                var listing = Listing(path);
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
                        Render(_entry, log.Buffer);
                        log.ShowBuffer();
                    }
                }
            }

        }

        public void ShowFiles()
        {
            var @case = "bswap";

            using var log = ShowLog(Id.Format() + "." + "files", FS.Log);

            var i=0;

            log.Property(nameof(InDir), InDir);
            log.Property(nameof(OutDir), OutDir);

            var inputs = Inputs();
            var outputs = Outputs();
            var listings = Listings();

            log.Title(NasmFileKind.Input);
            i=0;
            root.iter(inputs, path => log.Row(i++, NasmFileKind.Input, path.ToUri()));

            log.Title(NasmFileKind.Output);
            i=0;
            root.iter(outputs, path => log.Row(i++, NasmFileKind.Output, path.ToUri()));
        }
    }
}