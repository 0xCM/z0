//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {
        /// <summary>
        /// Determines the numeric kind of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NumericKind kind<T>()
            => NumericKinds.kind<T>();
    }
}