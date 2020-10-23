//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    partial class XNumericKinds
    {
        /// <summary>
        /// Determines the system type represented by a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static Type SystemType(this NumericKind src)
            => type(src);

        [MethodImpl(Inline), Op]
        public static TypeCode TypeCode(this NumericKind src)
            => Type.GetTypeCode(type(src));

        [MethodImpl(Inline), Op]
        public static NumericKind ToNumericKind(this NumericWidth width, NumericIndicator indicator)
            => NumericKinds.kind(width, indicator);
    }
}