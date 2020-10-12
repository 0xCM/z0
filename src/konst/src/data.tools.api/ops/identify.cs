//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Tools
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolId<T> identify<T>()
            => default;

        /// <summary>
        /// Creates a type-predicated tool identifier
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ToolId identify(Type t)
            => new ToolId(t);
    }
}