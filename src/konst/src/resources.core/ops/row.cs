//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public unsafe static TextResourceRow row(in TextResource src)
        {
            var dst = new TextResourceRow();
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Length = (uint)src.Value.Length;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public unsafe static ref TextResourceRow row(in TextResource src, out TextResourceRow dst)
        {
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Length = (uint)src.Value.Length;
            return ref dst;
        }
    }
}