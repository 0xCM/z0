// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public readonly ref struct BitMatrix<T>
        where T : unmanaged
    {                        
        readonly Span<T> data;

        public static uint N => bitsize<T>();

        [MethodImpl(Inline)]
        public static BitVector<T> operator * (BitMatrix<T> A, BitVector<T> x)
            => BitMatrix.mul(A,x);

        [MethodImpl(Inline)]
        public BitMatrix(params T[] data)
        {
            this.data = data;
        }

        [MethodImpl(Inline)]
        public BitMatrix(Span<T> data)
        {
            this.data = data;
        }

        [MethodImpl(Inline)]
        public BitMatrix(BitVector<T> fill)
        {
            this.data = new T[fill.Length];
            this.data.Fill(fill);
        }

        public ref T Head 
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowVector(row);
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data[row],col);
            
            [MethodImpl(Inline)]
            set => gbits.set(ref data[row], (byte)col, value);
        }

        /// <summary>
        /// Specifies the number of rows/columns in the matrix
        /// </summary>
        public int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < N
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        [MethodImpl(Inline)]
        public ref T Row(int row)
            => ref tail(data, row);

        [MethodImpl(Inline)]
        ref BitVector<T> RowVector(int row)
            => ref AsBitVector(ref tail(data, row));

        [MethodImpl(Inline)]
        static ref BitVector<T> AsBitVector(ref T src)
            => ref Unsafe.As<T,BitVector<T>>(ref src);

        [MethodImpl(Inline)]
        public void Update(BitMatrix<T> src)
            => src.data.CopyTo(data);

        [MethodImpl(NotInline)]
        public BitMatrix<T> Replicate()
        {
            Span<T> dst = new T[data.Length];
            data.CopyTo(dst);
            return new BitMatrix<T>(dst);
        }

        [MethodImpl(Inline)]
        public BitMatrix<S> To<S>()
            where S : unmanaged
                => new BitMatrix<S>(data.As<T,S>());        
    }
}