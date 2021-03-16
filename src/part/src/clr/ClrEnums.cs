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
        public static ClrEnumInfo<E> describe<E>()
            where E : unmanaged, Enum
                => default(ClrEnum<E>).Describe();

        [MethodImpl(Inline), Op]
        public static ClrEnumInfo<Hex8Seq> describe(Hex8Seq rep)
            => describe<Hex8Seq>();
    }
}