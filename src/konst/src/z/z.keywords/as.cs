//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(in S src)
            => ref memory.@as<S,T>(src);

        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="src">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(in S src, ref T dst)
            => ref memory.@as<S,T>(src, ref dst);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in sbyte src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in byte src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in short src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in ushort src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in int src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in uint src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in long src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in ulong src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in float src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in double src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in decimal src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in char src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in bool src)
            => ref memory.@as<T>(src);

        [MethodImpl(Inline)]
        public static ref T @as<T>(in string src)
            => ref memory.@as<T>(src);
    }
}