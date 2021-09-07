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
        public struct g5x5<T> : IGrid<g5x5<T>,N2,T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<g5x5<T>>();

            v5<T> R0;

            v5<T> R1;

            v5<T> R2;

            v5<T> R3;

            v5<T> R4;

            public uint M => 5;

            public uint N => 5;

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
                get => Operate.row(ref this,row);
            }

            public ref T this[uint row, uint col]
            {
                [MethodImpl(Inline)]
                get => ref seek(this[row], col);
            }

            public GridSpec Spec
            {
                [MethodImpl(Inline)]
                get => Meta.grid<T>(M,N);
            }
        }
    }
}