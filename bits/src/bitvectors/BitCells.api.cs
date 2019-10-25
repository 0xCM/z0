//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public static class BitCells
    {
        /// <summary>
        /// Allocates a 1-cell generic bitvector, optionally initialized to a specified value
        /// </summary>
        /// <param name="init">The initial value</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> Alloc<T>(T? init = null)
            where T : unmanaged
                => BitCells<T>.FromCell(init ?? default);
            
        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> Alloc<T>(int len, T? fill = null)
            where T : unmanaged
                => BitCells<T>.Alloc(len, fill);

        /// <summary>
        /// Loads a generic bitvector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> Load<T>(Span<T> src, int n)
            where T : unmanaged
                => BitCells<T>.FromCells(src, n);

        /// <summary>
        /// Defines a generic bitvector with a specified number of components and bitlength
        /// </summary>
        /// <param name="n">The number of components (bits) in the vector</param>
        /// <param name="src">The source from which the bits will be extracted</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> Load<T>(T[] src, int n)
            where T : unmanaged
                => BitCells<T>.From(src,n);

        /// <summary>
        /// Creates a generic bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitCells<T> Load<T>(params T[] src)
            where T : unmanaged
                => BitCells<T>.From(src, bitsize<T>()*src.Length);
 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>(int len)
            where T : unmanaged
            => BitCells<T>.CellCount(len);


        /// <summary>
        /// Constructs a bitvector from a primal array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this T[] src, int len)
            where T : unmanaged
                => BitCells.Load(src,len);

        /// <summary>
        /// Constructs a bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitCells.Load(src,len);

        /// <summary>
        /// Converts the leading elements of generic bitvector to an 8-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector8 ToPrimalBits<T>(this BitCells<T> src, N8 n)        
            where T : unmanaged
                => src.Data.TakeUInt8();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 64-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToPrimalBits<T>(this BitCells<T> src, N16 n)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 32-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector32 ToPrimalBits<T>(this BitCells<T> src, N32 n)
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 64-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector64 ToPrimalBits<T>(this BitCells<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();
   }
}