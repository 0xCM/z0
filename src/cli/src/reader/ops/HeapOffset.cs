//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(UserStringHandle handle)
            => (Address32)MD.GetHeapOffset(handle);
    }
}
