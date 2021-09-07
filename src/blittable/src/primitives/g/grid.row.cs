//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g2x2<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g3x3<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g4x4<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g5x5<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g8x8<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);
    }
}