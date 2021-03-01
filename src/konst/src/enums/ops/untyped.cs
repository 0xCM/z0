//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static EnumDatasetEntry untyped<E,T>(in EnumDatasetEntry<E,T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumDatasetEntry(src.Token, src.EnumId, src.Index, src.Name, Variant.from(src.ScalarValue), src.Description);

    }
}