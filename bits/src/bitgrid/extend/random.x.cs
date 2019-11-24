//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class BitGridRandX
    {   
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,uint> BitGrid(this IPolyrand random, N1 m, N32 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,uint> BitGrid(this IPolyrand random, N32 m, N1 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,uint> BitGrid(this IPolyrand random, N2 m, N16 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,uint> BitGrid(this IPolyrand random, N16 m, N2 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,uint> BitGrid(this IPolyrand random, N4 m, N8 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,uint> BitGrid(this IPolyrand random, N8 m, N4 n)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,ulong> BitGrid(this IPolyrand random, N1 m, N64 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,ulong> BitGrid(this IPolyrand random, N64 m, N1 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,ulong> BitGrid(this IPolyrand random, N2 m, N32 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,ulong> BitGrid(this IPolyrand random, N32 m, N2 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> BitGrid(this IPolyrand random, N4 m, N16 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> BitGrid(this IPolyrand random, N16 m, N4 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,ulong> BitGrid(this IPolyrand random, N8 m, N8 n)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> BitGrid<T>(this IPolyrand random, N1 m, N128 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> BitGrid<T>(this IPolyrand random, N128 m, N1 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> BitGrid<T>(this IPolyrand random, N2 m, N64 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> BitGrid<T>(this IPolyrand random, N64 m, N2 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> BitGrid<T>(this IPolyrand random, N4 m, N32 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> BitGrid<T>(this IPolyrand random, N32 m, N4 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> BitGrid<T>(this IPolyrand random, N8 m, N16 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> BitGrid<T>(this IPolyrand random, N16 m, N8 n)
            where T : unmanaged            
                => random.CpuVector<T>(n128);

        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> BitGrid<T>(this IPolyrand random, N1 m, N256 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> BitGrid<T>(this IPolyrand random, N256 m, N1 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> BitGrid<T>(this IPolyrand random, N2 m, N128 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> BitGrid<T>(this IPolyrand random, N128 m, N2 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> BitGrid<T>(this IPolyrand random, N8 m, N32 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> BitGrid<T>(this IPolyrand random, N32 m, N8 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> BitGrid<T>(this IPolyrand random, N16 m, N16 n)
            where T : unmanaged            
                => random.CpuVector<T>(n256);

    }

}