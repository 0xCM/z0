//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    using static BitGrid;
    using static ginx;
    using static As;

    public static partial class GridPattern
    {
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,T> identity<T>(N16 w, N4 m, N4 n, T t = default)
            where T : unmanaged
        {
            const ushort pattern = 0b1000_0100_0010_0001;
            return init(w,m,n,pattern).As<T>();
        }

        [MethodImpl(Inline)]
        public static SubGrid32<N5,N5,T> identity<T>(N32 w, N5 m, N5 n, T t = default)
            where T : unmanaged
        {
            const uint pattern = 0b10000_01000_00100_00010_00001;
            return subgrid(w,pattern,m,n).As<T>();
        }

        [MethodImpl(Inline)]
        public static SubGrid64<N6,N6,T> identity<T>(N64 w, N6 m, N6 n, T t = default)
            where T : unmanaged
        {
            const ulong pattern = 0b100000_010000_001000_000100_000010_000001;
            return subgrid(w,pattern,m,n).As<T>();
        }

        [MethodImpl(Inline)]
        public static SubGrid64<N7,N7,T> identity<T>(N64 w, N7 m, N7 n, T t = default)
            where T : unmanaged
        {
            const ulong pattern = 0b100000_010000_0010000_0001000_0000100_0000010_0000001;
            return subgrid(w,pattern,m,n).As<T>();
        }

        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> identity<T>(N64 w, N8 m, N8 n, T t = default)
            where T : unmanaged
        {
            const ulong pattern = 0b10000000_01000000_00100000_00010000_00001000_00000100_00000010_00000001;
            return init(w,m,n,pattern).As<T>();
        }

        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> identity<T>(N256 w, N16 m, N16 n, T t = default)
            where T : unmanaged
        {
            var x = vmakemask<T>(BitMask.lsb(n2,n1,z32),0);
            var offsets = VPattern.vincrements<T>(w);
            var pattern = vsllv(x,offsets);
            return pattern;
        }

        /// <summary>
        /// Defines an anti-identity matrix pattern with ones on the anti-diagonal and zeroes elsewhere
        /// </summary>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count selector</param>
        /// <param name="n">The col count selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Exchange_matrix</remarks>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> exchange<T>(N256 w, N16 m, N16 n, T t = default)
            where T : unmanaged
        {
            var x = vmakemask<T>(BitMask.msb<uint>(n2,n1));
            var offsets = VPattern.vincrements<T>(w);
            var pattern = vsrlv(x,offsets);
            return pattern;
        }

        [MethodImpl(Inline)]
        public static SubGrid256<M,N,T> stripes<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => CpuVector.vbroadcast(w, BitMask.lsb(n64,n2,n1,t));            

        [MethodImpl(Inline)]
        public static SubGrid256<M,N,T> bars<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var sep = natval(n);
            var pattern = BitMask.lo(sep, z64) << sep;                        
            return vgeneric<T>(CpuVector.vbroadcast(w,gbits.replicate(pattern)));
        }

    }
}
