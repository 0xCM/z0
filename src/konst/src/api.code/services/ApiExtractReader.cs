//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    public readonly struct ApiExtractReader : IApiExtractReader
    {
        public static IApiExtractReader Service => default(ApiExtractReader);

        public ApiExtractBlock[] Read(FS.FilePath src)
            => read(FS.path(src.Name));

        public static ApiExtractBlock[] read(FS.FilePath src)
        {
            var lines = src.ReadLines().View;
            var count = lines.Length;
            var buffer = sys.alloc<ApiExtractBlock>(count);
            var dst = span(buffer);
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                var block = ApiExtractParser.extracts(line);
                if(block)
                    seek(dst,i) = block.Value;
                 else
                    term.error(block.Message);
            }
            return buffer;
        }
    }
}