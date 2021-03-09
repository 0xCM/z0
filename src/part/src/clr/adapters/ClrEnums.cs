//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.ClrEnums, true)]
    public readonly partial struct ClrEnums
    {
        [MethodImpl(Inline)]
        public static ClrEnumDetails<E> summary<E>()
            where E : unmanaged, Enum
                => default(ClrEnum<E>).Summary();

        [MethodImpl(Inline), Op]
        public static ClrEnumDetails<Hex8Seq> summary(Hex8Seq rep)
            => summary<Hex8Seq>();

        [MethodImpl(Inline), Op]
        public static ClrEnumDetails<CreditTypes.ContentField> summary(CreditTypes.ContentField rep)
            => summary<CreditTypes.ContentField>();

    }
}