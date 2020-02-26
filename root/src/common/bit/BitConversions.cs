//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    [ApiHost]
    public static class BitConversions
    {        
        [MethodImpl(Inline)]
        static BitConversion BitConverter()
            => default(BitConversion);
        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T convert<T>(bit src)
            where T : unmanaged
                => BitConverter().Convert<T>(src);

        [MethodImpl(Inline),Op, NumericClosures(NumericKind.UnsignedInts)]
        public static bit convert<T>(T src)
            where T : unmanaged
                => BitConverter().Convert(src);
    }
}