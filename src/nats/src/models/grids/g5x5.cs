//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Vec;

    using static Root;
    using static core;
    using static Grids;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct g5x5<T> : IGrid<g5x5<T>,N2,T>
        where T : unmanaged
    {
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
            get => spec<T>(M,N);
        }
    }
}