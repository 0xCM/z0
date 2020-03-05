//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <typeparam name="T">The value type, if the value existed</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> none<T>()
            => Option.none<T>();

        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> some<T>(T value)
            => Option.some(value);

        /// <summary>
        /// Casts a value if possible, otherwise returns none
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="item">The object to cast</param>
        [MethodImpl(Inline)]   
        public static Option<T> TryCast<T>(object item)
            => item is T ? some((T)item) : none<T>();
    }
}