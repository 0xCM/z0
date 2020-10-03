//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;

    partial class MetadataReader
    {
        [MethodImpl(Inline), Op]
        public string Read(StringHandle src)
            => Reader.GetString(src);

        [MethodImpl(Inline), Op]
        public ref string Read(StringHandle src, ref string dst)
        {
            dst = Read(src);
            return ref dst;
        }
    }
}