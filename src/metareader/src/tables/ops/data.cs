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

    partial class PeTableReader
    {
        [MethodImpl(Inline), Op]
        public static BinaryCode data(MetadataReader src, BlobHandle handle)
            => src.GetBlobBytes(handle);

        [MethodImpl(Inline), Op]
        public static string data(MetadataReader src, StringHandle handle)
            => src.GetString(handle);
    }
}