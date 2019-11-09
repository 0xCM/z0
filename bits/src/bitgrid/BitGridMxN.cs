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
    /// Defines a bitgrid of natural dimensions over a primal type
    /// </summary>
    public ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {                
        Span<T> data;

        readonly GridMoniker<T> moniker;

        [MethodImpl(Inline)]
        public static bool operator ==(BitGrid<M,N,T> lhs, BitGrid<M,N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitGrid<M,N,T> lhs, BitGrid<M,N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data)
        {
            this.data = data;
            this.moniker = BitGrid.moniker<M,N,T>();
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

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetState(row,col);

            [MethodImpl(Inline)]
            set => SetState(row,col,value);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => GetState(pos);

            [MethodImpl(Inline)]
            set => SetState(pos, value);
        }

        public GridMoniker<T> Moniker
        {
            [MethodImpl(Inline)]
            get => moniker;
        }
            
        [MethodImpl(Inline)]
        public bit GetState(int row, int col)
            => BitGrid.readbit(Moniker, in Head, row, col);

        [MethodImpl(Inline)]
        public bit GetState(int bitpos)
            => BitGrid.readbit(in Head, bitpos);

        [MethodImpl(Inline)]
        public void SetState(int row, int col, bit state)
            => BitGrid.setbit(Moniker, row, col, state, ref Head);

        [MethodImpl(Inline)]
        public void SetState(int bitpos, bit state)
            => BitGrid.setbit(bitpos, state, ref Head);

        public string Format()
            => data.FormatMatrixBits(Moniker.ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => data.Identical(rhs.data);
 
        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}