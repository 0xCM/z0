//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    partial class TypeApiX
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this BlockKind k)
            => k != BlockKind.None;


        [MethodImpl(Inline)]
        public static BlockWidth Width(this BlockKind kind)
            => (BlockWidth)((ushort)kind);

        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => BlockedType.test(t);

    }

}