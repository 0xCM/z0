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
        public struct g8x8<T>
            where T : unmanaged
        {
            v8<T> R0;

            v8<T> R1;

            v8<T> R2;

            v8<T> R3;

            v8<T> R4;

            v8<T> R5;

            v8<T> R6;

            v8<T> R7;

            public uint M => 8;

            public uint N => 8;

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

            public Span<T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => Operate.grow(ref this,i);
            }

            public GridSpec Spec
            {
                [MethodImpl(Inline)]
                get => Types.gridspec<T>(M,N);
            }
        }
    }
}