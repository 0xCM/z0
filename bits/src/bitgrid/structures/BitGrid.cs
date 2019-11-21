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
    public readonly ref struct BitGrid<T>
        where T : unmanaged
    {                
        readonly Span<T> data;

        public readonly ushort RowCount;

        public readonly ushort Width;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitGrid<T> lhs, in BitGrid<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitGrid<T> lhs, in BitGrid<T> rhs)
            => !lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, ushort rows, ushort width)
        {
            this.data = data;
            this.RowCount = rows;
            this.Width = width;
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

        public readonly GridMoniker<T> Moniker
            => GridMoniker.FromDim<T>(RowCount,Width);

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(Width, in Head, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(Width, row, col, value, ref Head);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(in Head, pos);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(pos, value, ref Head);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}