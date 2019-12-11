//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class BitGrid
    {                

        public static string format<T>(BitGrid<T> src, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => src.Data.Bytes.FormatMatrixBits(src.ColCount, maxbits ,showrow);

        public static string format<T>(BitGrid32<T> src, int? cols = null, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>(), maxbits, showrow);

        public static string format<T>(BitGrid64<T> src, int? cols = null, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? bitsize<T>(), maxbits, showrow);

        public static string format<M,N,T>(in BitGrid<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Bytes.FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(BitGrid16<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Cells.FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(BitGrid32<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Cells.FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(BitGrid64<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(in BitGrid128<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(in BitGrid256<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits, showrow);

        public static string format<M,N,T>(in SubGrid16<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? NatMath.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid32<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? NatMath.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid64<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? NatMath.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid128<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? NatMath.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid256<M,N,T> src, int? maxbits = null, bool showrow = false)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? NatMath.mul<M,N>(), showrow);

    }
}