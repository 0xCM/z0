//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Core;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]    
    public readonly ref struct SubGrid16<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly ushort data;

        /// <summary>
        /// The maximum number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 2;

        /// <summary>
        /// The maximum grid width
        /// </summary>
        public static N16 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;

        [MethodImpl(Inline)]
        public static implicit operator SubGrid16<M,N,T>(in Block16<T> src)
            => new SubGrid16<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid16<M,N,T>(ushort src)
            => new SubGrid16<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(SubGrid16<M,N,T> src)
            => src.data;


        [MethodImpl(Inline)]
        public static bool operator ==(SubGrid16<M,N,T> g1, SubGrid16<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(SubGrid16<M,N,T> g1, SubGrid16<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal SubGrid16(ushort src)
            => this.data = src;
        
        [MethodImpl(Inline)]
        internal SubGrid16(Block16<T> src)
            => this.data = src.As<ushort>().Head;

        public ushort Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => ByteCount/size<T>();
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => (int)NatCalc.mul<M,N>();
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount => (int)value<M>();         

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount => (int)value<N>();  

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.AsBytes().As<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
        }

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Extracts row content as a bitvector
        /// </summary>
        public BitVector<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => BitGrid.row(this,index);
        }

        [MethodImpl(Inline)]
        public SubGrid16<M,N,U> As<U>()
            where U : unmanaged
                => new SubGrid16<M,N,U>(data);

        
        [MethodImpl(Inline)]
        public bool Equals(SubGrid16<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}