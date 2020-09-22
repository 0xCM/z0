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
        public static ApiHexRow row(X86ApiCode src)
        {
            var dst = new ApiHexRow();
            row(src,ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiHexRow row(X86ApiCode src, ref ApiHexRow dst)
        {
            dst.Base = src.Encoded.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.OpUri.Format();
            return ref dst;
        }
    }
}