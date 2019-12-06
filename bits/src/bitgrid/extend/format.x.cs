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
        internal static string FormatMatrixBits(this Span<byte> src, int rowlen, int? maxbits = null)            
        {
            var dst = gbits.bitchars(src);
            var sb = text();
            var limit = maxbits ?? dst.Length;

            for(var i=0; i<limit; i+= rowlen)
            {
                var remaining = dst.Length - i;
                var segment = math.min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var row = new string(rowbits.Intersperse(AsciSym.Space));                                
                sb.AppendLine(row);
            }
            return sb.ToString();
        }       

        internal static string FormatMatrixBits<T>(this Span<T> src, int rowlen, int? maxbits = null)
            where T : unmanaged
                => src.AsBytes().FormatMatrixBits(rowlen, maxbits);

        public static string Format<T>(this BitGrid<T> src, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<T>(this BitGrid32<T> src, int? cols = null, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src,cols,maxbits);

        public static string Format<T>(this BitGrid64<T> src, int? cols = null, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src,cols,maxbits);

        public static string Format<T>(this BitGrid128<T> src, int? cols = null, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src,cols,maxbits);

        public static string Format<T>(this BitGrid256<T> src, int? cols = null, int? maxbits = null)
            where T : unmanaged
                => BitGrid.format(src,cols,maxbits);

        public static string Format<M,N,T>(this BitGrid<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this BitGrid16<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this BitGrid32<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this BitGrid64<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this BitGrid128<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this BitGrid256<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this SubGrid16<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this SubGrid32<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this SubGrid64<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this SubGrid128<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

        public static string Format<M,N,T>(this SubGrid256<M,N,T> src, int? maxbits = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.format(src,maxbits);

    }
}