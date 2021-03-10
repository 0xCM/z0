//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct BitFields
    {
        [MethodImpl(Inline)]
        public static BitField64<E> create<E>(W64 w, E state)
            where E : unmanaged
                => new BitField64<E>(state);

        [MethodImpl(Inline)]
        public static BitField256<E,T> create<E,T>(Vector256<T> state)
            where E : unmanaged, Enum
            where T : unmanaged
                => new BitField256<E,T>(specify<E>(w256), state);

        /// <summary>
        /// Creates a stateful bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitField<T> create<T>(in BitFieldSpec spec, T state = default)
            where T : unmanaged
                => new BitField<T>(spec, state);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static BitField<E,T> create<E,T,W>(T state = default)
            where E : unmanaged, Enum
            where T : unmanaged
            where W : unmanaged, Enum
                => new BitField<E,T>(specify<E,T,W>(), state);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static BitField<S,E,T> create<S,E,T>(in BitFieldSpec spec, T state = default)
            where S : INumericBits<T>
            where E : unmanaged, Enum
            where T : unmanaged
                => new BitField<S,E,T>(spec, state);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static BitField<S,E,T> create<S,E,T,W>(T state = default)
            where S : INumericBits<T>
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => new BitField<S,E,T>(specify<E,T,W>(), state);
    }
}