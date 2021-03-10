//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public class ApiExtractPipe : WfService<ApiExtractPipe>, IApiExtractReader, IApiExtractParser
    {
        public Index<ApiExtractBlock> Read(FS.FilePath src)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var buffer = sys.alloc<ApiExtractBlock>(count);
            var dst = span(buffer);
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);

                if(Parse(line, out var block))
                    seek(dst, i) = block;
                else
                    seek(dst, i) = ApiExtractBlock.Empty;

            }
            return buffer;
        }

        public Outcome Parse(string src, out ApiExtractBlock dst)
        {
            dst = ApiExtractBlock.Empty;
            try
            {
                var flow = Wf.Running("Parsing extract blocks");
                var parts = src.SplitClean(FieldDelimiter);
                var parser = HexParsers.bytes();
                if(parts.Length != 3)
                    return (false, $"components = {parts.Length} != 3");

                var address = HexParsers.scalar().Parse(parts[(byte)ApiExtractField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiExtractField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiExtractField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                dst = new ApiExtractBlock(address, uri, bytes);
                Wf.Ran(flow, string.Format("Parsed {0} extract blocks", (ByteSize)bytes.Length));
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