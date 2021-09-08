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

    partial struct Blit
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static g4x4<T> grid4x4<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => first(recover<T,g4x4<T>>(src));

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct g4x4<T> : IGrid<g4x4<T>,N4,T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<g4x4<T>>();

            v4<T> R0;

            v4<T> R1;

            v4<T> R2;

            v4<T> R3;

            public uint M => 4;

            public uint N => 4;

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