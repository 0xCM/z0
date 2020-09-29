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

    partial struct ApiHexArchives
    {
        [MethodImpl(Inline)]
        public static ApiCodeWriter writer<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiCodeWriter))
                return new ApiCodeWriter(dst);
            else
                throw no<H>();
        }
    }
}