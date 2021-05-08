//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnumLiteral<T> eliteral<T>(uint index, Identifier name, Constant<T> value, TextBlock? desc = null)
            => new EnumLiteral<T>(index, literal(name,value), desc ?? TextBlock.Empty);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnumLiteral<T> eliteral<T>(uint index, Name name, T value, TextBlock? desc = null)
            => new EnumLiteral<T>(index, literal(name,value), desc ?? TextBlock.Empty);
    }
}