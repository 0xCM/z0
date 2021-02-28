//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct Settings
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> empty<T>()
            => Setting<T>.Empty;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> define<T>(string name, T value)
            => new Setting<T>(name,value);

        /// <summary>
        /// Renders a k/v pair as a setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        [MethodImpl(Inline), Op]
        public static string format<K,V>(K key, V value)
            => string.Format(RP.Setting, key, value);
    }
}