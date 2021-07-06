//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnumLiteral<T> eliteral<T>(uint index, string name, Constant<T> value, string desc = null)
            => new EnumLiteral<T>(index, literal(name, value), desc ?? EmptyString);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnumLiteral<T> eliteral<T>(uint index, string name, T value, string desc = null)
            => new EnumLiteral<T>(index, literal2(name, value), desc ?? EmptyString);
    }
}