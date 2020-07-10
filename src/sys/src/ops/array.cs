//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static OpacityKind;
    using static Part;
    
    partial struct sys
    {
        /// <summary>
        /// Produces an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(NotInline), Opaque(ParameterArray), Closures(Closure)]
        public static T[] array<T>(params T[] src)
            => src;

        [MethodImpl(NotInline), Opaque(SpanToArray), Closures(Closure)]
        public static T[] array<T>(Span<T> src)
            => src.ToArray();

        [MethodImpl(NotInline), Opaque(ListToArray), Closures(Closure)]
        public static T[] array<T>(List<T> src)
            => src.ToArray();


        [MethodImpl(NotInline), Opaque(EnumerableToArray), Closures(Closure)]
        public static T[] array<T>(IEnumerable<T> src)
            => src.ToArray();
    }
}