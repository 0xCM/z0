//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ImageMap
    {
        public static ImageMap load(LocatedImageIndex images, MemoryAddress[] locations)
        {
            Array.Sort(locations);
            return new ImageMap(images, memory.sort(locations));
        }

        readonly LocatedImageIndex Images;

        readonly MemoryAddresses Locations;

        [MethodImpl(Inline)]
        ImageMap(LocatedImageIndex images, MemoryAddresses locations)
        {
            Images = images;
            Locations = locations;
        }
    }
}