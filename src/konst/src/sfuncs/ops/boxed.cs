//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SFx
    {
        /// <summary>
        /// Creates a <see cref='BoxedValueMap{T}'/> from a function
        /// </summary>
        /// <param name="f">The source function</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BoxedValueMap<T> boxed<T>(Func<object,T> f)
            where T : struct
                => boxed(f, sys.alloc<T>(1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        static BoxedValueMap<T> boxed<T>(Func<object,T> f, T[] dst)
            where T : struct
                => new ProjectorProxy<T>(f, dst);
    }
}