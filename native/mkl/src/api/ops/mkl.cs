//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// mkl + u = Unsafe, Unsized, Unchecked and Unblocked
    /// </summary>
    public static partial class mklu
    {

    }

    public static partial class mkl
    {
        const BlasTrans NoTranspose = BlasTrans.None;

        const BlasLayout RowMajor = BlasLayout.RowMajor;

        [MethodImpl(Inline)]
        static int checkx(int exit)
        {
            if(exit < 0)
                throw MklException.Define(exit);
            return exit;
        }

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(RowVector256<T> src)
            where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(Block256<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(Matrix256<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<M,N,T>(Matrix256<M,N,T> src)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<T>(Span<T> src)
            =>  ref MemoryMarshal.GetReference<T>(src);

        [MethodImpl(Inline)]
        static int length<T>(RowVector256<T> lhs, RowVector256<T> rhs)
            where T : unmanaged
                => root.min(lhs.Length, rhs.Length);
    }
}