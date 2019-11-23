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
    /// Defines a bitgrid - a maximally packed data structure - of natural dimensions over a primal type
    /// </summary>
    public readonly ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {                
        readonly Span<T> data;

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
        }

        public N Width => default;

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

        public int PointCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>(); 
        }

        public GridMoniker<T> Moniker
            => GridMoniker.FromTypes<M,N,T>();
            
        public string Format()
            => Data.FormatMatrixBits(natval(Width));

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => Data.Identical(rhs.data);
 
        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}