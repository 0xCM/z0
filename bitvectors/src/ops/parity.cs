//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    using P = parity;

    partial class BitVector
    {
        /// <summary>
        /// Computes the parity of a generic bitvector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit parity<T>(BitVector<T> src)
            where T : unmanaged
                => P.odd(gbits.pop(src.Scalar));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bit parity(BitVector4 src)
            => P.odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bit parity(BitVector8 src)
            => P.odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bit parity(BitVector16 src)
            => P.odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bit parity(BitVector32 src)
            => P.odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bit parity(BitVector64 src)
            => P.odd(pop(src));
    }
}