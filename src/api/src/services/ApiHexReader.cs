//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public sealed class ApiHexReader : WfService<ApiHexReader>, IApiHexReader
    {
        public Index<ApiCodeBlock> ReadHexBlocks(FS.FilePath src)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var buffer = sys.alloc<ApiCodeBlock>(count);
            var dst = span(buffer);
            var hex = Wf.ApiHex();
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(hex.Parse(line, out var row))
                    seek(dst,i) = new ApiCodeBlock(row.Uri, new CodeBlock(row.Address, row.Data));
                else
                    Wf.Error(string.Format("Could not parse line {0} from {1}", i,src.ToUri()));
            }
            return buffer;
        }
    }
}