//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Retrieves a readonly reference to the segment determined by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T readseg<T>(int bitpos, in T src)
            where T : unmanaged
                => ref skip(in src, bitpos / bitsize<T>()); 

        [MethodImpl(Inline)]
        public static bit readbit<T>(in T src, int bitpos)
            where T : unmanaged   
                => gbits.test(readseg(bitpos, in src), bitpos % bitsize<T>());

        /// <summary>
        /// Reads a bit from a grid
        /// </summary>
        [MethodImpl(Inline)]
        public static bit readbit<N,T>(N width, in T src, int row, int col)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => readbit(in src, natval<N>()*row + col);

        /// <summary>
        /// Reads a bit from a grid
        /// </summary>
        [MethodImpl(Inline)]
        public static bit readbit<T>(int width, in T src, int row, int col)
            where T : unmanaged
                => readbit(in src, width*row + col);
    }

}