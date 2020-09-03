//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline)]
        public static PrimalKind primal(TypeCode src)
            => Primal.kind(src);

        [MethodImpl(Inline)]
        public static PrimalKind primal(Type src)
            => Primal.kind(src);

        [MethodImpl(Inline)]
        public static PrimalKind primal<T>()
            => Primal.kind<T>();
    }
}