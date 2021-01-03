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

    [ApiHost("api")]
    public partial class BitFields
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(K kind = default, T rep = default)
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind);

        [MethodImpl(Inline)]
        public static BitField64<E> bf64<E>(E state)
            where E : unmanaged, Enum
                => new BitField64<E>(state);

        [MethodImpl(Inline), Op]
        public static string format(BitField32 src)
        {
            var count = BitField32.BitCount;
            Span<char> dst = stackalloc char[count];
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src.View,i).ToChar();
            return new string(dst);
        }
    }
}