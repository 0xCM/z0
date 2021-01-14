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
        public static EnumValues<E,T> index<E,T>(EnumValue<E,T>[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumValues<E,T>(src);

        /// <summary>
        /// Gets the declaration-order indices for each named literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static EnumLiteralDetails<E> index<E>()
            where E : unmanaged, Enum
                => (EnumLiteralDetails<E>)IndexCache.GetOrAdd(typeof(E), _ => details<E>());
    }
}