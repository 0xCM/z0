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

    partial struct EncodedX86
    {
        [MethodImpl(Inline), Op]
        public static ApiHexRow row(ApiHex src)
        {
            var dst = new ApiHexRow();
            row(src,ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiHexRow row(ApiHex src, ref ApiHexRow dst)
        {
            dst.Base = src.Code.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }
    }
}