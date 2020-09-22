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

    partial struct ApiCodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref ApiCodeRow row(ApiCodeBlock src, ref ApiCodeRow dst)
        {
            dst.Base = src.Code.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }
    }
}