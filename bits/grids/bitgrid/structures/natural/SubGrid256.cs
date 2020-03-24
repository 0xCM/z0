//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= W := 256
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]    
    public readonly ref struct SubGrid256<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        internal readonly Vector256<T> data;

        /// <summary>
        /// The maximum number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 32;

        /// <summary>
        /// The maximum grid width
        /// </summary>
        public static W256 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;        

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(in SubGrid256<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Block256<T>(in SubGrid256<M,N,T> src)
            => src.data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator SubGrid256<M,N,T>(in Block256<T> src)
            => new SubGrid256<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid256<M,N,T>(Vector256<T> src)
            => new SubGrid256<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid256<M,N,T>(Vector256<byte> src)
            => new SubGrid256<M,N,T>(src.As<byte,T>());
        
        [MethodImpl(Inline)]
        internal SubGrid256(Vector256<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal SubGrid256(in Block256<T> src)
            => this.data = src.LoadVector();
        
        public Vector256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.ToSpan<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public int ColCount => natval<N>();  

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>();
        }

        /// <summary>
        /// Reads an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public T Cell(int cell)
            => data.GetElement(cell);

        [MethodImpl(Inline)]
        public SubGrid256<M,N,U> As<U>()
            where U : unmanaged
                => data.As<T,U>();

        [MethodImpl(Inline)]
        public bool Equals(SubGrid256<M,N,T> rhs)
            => gvec.vsame(data,rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}