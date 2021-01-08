//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;
    using static z;

    partial struct ImageMaps
    {
        /// <summary>
        /// Creates a <see cref='ImageMap'/> for the current process
        /// </summary>
        [Op]
        public static ImageMap create()
            => create(sys.CurrentProcess);

        [Op]
        public static ImageMap create(Process src)
        {
            var images = LocatedImages.index(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            var locations = sys.alloc<MemoryAddress>(count);
            ref var location = ref first(locations);
            for(var i=0; i<count; i++)
                seek(location,i) = skip(image,i).BaseAddress;
            var state = new ProcessState();
            fill(src, ref state);
            return new ImageMap(state, images, memory.sort(locations), modules(src));
        }
    }
}