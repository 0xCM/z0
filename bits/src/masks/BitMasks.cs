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

    public static partial class BitMasks
    {                
        /// <summary>
        /// Defines a mask that disables a sequence of bits
        /// </summary>
        /// <param name="start">The index at which to begin</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The primal type over which the mask is defined</typeparam>
        [MethodImpl(Inline)]
        public static T eraser<T>(int start, int count)
            where T : unmanaged
                => gmath.xor(gmath.maxval<T>(), gmath.sll(gbits.lomask<T>(count - 1), start));

        /// <summary>
        /// [00000001 ... 00000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(dinx.scatter(convert<T,ulong>(src), Lsb64x8));

        /// <summary>
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb32x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(dinx.scatter(convert<T,ulong>(src), Lsb64x32));

    }

}