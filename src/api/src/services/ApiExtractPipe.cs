//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public class ApiExtractPipe : AppService<ApiExtractPipe>
    {
        public FS.Files RawExtractPaths()
            => Db.RawExtractPaths();

        public uint Load(FS.FilePath src, List<ApiExtractBlock> dst)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var flow = Wf.Running(string.Format("Reading extracts from {0}", src.ToUri()));
            var counter = 0u;
            var result = Outcome.Success;
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                result = ApiExtractBlock.parse(line, out var block);
                if(result.Ok)
                {
                    dst.Add(block);
                    counter++;
                }
                else
                    Wf.Warn(result.Message);

            }
            Wf.Ran(flow, string.Format("Read {0} extract blocks from {1}", counter, src.ToUri()));
            return counter;
        }

        public ReadOnlySpan<ApiExtractBlock> Load(FS.Files src)
        {
            var dst = list<ApiExtractBlock>();
            var counter = 0u;
            foreach(var file in src)
                counter += Load(file, dst);
            return dst.ViewDeposited();
        }
    }
}