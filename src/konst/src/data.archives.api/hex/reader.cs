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
        public static IApiCodeReader reader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiCodeReader))
                return new ApiCodeReader();
            else
                throw no<H>();
        }
    }
}