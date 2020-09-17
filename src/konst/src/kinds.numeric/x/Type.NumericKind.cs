//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    partial class XTend
    {
        /// <summary>
        /// Determines the numeric kind of a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static NumericKind NumericKind(this Type src)
            => kind(src);
    }
}