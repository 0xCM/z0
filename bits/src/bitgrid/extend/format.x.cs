//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitGridX
    {
        public static string Format<M,N,T>(this BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount);

        public static string Format<M,N,T>(this BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount);

        public static string Format<M,N,T>(this BitGrid128<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount);

        public static string Format<M,N,T>(this BitGrid256<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount);

        public static string Format<T>(this BitGrid<T> src)
            where T : unmanaged
                => src.ToBitString().Format(blockWidth:1,rowWidth:src.Width);

        public static string Format<T>(this RowBits<T> src)
            where T : unmanaged
                => src.Bytes.FormatMatrixBits(src.RowWidth);
        
        public static string Format(this GridStats stats, int? colpad = null, char? delimiter = null)
            => GridStats.Format(stats, colpad, delimiter);
    }
}