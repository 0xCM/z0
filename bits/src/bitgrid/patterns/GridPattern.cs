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
    using static BitGrid;
    public static partial class GridPattern
    {
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,T> identity<T>(N16 w, N4 m, N4 n, T t = default)
            where T : unmanaged
        {
            const ushort pattern = 0b1000_0100_0010_0001;
            return alloc(w,m,n,pattern).As<T>();
        }

        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> identity<T>(N64 w, N8 m, N8 n, T t = default)
            where T : unmanaged
        {
            const ulong pattern = 0b10000000_01000000_00100000_00010000_00001000_00000100_00000010_00000001;
            return alloc(w,m,n,pattern).As<T>();
        }

    }
}
