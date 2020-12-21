//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    public readonly struct ApiHexReader : IApiHexReader
    {
        public static IApiHexReader Service => default(ApiHexReader);

        public ApiCodeBlock[] Read(FS.FilePath src)
            => read(FS.path(src.Name));

        public static ApiCodeBlock[] read(FS.FilePath src)
        {
            var lines = @readonly(src.ReadLines());
            var count = lines.Length;
            var buffer = sys.alloc<ApiCodeBlock>(count);
            var dst = span(buffer);
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                var block = ApiHexParser.extracts(line);
                if(block)
                    seek(dst,i) = block.Value;
                 else
                    term.error(block.Message);
            }
            return buffer;
        }
    }
}