//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using static zfunc;

    public static class EnumValues
    {     
        [MethodImpl(Inline)]
        public static EnumValues<E> Get<E>()
            where E : Enum     
                => EnumValues<E>.TheOnly;

        [MethodImpl(Inline)]
        public static EnumValues<E,T> Get<E,T>()
            where E : Enum
            where T : unmanaged
                => EnumValues<E,T>.TheOnly;

        [MethodImpl(Inline)]
        public static IReadOnlyDictionary<string,NamedValue<E>> NamedValues<E>()
            where E : Enum
                => Get<E>().NamedValues;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<NamedValue<T>> NamedScalars<E,T>()
            where E : Enum
            where T : unmanaged
                => Get<E,T>().NamedScalars;

        [MethodImpl(Inline)]
        public static Option<E> Parse<E>(string name)
            where E : Enum     
                => Get<E>().Parse(name);

        [MethodImpl(Inline)]
        public static IEnumerable<E> Enumerate<E>()
            where E : Enum     
                => Get<E>().Enumerate();

        /// <summary>
        /// Creates a generic enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumG<E> ToGeneric<E>(E src)
            where E : Enum
                => new EnumG<E>(src);
    }
}