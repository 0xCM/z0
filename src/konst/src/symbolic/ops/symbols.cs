//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Symbolic
    {
        /// <summary>
        /// Defines a sequence of symbols predicated on parametric arguments
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static SymbolStore<E,T,N> symbols<E,T,N>()
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new SymbolStore<E,T,N>(Enums.literals<E>().Map(x => symbol<E,T,N>(x)));

        /// <summary>
        /// Defines a symbol spec predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static SymbolStore<E,T> symbols<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => new SymbolStore<E,T>(Enums.literals<E>().Map(x => symbol<E,T>(x)));

        /// <summary>
        /// Defines a symbol spec predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static SymbolStore<E> symbols<E>()
            where E : unmanaged, Enum
                => new SymbolStore<E>(Enums.literals<E>().Map(x => symbol<E>(x)));
    }
}