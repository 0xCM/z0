//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Determines the system type represented by a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        public static Type SystemType(this NumericKind src)
            => NumericKinds.type(src);
    }
}