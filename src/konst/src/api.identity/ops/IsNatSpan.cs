//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Determines whether a type is a natural span
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsNatSpan(Type t)
            => t.GenericDefinition2() == typeof(NatSpan<,>) && t.IsClosedGeneric();
    }
}