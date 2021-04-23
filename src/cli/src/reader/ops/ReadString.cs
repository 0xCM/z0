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
    using static Images;
    using static Part;
    using static memory;

    partial class ImageMetaReader
    {

        [MethodImpl(Inline), Op]
        public string ReadString(StringHandle src)
            => MD.GetString(src);

        [MethodImpl(Inline), Op]
        public ref string ReadString(StringHandle src, ref string dst)
        {
            dst = ReadString(src);
            return ref dst;
        }
    }
}