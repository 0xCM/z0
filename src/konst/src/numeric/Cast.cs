//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public static class Cast
    {
        /// <summary>
        /// Unconditionally casts from one numeric kind to another
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source numeric kind</typeparam>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static T to<S,T>(S src)
            => z.force<S,T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ushort src)
            => z.force<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(int src)
            => z.force<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(uint src)
            => z.force<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ulong src)
            => z.force<T>(src);
   }
}