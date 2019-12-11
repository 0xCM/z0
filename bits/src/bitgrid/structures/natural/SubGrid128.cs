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
    /// A grid of natural dimensions M and N such that M*N <= W := 128
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct SubGrid128<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        internal readonly Vector128<T> data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The maximum grid width
        /// </summary>
        public static N128 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;
    
        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in SubGrid128<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Block128<T>(in SubGrid128<M,N,T> src)
            => src.data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(in Block128<T> src)
            => new SubGrid128<M, N, T>(src);


        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(Vector128<T> src)
            => new SubGrid128<M,N,T>(src);


        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(Vector128<byte> src)
            => new SubGrid128<M,N,T>(src.As<byte,T>());

        
        [MethodImpl(Inline)]
        internal SubGrid128(Vector128<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal SubGrid128(in Block128<T> src)
            => this.data = src.LoadVector();
        
        public Vector128<T> Data
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
        public SubGrid128<M,N,U> As<U>()
            where U : unmanaged
                => data.As<T,U>();

        [MethodImpl(Inline)]
        public bool Equals(SubGrid128<M,N,T> rhs)
            => ginx.vsame(data,rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}