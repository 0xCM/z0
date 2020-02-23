//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    public static class BoxedNumberExtensions
    {
        [MethodImpl(Inline)]
        public static BoxedNumber Zero(this NumericKind kind)
            => BoxOps.from(Numeric.convert(kind, 0)); 

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this short src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this int src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this long src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this float src)
            => src;

        [MethodImpl(Inline)]
        public static BoxedNumber Box(this double src)
            => src;
    }
}