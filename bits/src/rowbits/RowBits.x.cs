//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class RowBitsX
    {
        public static string Format<T>(this RowBits<T> src)
            where T : unmanaged
                => src.Bytes.FormatMatrixBits(src.RowWidth);

        [MethodImpl(Inline)]
        public static RowBits<T> Replicate<T>(this RowBits<T> src)
            where T : unmanaged
                => new RowBits<T>(src.data.Replicate());
    }

}
