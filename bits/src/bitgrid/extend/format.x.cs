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
        public static string Format<T>(this BitGrid<T> src)
            where T : unmanaged
                => src.Data.Bytes.FormatMatrixBits(src.ColCount);

        public static string Format<T>(this BitGrid32<T> src, int? cols = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>());

        public static string Format<T>(this BitGrid64<T> src, int? cols = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>());

        public static string Format<T>(this BitGrid128<T> src, int? cols = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>());

        public static string Format<T>(this BitGrid256<T> src, int? cols = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>());

        public static string Format<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Bytes.FormatMatrixBits(src.ColCount);

        public static string Format<M,N,T>(this BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Cells.FormatMatrixBits(src.ColCount);

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
        
    }
}