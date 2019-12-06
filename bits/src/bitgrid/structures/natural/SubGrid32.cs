//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= 32
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=4)]
    public readonly ref struct SubGrid32<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly BitGrid32<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;

        
        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(in Block32<T> src)
            => new SubGrid32<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(uint src)
            => new SubGrid32<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(SubGrid32<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<T>(SubGrid32<M,N,T> src)
            => new BitGrid32<T>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(BitGrid32<T> src)
            => new SubGrid32<M,N,T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(SubGrid32<M,N,T> g1, SubGrid32<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(SubGrid32<M,N,T> g1, SubGrid32<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal SubGrid32(uint src)
            => this.data = src;
        
        [MethodImpl(Inline)]
        internal SubGrid32(Block32<T> src)
            => this.data = src.As<uint>().Head;

        public uint Data
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
            get => data.CellCount;
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>();
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount => natval<N>();  

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.Cells;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref data[cell];
        }

        [MethodImpl(Inline)]
        public SubGrid32<P,Q,U> As<P,Q,U>()
            where P : unmanaged, ITypeNat
            where Q : unmanaged, ITypeNat
            where U : unmanaged
                => data.As<U>();
        
        [MethodImpl(Inline)]
        public bool Equals(SubGrid32<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}