//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ImageReader
    {
        [MethodImpl(Inline), Op]
        public static PeImageReader create(ImageStream src)
            => new PeImageReader(src);
    }
}