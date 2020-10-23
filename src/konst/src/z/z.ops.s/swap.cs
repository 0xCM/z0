//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static void swap<T>(ref T lhs, ref T rhs)
            => Swaps.swap(ref lhs, ref rhs);

        [MethodImpl(Inline)]
        public static unsafe void swap<T>(T* pLhs, T* pRhs)
            where T : unmanaged
                => Swaps.swap(pLhs, pRhs);

        [MethodImpl(Inline)]
        public static void swap<T>(Span<T> src, uint i, uint j)
            where T : unmanaged
                => Swaps.swap(src, i, j);
    }
}