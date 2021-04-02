//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static memory;

    readonly struct NasmCodeBlockCollector
    {
        public NasmLabel Label {get;}

        public List<NasmEncoding> Code {get;}

        [MethodImpl(Inline), Op]
        public NasmCodeBlockCollector(NasmLabel label, List<NasmEncoding> code)
        {
            Label = label;
            Code  = code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline), Op]
            get => Label.IsEmpty && Code.Count == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline), Op]
            get => Label.IsNonEmpty || Code.Count != 0;
        }

        public NasmCodeBlock ToBlock()
            => new NasmCodeBlock(Label, Code.ToArray());
    }

    partial class Nasm
    {
        public Index<NasmCodeBlock> ListedBlocks(string listname)
        {
            var path = ListPath(listname);
            if(!path.Exists)
            {
                Wf.Error(FS.Msg.DoesNotExist.Format(path));
                return Index<NasmCodeBlock>.Empty;
            }

            var flow = Wf.Running(string.Format("Listing blocks from {0}", path.ToUri()));
            var listing = Listing(path);
            var buffer = alloc<NasmListEntry>(listing.LineCount);
            var count = Parse(listing, buffer);
            var output = slice(span(buffer), 0, count);
            var blocks = root.list<NasmCodeBlockCollector>();
            var collector = new NasmCodeBlockCollector(NasmLabel.Empty, new());
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(output,i);
                var kind = Nasm.kind(entry);
                if(kind == NasmListLineKind.Label)
                {
                    var label = new NasmLabel(entry.LineNumber, entry.Label);
                    if(collector.IsNonEmpty)
                        blocks.Add(collector);
                    collector = new NasmCodeBlockCollector(label, new());

                }
                else if(kind == NasmListLineKind.Encoding)
                {
                    var encoding = new NasmEncoding();
                    encoding.Code = entry.Encoding;
                    encoding.LineNumber = entry.LineNumber;
                    encoding.Offset  = entry.Offset;
                    encoding.SourceText = entry.SourceText;
                    collector.Code.Add(encoding);
                }
            }
            if(collector.IsNonEmpty)
                blocks.Add(collector);
            var results = blocks.Map(x => x.ToBlock());
            Wf.Ran(flow, string.Format("Constructed {0} blocks from {1}", results.Length, path.ToUri()));
            return results;
        }

        public uint Parse(NasmListing src, Span<NasmListEntry> dst)
        {
            var flow = Wf.Running(string.Format("Parsing list entries from {0} lines", src.LineCount));
            var j = 0u;
            var lines = src.Lines.View;
            var count = lines.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                var outcome = Nasm.entry(line, out var entry);
                if(outcome)
                    seek(dst, j++) = entry;
                else
                    Wf.Warn(outcome.Message);
            }

            Wf.Ran(flow, string.Format("Parsed {0} list entries", j));
            return j;
        }
    }
}