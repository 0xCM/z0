//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Reflex
    {
        /// <summary>
        /// Returns true if the source field is a literal, false otherwise
        /// </summary>
        /// <param name="src">The field to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsLiteral(FieldInfo src)
            => src.IsLiteral;
    }
}