//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a readonly span of natural length N
    /// </summary>
    public readonly ref struct ConstNatGrid<M,N,T>
        where M : unmanaged, ITypeNat        
        where N : unmanaged, ITypeNat
    {
        readonly ReadOnlySpan<T> data;

        public static Dim<M,N> Dim => default;    

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

        public static implicit operator ReadOnlySpan<T> (ConstNatGrid<M,N,T> src)
            => src.data;
    
        public static bool operator == (ConstNatGrid<M,N,T> lhs, ConstNatGrid<M,N,T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (ConstNatGrid<M,N,T> lhs, ConstNatGrid<M,N,T> rhs)
            => lhs.data != rhs.data;
            
        [MethodImpl(Inline)]
        public ConstNatGrid(ref T src)
            => data = MemoryMarshal.CreateReadOnlySpan(ref src, CellCount);

        [MethodImpl(Inline)]
        public ConstNatGrid(ref ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public ConstNatGrid(ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            this.data = src;
        }

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => CellCount;
        }

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);
        
            
        public bool IsEmpty
            => data.IsEmpty;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}