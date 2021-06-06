//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    using System.IO;

    partial struct FS
    {
        [Op]
        public static Index<TextLine> lines(FilePath src)
        {
            if(!src.Exists)
                return sys.empty<TextLine>();

            var data = @readonly(File.ReadAllLines(src.Name));

            var count = data.Length;
            if(count == 0)
                return sys.empty<TextLine>();

            var buffer = sys.alloc<TextLine>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = text.line(i, skip(data,i));
            return buffer;
        }
    }
}