//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static partial class RootX
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Determines whether an attribute of parametric type is applied to a source type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="A">The attribute type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsAttributed<A>(this Type src)
            where A : Attribute
                => Attribute.IsDefined(src,typeof(A));

        [MethodImpl(Inline)]
        public static bool Ignore(this Type src)
            => src.IsAttributed<IgnoreAttribute>();

        /// <summary>
        /// Determines whether the enum value corresponds to a defined literal
        /// </summary>
        /// <param name="src">The enum value to check</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsLiteral<E>(this E src)
            where E : Enum
                => Enum.IsDefined(typeof(E), src);
    }
}