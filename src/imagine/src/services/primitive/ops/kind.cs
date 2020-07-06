//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct Primitive
    {            
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind kind(TypeCode src)
            => skip(Kinds, (uint)src);

        [MethodImpl(Inline), Op]
        public static PrimalKind kind(Type src)
            => kind(sys.typecode(src));

        /// <summary>
        /// Specifies the primitive kind represented by the bitfield
        /// </summary>
        /// <param name="src">The source field</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind kind(PrimalKindBitField src)
            => src.Data;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static PrimalKind kind<T>()
            => kind(sys.typecode<T>());
    }
}