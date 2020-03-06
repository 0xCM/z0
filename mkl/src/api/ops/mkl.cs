//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static Root;

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
        static ref T head<N,T>(RowVector256<N,T> src)
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

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            =>  ref MemoryMarshal.GetReference<T>(src.Data);


        [MethodImpl(Inline)]   
        static int length<S,T>(Span<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                => Checks.length(lhs,rhs);

        [MethodImpl(Inline)]   
        static int length<S,T>(RowVector256<S> lhs, RowVector256<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
    }
}