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

    /// <summary>
    /// Defines a blocked primal matrix of natural dimensions
    /// </summary>
    /// <typeparam name="M">The row count type</typeparam>
    /// <typeparam name="N">The column count type</typeparam>
    /// <typeparam name="T">The primal type</typeparam>
    public readonly ref struct MBlock256<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        readonly Block256<T> data;

        public static Dim<M,N> Dim => default;        

        /// <summary>
        /// The number of matrix rows
        /// </summary>
        public static int RowCount => nati<M>();

        /// <summary>
        /// The number of matrix colums
        /// </summary>
        public static int ColCount => nati<N>();

        /// <summary>
        /// A synonym for ColCount
        /// </summary>
        public static int RowLenth => ColCount;

        /// <summary>
        /// A synonym for RowCount
        /// </summary>
        public static int ColLength => RowCount;

        /// <summary>
        /// The total number of matrix cells
        /// </summary>
        public static int CellCount => RowLenth * ColLength;

        public static implicit operator MBlock256<M,N,T>(in Block256<T> src)
            => new MBlock256<M,N,T>(src);

        public static implicit operator NatSpan<M,N,T>(in MBlock256<M,N,T> A)
            => A.Natural;

        public static implicit operator Block256<T>(in MBlock256<M,N,T> A)
            => A.Unsized;

        [MethodImpl(Inline)]
        public static bool operator == (in MBlock256<M,N,T> A, in MBlock256<M,N,T> B) 
            => A.Equals(B);

        [MethodImpl(Inline)]
        public static bool operator != (in MBlock256<M,N,T> A, in MBlock256<M,N,T> B) 
            => !A.Equals(B);

        [MethodImpl(Inline)]
        public MBlock256(in Block256<T> src)
        {
            require(src.CellCount >= CellCount);
            data = src;
        }

        [MethodImpl(Inline)]
        internal MBlock256(in Block256<T> src, bool skipChecks)
            => data = src;

        [MethodImpl(Inline)]        
        public ref T Cell(int r, int c)
            => ref data[RowLenth*r + c];

        public ref T this[int r, int c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell(r,c);
        }

        public ref T this[uint r, uint c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell((int)r,(int)c);
        }

        [MethodImpl(Inline)]
        public VBlock256<N,T> GetRow(int row)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
            
            return Vector.blockload<N,T>(data.Slice(row * RowLenth, RowLenth));
        }

        [MethodImpl(Inline)]
        public ref VBlock256<N,T> GetRow(int row, ref VBlock256<N,T> dst)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
             var src = data.Slice(row * RowLenth, RowLenth);
             src.CopyTo(dst.Unsized);
             return ref dst;
        }

        public ref VBlock256<M,T> GetCol(int col, ref VBlock256<M,T> dst)
        {
            if(col < 0 || col >= ColCount)
                throw Errors.OutOfRange(col, 0, ColCount - 1);
            
            for(var row = 0; row < ColLength; row++)
                dst[row] = data[row*RowLenth + col];
            return ref dst;
        }

        [MethodImpl(Inline)]
        public VBlock256<M,T> GetCol(int col)
        {
            var alloc = Vector.blockalloc<M,T>();
            return GetCol(col, ref alloc);
        }

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, VBlock256<M,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Interchages rows and columns
        /// </summary>
        public MBlock256<N,M,T> Transpose()
        {
            var dst = Matrix.blockalloc<N,M,T>();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, GetRow(row));            
            return dst;
        }

        /// <summary>
        /// Provides access to the underlying data as a linear unblocked span
        /// </summary>
        public Span<T> Unblocked
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a 256-bit blocked span
        /// </summary>
        public Block256<T> Unsized
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a span of natural dimensions
        /// </summary>
        public NatSpan<M,N,T> Natural
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Applies a function to each cell and overwites the existing cell value with the result
        /// </summary>
        /// <param name="f">The function to apply</param>
        public MBlock256<M,N,T> Apply(Func<T,T> f)
        {
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
                this[r,c] = f(this[r,c]);
            return this;
        }

        public bool IsZero
        {
            get
            {
                for(var i = 0; i < data.CellCount; i++)
                    if(gmath.nonzero(data[i]))
                        return false;
                return true;
            }
        }

        public bool Equals(MBlock256<M,N,T> rhs)
        {
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
                if(!gmath.eq(this[r,c], rhs[r,c]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref MBlock256<M,N,T> CopyTo(ref MBlock256<M,N,T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public MBlock256<M,N,U> Convert<U>()
            where U : unmanaged
               => new MBlock256<M,N,U>(convert<T,U>(data));


        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public ref MBlock256<M,N,U> Convert<U>(out MBlock256<M,N,U> dst)
            where U : unmanaged
        {
            dst = new MBlock256<M,N,U>(convert<T,U>(data));
            return ref dst;
        }

        /// <summary>
        /// Reinterprets the primal type of the matrix
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public MBlock256<M,N,U> As<U>()
            where U : unmanaged
               => new MBlock256<M,N,U>(data.As<U>());

        /// <summary>
        /// Reinterprets the primal type of the matrix
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ref MBlock256<M,N,U> As<U>(out MBlock256<M,N,U> dst)
            where U : unmanaged
        {
            dst = this.As<U>();
            return ref dst;
        }

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}
