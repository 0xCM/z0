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
        public static T force<S,T>(S src)
            => NumericCast.force<S,T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(sbyte src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(byte src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(ushort src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(short src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(int src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(uint src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(long src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(ulong src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(float src)
            => NumericCast.force<T>(src);

        [MethodImpl(Inline)]
        public static T force<T>(double src)
            => NumericCast.force<T>(src);
    }
}