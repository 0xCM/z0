// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static root;

    /// <summary>
    /// Defines a square bitmatrix with order determined by the primal type over which it is defined
    /// The intent is to provide a primal bitmatrix generalization 
    /// </summary>
    [StructLayout(LayoutKind.Sequential), IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public readonly ref struct BitMatrix<T>
        where T : unmanaged
    {                        
        readonly Span<T> data;

        public static int N => bitsize<T>();

        [MethodImpl(Inline)]
        public static BitVector<T> operator * (BitMatrix<T> A, BitVector<T> x)
            => BitMatrix.mul(A,x);

        [MethodImpl(Inline)]
        internal BitMatrix(Span<T> data)
            => this.data = data;

        [MethodImpl(Inline)]
        internal BitMatrix(BitVector<T> fill)
        {
            this.data = new T[fill.Width];
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

        /// <summary>
        /// Specifies the number rows/columns
        /// </summary>
        public int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        public ref BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ref AsBitVector(ref head(data, row));
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data[row],col);
            
            [MethodImpl(Inline)]
            set => data[row] = gbits.set(data[row], (byte)col, value);
        }

        [MethodImpl(Inline)]
        static ref BitVector<T> AsBitVector(ref T src)
            => ref Unsafe.As<T,BitVector<T>>(ref src);

        [MethodImpl(Inline)]
        public BitMatrix<S> As<S>()
            where S : unmanaged
                => new BitMatrix<S>(Data.As<T,S>());        
    }
}