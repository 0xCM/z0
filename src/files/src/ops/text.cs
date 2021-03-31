//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    partial struct FS
    {
        [Op]
        public static TextLines text(FilePath src)
        {
            if(!src.Exists)
                return sys.empty<TextLine>();

            var data = lines(src).View;
            var count = data.Length;
            if(count == 0)
                return sys.empty<TextLine>();

            var buffer = sys.alloc<TextLine>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = Z0.text.line(i, skip(data,i));
            return buffer;
        }
    }
}