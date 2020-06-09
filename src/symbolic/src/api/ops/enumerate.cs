//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Seed;

    partial class Symbolic     
    {
        /// <summary>
        /// Defines a useful representation of an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type refined by the enum</typeparam>
        /// <typeparam name="A">The asci identifier type</typeparam>
        [MethodImpl(Inline)]
        public static @enum<E,T> @enum<E,T>(int index, string identifier, E literal, T scalar)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(index, identifier, literal, scalar);

        /// <summary>
        /// Defines a symbol spec predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static Symbols<E,T,N> enumerate<E,T,N>(int crop = 0)
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbols<E,T,N>(literals<E>(crop).Map(x => define<E,T,N>(x)));

        /// <summary>
        /// Defines a symbol spec predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static Symbols<E,T> enumerate<E,T>(int crop = 0)
            where E : unmanaged, Enum
            where T : unmanaged
                => new Symbols<E,T>(literals<E>(crop).Map(x => define<E,T>(x)));

        /// <summary>
        /// Defines a symbol spec predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static Symbols<E> enumerate<E>(int crop = 0)
            where E : unmanaged, Enum
                => new Symbols<E>(literals<E>(crop).Map(x => define<E>(x)));

        static ReadOnlySpan<E> literals<E>(int crop = 0)
            where E : unmanaged, Enum
        {
            ReadOnlySpan<E> literals = Enums.valarray<E>();
            var count = literals.Length - crop;
            return literals.Slice(0,count);            
        }
    }
}