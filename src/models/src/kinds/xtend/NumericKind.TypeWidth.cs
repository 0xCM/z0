//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Determines the width of a numeric kind
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline)]
        public static TypeWidth TypeWidth(this NumericKind kind)
            => NumericKinds.width(kind);
    }
}