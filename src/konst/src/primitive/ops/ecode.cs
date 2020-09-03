//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Primal
    {
        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumTypeCode ecode<E>(E e = default)
            where E : unmanaged, Enum
                => (EnumTypeCode)default(E).GetTypeCode();

        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        [MethodImpl(Inline), Op]
        public static EnumTypeCode ecode(Type src)
            => (EnumTypeCode)sys.typecode(src);
    }
}