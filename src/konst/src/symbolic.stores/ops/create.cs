//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct SymbolStores
    {
        /// <summary>
        /// Defines a sequence of symbols predicated on parametric arguments
        /// </summary>
        /// <typeparam name="E">An enum type</typeparam>
        /// <typeparam name="T">The type of the enum's underlying primitive</typeparam>
        /// <typeparam name="N">The number of bits required to store each element</typeparam>
        public static SymbolStore<E,T,N> create<E,T,N>()
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => create<E,T,N>(Enums.literals<E>());

        [MethodImpl(Inline)]
        public static SymbolStore<E,T,N> create<E,T,N>(E[] src)
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new SymbolStore<E,T,N>(src.Map(e => symbol<E,T,N>(e)));

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static SymbolStore<E,T> create<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => create<E,T>(Enums.literals<E>());

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static SymbolStore<E,T> create<E,T>(E[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new SymbolStore<E,T>(src.Map(x => symbol<E,T>(x)));

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static SymbolStore<E> create<E>()
            where E : unmanaged, Enum
                => create<E>(Enums.literals<E>());

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<E> create<E>(E[] src)
            where E : unmanaged
                => new SymbolStore<E>(src.Map(x => symbol<E>(x)));
    }
}