//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class BitGrid
    {
        public static string format<M,N,T>(in BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Content.Bytes.FormatMatrixBits(z.nat32i<N>(), (int)NatCalc.mul<M,N>(), false);

        public static string format<T>(BitGrid<T> src, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => src.Content.Bytes.FormatMatrixBits(src.ColCount, maxbits ,showrow);

        public static string format<T>(BitGrid32<T> src, int? cols = null, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? (int)width<T>(), maxbits, showrow);

        public static string format<T>(BitGrid64<T> src, int? cols = null, bool showrow = false, int? maxbits = null)
            where T : unmanaged
                => src.Cells.FormatMatrixBits(cols ?? (int)width<T>(), maxbits, showrow);

        public static string format<M,N,T>(BitGrid16<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Cells.FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(BitGrid32<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Cells.FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(BitGrid64<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in BitGrid128<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in BitGrid256<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid16<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid32<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid64<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid128<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        public static string format<M,N,T>(in SubGrid256<M,N,T> src, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToSpan().FormatMatrixBits(src.ColCount, maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        static string format<M,N>(ushort data, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => z.bytes(data).FormatMatrixBits(z.nat32i<N>(), maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        static string format<M,N>(uint data, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => z.bytes(data).FormatMatrixBits(z.nat32i<N>(), maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        static string format<M,N>(ulong data, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => z.bytes(data).FormatMatrixBits(z.nat32i<N>(), maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        static string format<M,N,T>(Vector128<T> data, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => data.ToSpan().FormatMatrixBits(z.nat32i<N>(), maxbits ?? (int)NatCalc.mul<M,N>(), showrow);

        static string format<M,N,T>(Vector256<T> data, bool showrow = false, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => data.ToSpan().FormatMatrixBits(z.nat32i<N>(), maxbits ?? (int)NatCalc.mul<M,N>(), showrow);
    }
}