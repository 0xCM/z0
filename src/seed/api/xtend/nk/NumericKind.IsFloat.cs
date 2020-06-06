//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using NK = NumericKinds;
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether a numeric kind designates a floating-point type
        /// </summary>
        /// <param name="T">The type to test</param>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericKind src)
            => NK.floating(src);
    }
}