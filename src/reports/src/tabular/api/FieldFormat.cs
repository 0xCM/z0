//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class FieldFormat
    {
        /// <summary>
        /// Creates field formatter with field widths determined by a parametric enum
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static FieldFormatter<E> formatter<E>()
            where E : unmanaged, Enum
                => FieldFormatter<E>.Service;

        /// <summary>
        /// Computes the field width from a specifier
        /// </summary>
        /// <param name="spec">The field specifier</param>
        /// <typeparam name="F">The field specification type</typeparam>
        [MethodImpl(Inline)]
        public static int width<E>(E spec)
            where E : unmanaged, Enum                
                => FieldFormatter<E>.width(spec);

        /// <summary>
        /// Computes a field index from a specifier
        /// </summary>
        /// <param name="spec">The field specifier</param>
        /// <typeparam name="F">The field specification type</typeparam>
        [MethodImpl(Inline)]
        public static int index<E>(E spec)
            where E : unmanaged, Enum                
                => FieldFormatter<E>.index(spec);
    }
}