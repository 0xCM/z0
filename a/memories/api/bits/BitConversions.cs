//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    [ApiHost]
    public static class BitConversions
    {        
        [MethodImpl(Inline)]
        static BitDataTypeConverter BitConverter()
            => default(BitDataTypeConverter);
        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T convert<T>(bit src)
            where T : unmanaged
                => BitConverter().Convert<T>(src);

        [MethodImpl(Inline),Op, NumericClosures(NumericKind.UnsignedInts)]
        public static bit convert<T>(T src)
            where T : unmanaged
                => BitConverter().Convert(src);                
    }

    public static class SignOps
    {
        public static bit IsPositive(this Sign src)
            => src == Sign.Pos;

        public static bit IsNonNegative(this Sign src)
            => src != Sign.Neg;
        
        public static bit IsNegative(this Sign src)
            => src == Sign.Neg;

        public static bit IsUnspecified(this Sign src)
            => src == 0;
    }
}