//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    public static class Cast
    {
        /// <summary>
        /// Unconditionally casts from one numeric kind to another
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="S">The source numeric kind</typeparam>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]   
        public static T to<S,T>(S src)
            => z.convert<S,T>(src);

        [MethodImpl(Inline)]   
        public static T to<T>(sbyte src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]   
        public static T to<T>(byte src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(short src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ushort src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(int src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(uint src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(long src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ulong src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(float src)
            => z.convert<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(double src)
            => z.convert<T>(src);
   }
}