//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct ClrPrimitives
    {
        /// <summary>
        /// Determines whether a specified type is a system-defined primitive
        /// </summary>
        /// <param name="src">The type to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Type src)
            => kind(src) != 0;
    }
}