//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(UserStringHandle handle)
            => (Address32)MD.GetHeapOffset(handle);
    }
}
