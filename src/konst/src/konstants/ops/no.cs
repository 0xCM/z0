//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct Konst
    {
        /// <summary>
        /// Populates a <see cref="NotSupportedException"/> complaining that a 
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        [MethodImpl(Inline), Closures(AllNumeric)]
        public static NotSupportedException no<T>()
            => Unsupported.define<T>();

        [MethodImpl(Inline), Closures(AllNumeric)]
        public static T bad<T>()
            => Unsupported.raise<T>();

        public static T no<S,T>()
            => Unsupported.raise<T>($"The transformation {typeof(S).Name} -> {typeof(T).Name} is undefined");
    }
}