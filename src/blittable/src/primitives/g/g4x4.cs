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
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct g4x4<T> : IGrid<g4x4<T>,N4,T>
            where T : unmanaged
        {
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
                get => Operate.cells(ref this);
            }

            public Span<T> this[uint row]
            {
                [MethodImpl(Inline)]
                get => Operate.row(ref this, row);
            }

            public ref T this[uint row, uint col]
            {
                [MethodImpl(Inline)]
                get => ref seek(this[row], col);
            }

            public GridSpec Spec
            {
                [MethodImpl(Inline)]
                get => Types.gridspec<T>(M,N);
            }
        }
    }
}