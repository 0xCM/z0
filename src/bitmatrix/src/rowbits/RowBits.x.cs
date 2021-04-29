//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    public static class RowBitsX
    {
        public static string Format<T>(this RowBits<T> src)
            where T : unmanaged
                => src.Bytes.FormatBitRows(src.RowWidth);

        public static RowBits<T> Replicate<T>(this RowBits<T> src)
            where T : unmanaged
                => new RowBits<T>(src.data.Replicate());
    }
}
