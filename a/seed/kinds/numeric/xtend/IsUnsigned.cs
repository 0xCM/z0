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
        /// Determines whether a numeric kind designates an unsigned integral type
        /// </summary>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericKind src)
            => NK.unsigned(src);
    }
}