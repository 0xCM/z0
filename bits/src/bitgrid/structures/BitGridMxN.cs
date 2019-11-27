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
    /// Defines a maximally packed data structure of natural dimensions over a primal type
    /// </summary>
    public readonly ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {                
        readonly Block256<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static Dim<M,N> Dim => default;

        [MethodImpl(Inline)]
        public static bit operator ==(in BitGrid<M,N,T> g1, in BitGrid<M,N,T> g2)
            => BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitGrid<M,N,T> g1, in BitGrid<M,N,T> g2)
            => !BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        internal BitGrid(Block256<T> data)
        {
            this.data = data;
        }

        public Block256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        public N BitWidth => default;

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => natval<M>();
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        public int PointCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>(); 
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(BitWidth, in Head, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(BitWidth, row, col, value, ref Head);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(in Head, pos);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(pos, value, ref Head);
        }

        public GridMoniker<T> Moniker
            => GridMoniker.FromTypes<M,N,T>();
            
        public string Format()
            => Data.Bytes.FormatMatrixBits(natval(BitWidth));

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => Data.Identical(rhs.data);
 
        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}