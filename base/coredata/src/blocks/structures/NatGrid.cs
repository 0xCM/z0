//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;
    #pragma warning disable 414 // Disables "The field F is assigned but its value is never used" warning

    /// <summary>
    /// Defines a tabular span of dimension MxN 
    /// </summary>
    /// <typeparam name="M">The row count type</typeparam>
    /// <typeparam name="N">The row count type</typeparam>
    /// <typeparam name="T">The span element type</typeparam>
     public readonly ref struct NatGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        readonly Span<T> data;

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        public static int RowCount => nati<M>();

        /// <summary>
        /// The number of columns in the structure
        /// </summary>
        public static int ColCount => nati<N>();

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        public static int RowLenth => ColCount;

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        public static int ColLength => RowCount;

        /// <summary>
        /// The total number of allocated elements
        /// </summary>
        public static int CellCount => RowLenth * ColLength;

        public static implicit operator NatGrid<M,N,T>(T[] src)
            => new NatGrid<M, N, T>(src);

        public static implicit operator NatGrid<M,N,T>(Span<T> src)
            => new NatGrid<M, N, T>(src);

        public static implicit operator NatGrid<M,N,T>(Block256<T> src)
            => new NatGrid<M, N, T>(src);

        public static implicit operator Span<T>(NatGrid<M,N,T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<T> (NatGrid<M,N,T> src)
            => src.data;

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="U">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static NatGrid<M,N,T> CheckedTransfer(Span<T> src)
        {
            require(src.Length >= CellCount, $"length(src) = {src.Length} < {CellCount} = SpanLength");               
            return new NatGrid<M,N,T>(src);
        }

        [MethodImpl(Inline)]
        internal NatGrid(ref T src)
        {
            data = MemoryMarshal.CreateSpan(ref src, CellCount);
        }

        [MethodImpl(Inline)]        
        internal NatGrid(Span<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src;
        }

        [MethodImpl(Inline)]        
        internal NatGrid(T[] src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src;
        }

        [MethodImpl(Inline)]
        internal NatGrid(T value)
        {         
            this.data = new Span<T>(new T[CellCount]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        internal NatGrid(ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src.ToArray();
        }

        [MethodImpl(Inline)]
        internal NatGrid(Block256<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            this.data = src.Data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]        
            get => ref MemoryMarshal.GetReference(data);
        }

        public ref T this[int r, int c]
        {
            [MethodImpl(Inline)]        
            get => ref Unsafe.Add(ref Head, RowLenth*r + c);
        }

        public ref T this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, index);
        }

        /// <summary>
        /// Provides access to the underlying linear storage
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Dim<M,N> Dim 
            => default;    

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo(Span<T> dst)
            => data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public NatGrid<M,N,T> Replicate()        
            => new NatGrid<M, N, T>(data.ToArray());

        [MethodImpl(Inline)]
        bool IsRowHead(int index)
            => index == 0 || index % RowLenth == 0;

        public NatGrid<I,J,T> SubSpan<I,J>((uint r, uint c) origin, Dim<I,J> dim = default)
            where I : unmanaged, ITypeNat
            where J : unmanaged, ITypeNat
        {            
            var  dst = DataBlocks.gridalloc<I,J,T>();
            var curidx = 0;
            for(var i = origin.r; i < (origin.r + dim.I); i++)
            for(var j = origin.c; j < (origin.c + dim.J); j++)
                dst[curidx++] = this[(int)i,(int)j];

            return dst;
        }

        public ref NatBlock<M,T> Col(int col, ref NatBlock<M,T> dst)
        {
            if(col < 0 || col >= ColCount)
                ThrowOutOfRange(col, 0, ColCount - 1);

            for(var row = 0; row < ColLength; row++)
                dst[row] = data[row*RowLenth + col];
            return ref dst;
        }

        [MethodImpl(Inline)]
        public NatBlock<N,T> Row(int row)
        {
            if(row < 0 || row >= RowCount)
                throw OutOfRange(row, 0, RowCount - 1);
            
            return data.Slice(row * RowLenth, RowLenth);
        }

        [MethodImpl(Inline)]
        public NatBlock<N,T> Row<I>()
            where I : unmanaged, ITypeNat
                => Row(nati<I>());

        public NatGrid<N,M,T> Transpose()
        {
            var dst = DataBlocks.gridalloc<N,M,T>();                
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
                dst[c, r] = this[r, c];
            return dst;            
        }

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}
