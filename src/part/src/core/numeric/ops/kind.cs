//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using NK = NumericKind;
    using TC = System.TypeCode;
    using NI = NumericIndicator;
    using NW = NumericWidth;
    using EK = ClrEnumKind;

    partial struct Numeric
    {
        /// <summary>
        /// Determines the numeric kind of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NK kind<T>()
            => NumericKinds.kind<T>();
    }
}