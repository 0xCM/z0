//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class FastOpX
    {
        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => BlockedType.test(t);

        /// <summary>
        /// Defines a block kind predicated on a fixed width and primtive identifier
        /// </summary>
        /// <param name="width">The block width</param>
        /// <param name="id">The id of the numeric primitive</param>
        [MethodImpl(Inline)]
        public static BlockKind Blocked(this FixedWidth width, NumericId id)              
            => BlockedType.kind(width,id);
    }
}