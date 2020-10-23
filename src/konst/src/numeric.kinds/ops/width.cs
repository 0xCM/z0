//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class NumericKinds
    {
        /// <summary>
        /// Determines the width of the identified numeric type
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(NumericKind kind)
            => (TypeWidth)(ushort)kind;
    }
}