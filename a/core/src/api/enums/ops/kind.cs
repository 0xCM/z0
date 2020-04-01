//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public static partial class Enums
    {
        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumNumericKind kind<E>()
            where E : unmanaged, Enum
                => (EnumNumericKind)default(E).GetTypeCode();
    }
}