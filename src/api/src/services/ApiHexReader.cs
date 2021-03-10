//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    public sealed class ApiHexReader : WfService<ApiHexReader,IApiHexReader>, IApiHexReader
    {
        public Index<ApiCodeBlock> Read(FS.FilePath src)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var buffer = sys.alloc<ApiCodeBlock>(count);
            var dst = span(buffer);
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(ApiHex.parse(line, out var row))
                    seek(dst,i) = new ApiCodeBlock(row.Uri, new CodeBlock(row.Address, row.Data));
                else
                    Wf.Error(string.Format("Could not parse line {0} from {1}", i,src.ToUri()));
            }
            return buffer;
        }
    }
}