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

    partial class XReflex
    {
        /// <summary>
        /// Returns the arguments supplied to a constructed generic method; if the method is
        /// nongeneric, a generic type definition or some other variant, an empty result is returned
        /// </summary>
        /// <param name="src">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static Type[] GenericArguments(this MethodInfo src)
            => src.IsConstructedGenericMethod  ? src.GetGenericArguments()  : sys.empty<Type>();
    }
}