//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static g2x2<T> grid2x2<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => first(recover<T,g2x2<T>>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref g2x2<T> src)
            where T : unmanaged
                => ref @as<g2x2<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref g2x2<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.MxN);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> row<T>(ref g2x2<T> src, uint i)
            where T : unmanaged
                => slice(cells(ref src),i*src.N,src.M);

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct g2x2<T> : IGrid<g2x2<T>,N2,T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<g2x2<T>>();

            v2<T> R0;

            v2<T> R1;

            public uint M => 2;

            public uint N => 2;

            public uint MxN => M*N;

            public GridDim Dim
            {
                [MethodImpl(Inline)]
                get => (M,N);
            }

            public BitWidth StorageWidth
            {
                [MethodImpl(Inline)]
                get => M*N*size<T>();
            }

            public BitWidth ContentWidth
            {
                [MethodImpl(Inline)]
                get => StorageWidth;
            }

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => cells(ref this);
            }

            public Span<T> this[uint r]
            {
                [MethodImpl(Inline)]
                get => row(ref this, r);
            }

            public ref T this[uint r, uint c]
            {
                [MethodImpl(Inline)]
                get => ref seek(this[r], c);
            }

            public GridSpec Spec
            {
                [MethodImpl(Inline)]
                get => Meta.grid<T>(M,N);
            }
        }
    }
}