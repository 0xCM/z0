//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static memory;
    using static Part;
    using static ProcessMemory;

    partial class ProcessContextPipe
    {
        public Outcome<Index<MemoryRegion>> LoadRegions(FS.FilePath src)
        {
            var tid = Tables.tableid<MemoryRegion>();
            var flow = Wf.Running(string.Format("Reading {0} records from {1}", tid, src.ToUri()));
            if(!src.Exists)
                return (false, FS.Msg.DoesNotExist.Format(src));
            var lines = src.ReadTextLines().View;
            var count = lines.Length;
            if(count == 0)
            {
                return (false,"No data");
            }

            ref readonly var header = ref first(lines);
            var cells = header.Split(Chars.Pipe);
            if(cells.Length != MemoryRegion.FieldCount)
                return (false, Tables.FieldCountMismatch.Format(cells.Length, MemoryRegion.FieldCount));

            var data = slice(lines,1);
            var buffer = alloc<MemoryRegion>(data.Length);
            ref var dst = ref first(buffer);
            var counter = 0;
            for(var i=0; i<data.Length; i++)
            {
                ref readonly var line = ref skip(data,i);
                if(line.IsEmpty)
                    continue;

                var result = Images.parse(line.Content, out seek(dst,i));
                if(!result)
                    return result;

                counter++;
            }
            Wf.Ran(flow, string.Format("Read {0} {1} records from {2}", counter, tid, src.ToUri()));
            return (true,buffer);
        }
    }
}