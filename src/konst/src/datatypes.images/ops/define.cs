//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;
    using System.IO;

    using static Part;
    using static memory;

    partial struct ImageMaps
    {
       /// <summary>
        /// Creates a <see cref='ImageMap'/> for the current process
        /// </summary>
        [Op]
        public static ImageMap define()
            => define(sys.CurrentProcess);

        [Op]
        public static ImageMap define(Process src)
        {
            var images = index(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            var locations = alloc<MemoryAddress>(count);
            ref var location = ref first(locations);
            for(var i=0; i<count; i++)
                seek(location,i) = skip(image,i).BaseAddress;
            var state = new ProcessState();
            fill(src, ref state);
            return new ImageMap(state, images, memory.sort(locations), modules(src));
        }
    }
}