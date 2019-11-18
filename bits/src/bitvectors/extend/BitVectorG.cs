//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        /// <summary>
        /// Constructs a generic bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this BitString src)
            where T : unmanaged
                => BitVector.from<T>(src);

        [MethodImpl(Inline)]
        public static BitCells<T> ToCells<T>(this BitVector<T> src)
            where T : unmanaged
                => BitCells.load(src.Data);

        /// <summary>
        /// Defines an 8-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToBitVectorG(this byte src)
            => src;

        /// <summary>
        /// Defines a 16-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToBitVectorG(this ushort src)
            => src;

        /// <summary>
        /// Defines a 32-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToBitVectorG(this uint src)
            => src;

        /// <summary>
        /// Defines a 64-bit generic bitvector from an unsigned integer of commensurate width
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToBitVectorG(this ulong src)
            => src;        

    }

}