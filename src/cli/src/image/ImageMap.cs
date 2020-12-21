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
        readonly LocatedImageIndex Images;

        readonly MemoryAddresses Locations;

        [MethodImpl(Inline)]
        internal ImageMap(LocatedImageIndex images, MemoryAddresses locations)
        {
            Images = images;
            Locations = locations;
        }
    }
}