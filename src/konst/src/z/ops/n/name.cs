//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Specifies a name for a target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The name type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Name<S,T> name<S,T>(S src, T dst)
            => new Name<S,T>(src,dst);

        /// <summary>
        /// Defines a name
        /// </summary>
        /// <param name="src">The name content</param>
        /// <typeparam name="S">The name type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Name<S> name<S>(S src)
            => new Name<S>(src);

        /// <summary>
        /// Defines a name
        /// </summary>
        /// <param name="src">The name content</param>
        [MethodImpl(Inline), Op]
        public static Name name(string src)
            => new Name(src);
    }
}