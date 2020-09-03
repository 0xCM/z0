//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct LookupGrid<I,J,S,T>
        where I : unmanaged
        where J : unmanaged
        where S : unmanaged
    {
        internal readonly S[,] Index;

        internal readonly T[] Values;

        [MethodImpl(Inline)]
        internal LookupGrid(S[,] src, T[] dst)
        {
            Index = src;
            Values = dst;
        }

        public ref T this[I i, J j]
        {
            [MethodImpl(Inline)]
            get => ref Values[uint64(Index[uint64(i), uint64(j)])];
        }
    }

    public readonly ref struct LookupGrid2<I,J,S,T>
        where I : unmanaged
        where J : unmanaged
        where S : unmanaged
    {
        readonly ReadOnlySpan<S> I0;

        readonly ReadOnlySpan<S> I1;

        readonly Span<T> Storage;

        [MethodImpl(Inline)]
        internal LookupGrid2(ReadOnlySpan<S> i0, ReadOnlySpan<S> i1, Span<T> cells)
        {
            I0 = i0;
            I1 = i1;
            Storage = cells;
        }

        public uint Rows
        {
            [MethodImpl(Inline)]
            get => (uint)I0.Length;
        }

        public uint Cols
        {
            [MethodImpl(Inline)]
            get => (uint)I1.Length;
        }

        public GridDim Dim
        {
            [MethodImpl(Inline)]
            get => (I0.Length, I1.Length);
        }

        public ref T this[I i, J j]
        {
            [MethodImpl(Inline)]
            get => ref Cell(i,j);
        }

        [MethodImpl(Inline)]
        public ref T Cell(I i, J j)
        {
            var row = uint64(i);
            var col = uint64(j);
            var index = row*Cols + col;
            return ref seek(Storage,index);
        }
    }
}