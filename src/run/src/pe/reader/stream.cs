//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ImageReader
    {
        [MethodImpl(Inline)]
        public static ImageStream stream(Stream src, bool @virtual)
            => new ImageStream(src, @virtual);

        [MethodImpl(Inline)]
        public static ImageStream stream(FS.FilePath src)
            => new ImageStream(File.OpenRead(src.Name), false);
    }
}