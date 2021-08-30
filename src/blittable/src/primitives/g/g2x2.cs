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
        public struct g2x2<T> : IGrid<g2x2<T>,N2,T>
            where T : unmanaged
        {
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
                get => Operate.gcells(ref this);
            }

            public Span<T> this[uint row]
            {
                [MethodImpl(Inline)]
                get => Operate.grow(ref this,row);
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