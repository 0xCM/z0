//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class BitVector
    {
        /// <summary>
        /// Computes the parity of a generic bitvector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity<T>(BitVector<T> src)
            where T : unmanaged
                => odd(gbits.pop(src.Scalar));

        /// <summary>
        /// Computes the parity of a natural bitvector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => odd(gbits.pop(src.Scalar));

        /// <summary>
        /// Computes the parity of the source vector
        /// </summary>
        [MethodImpl(Inline)]
        public static bit parity<N,T>(in BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(BitVector4 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(BitVector8 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(BitVector16 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(BitVector32 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(BitVector64 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity(in BitVector128 src)
            => odd(pop(src));
    }
}