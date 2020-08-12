//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Images
    {
        [MethodImpl(Inline), Op]
        public static SourceStream source(Stream src, bool virt = false)
            => new SourceStream(src,virt);
    }
}