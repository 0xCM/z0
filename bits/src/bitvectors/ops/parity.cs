//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class bitvector
    {
        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components
        /// are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Bit parity(BitVector4 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components
        /// are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Bit parity(BitVector8 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components
        /// are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Bit parity(BitVector16 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components
        /// are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Bit parity(BitVector32 src)
            => odd(pop(src));

        /// <summary>
        /// Computes the parity of the source vector, which is 1 if an odd number of its components
        /// are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the 
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Bit parity(BitVector64 src)
            => odd(pop(src));
    }
}