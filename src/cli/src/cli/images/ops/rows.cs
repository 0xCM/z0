//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    partial struct ImageMaps
    {
        [Op]
        static Index<ProcessImageRow> rows(Index<LocatedImage> src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<ProcessImageRow>(count);
            var summaries = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var dst = ref seek(summaries,i);
                dst.BaseAddress = image.BaseAddress;
                dst.EndAddress = image.EndAddress;
                dst.MemorySize = image.Size;
                dst.ImageName = image.Name;

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    dst.Gap = gap;
                }
            }

            return buffer;
        }
    }
}