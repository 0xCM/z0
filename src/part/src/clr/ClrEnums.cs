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
        public static ClrEnum<E> @enum<E>()
            where E : unmanaged, Enum
                => default;
    }
}