//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a grid of bits over a contiguous sequence of primal values
    /// </summary>
    public ref struct BitGrid<T>
        where T : unmanaged
    {                
        Span<T> data;

        public readonly int M;

        public readonly int N;

        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, int M, int N)
        {
            this.data = data;
            this.M = M;
            this.N = N;
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }
        
        public int SegCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.bitread(in Head,  N, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.bitset(ref Head, M, N, row, col, value);
        }

        public string Format()
            => data.FormatMatrixBits((int)N);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);
    }
}