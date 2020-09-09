//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public static partial class VXTend
    {
        /// <summary>
        /// Specifies unsigned integral types of widths <see cref='NumericWidths'/>
        /// </summary>
        public const NumericKind Closure = NumericKind.UnsignedInts;

    }
}