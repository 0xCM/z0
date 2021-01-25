//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.ClrEnums, true)]
    public readonly partial struct ClrEnums
    {
        [MethodImpl(Inline)]
        public static ClrEnumDetails<E> summary<E>()
            where E : unmanaged, Enum
                => default(ClrEnum<E>).Summary();

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> literals<E>(ClrEnumDetails<E> src)
            where E : unmanaged, Enum
                => src.LiteralValues;

        [MethodImpl(Inline), Op]
        public static ClrEnumDetails<Hex8Seq> summary(Hex8Seq rep)
            => summary<Hex8Seq>();

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Hex8Seq> literals(ClrEnumDetails<Hex8Seq> src)
            => literals<Hex8Seq>(src);

        [MethodImpl(Inline), Op]
        public static ClrEnumDetails<CreditTypes.ContentField> summary(CreditTypes.ContentField rep)
            => summary<CreditTypes.ContentField>();

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<CreditTypes.ContentField> literals(ClrEnumDetails<CreditTypes.ContentField> src)
            => literals<CreditTypes.ContentField>(src);
    }
}