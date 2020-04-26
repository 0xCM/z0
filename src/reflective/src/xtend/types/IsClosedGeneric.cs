//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type is a constructed generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsClosedGeneric(this Type t, bool effective = true)
            => effective ? t.EffectiveType().IsConstructedGenericType : t.IsConstructedGenericType;
    }
}