//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct ClrPrimitives
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static ClrPrimalKind kind(TypeCode src)
            => skip(Kinds, (uint)src);

        [Op]
        public static ClrPrimalKind kind(Type src)
            => kind(sys.typecode(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrPrimalKind kind<T>()
            => kind(sys.typecode<T>());
    }
}