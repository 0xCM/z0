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

    partial struct Literals
    {
        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op]
        public static NumericKind kind(BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();
    }
}