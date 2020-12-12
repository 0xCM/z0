//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(bool src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(short src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(int src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(long src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(decimal src)
            => memory.generic<T>(src);
    }
}