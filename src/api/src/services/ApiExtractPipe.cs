//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public class ApiExtractPipe : AppService<ApiExtractPipe>
    {
        public FS.Files Paths()
            => Db.RawExtractPaths();

        public uint Load(FS.FilePath src, DataList<ApiExtractBlock> dst)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var flow = Wf.Running(string.Format("Reading extracts from {0}", src.ToUri()));
            var counter = 0u;
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(Parse(line, out var block))
                {
                    dst.Add(block);
                    counter++;
                }
                else
                    Wf.Warn($"Unable to process {line}");

            }
            Wf.Ran(flow, string.Format("Read {0} extract blocks from {1}", counter, src.ToUri()));
            return counter;
        }

        public Index<ApiExtractBlock> Load(FS.Files src)
        {
            var dst = root.datalist<ApiExtractBlock>();
            var counter = 0u;
            foreach(var file in src)
                counter += Load(file,dst);
            return dst.Close();
        }

        public Outcome Parse(string src, out ApiExtractBlock dst)
        {
            dst = ApiExtractBlock.Empty;
            try
            {
                var parts = src.SplitClean(FieldDelimiter);
                var parser = HexParsers.bytes();
                if(parts.Length != 3)
                    return (false, $"components = {parts.Length} != 3");

                var address = HexParsers.scalar().Parse(parts[(byte)ApiExtractField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiExtractField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiExtractField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                dst = new ApiExtractBlock(address, uri, bytes);
                return true;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return e;
            }
        }
    }
}