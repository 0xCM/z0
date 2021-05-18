//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Typed;

    partial struct BitFields
    {
        [MethodImpl(Inline)]
        public static Bitfield64<E> create<E>(W64 w, E state)
            where E : unmanaged
                => new Bitfield64<E>(state);

        [MethodImpl(Inline)]
        public static Bitfield256<E,T> create<E,T>(Vector256<T> state)
            where E : unmanaged, Enum
            where T : unmanaged
                => new Bitfield256<E,T>(widths<E>(w256), state);

        [MethodImpl(Inline)]
        public static Bitfield256<E,T> create<E,T>(Vector256<byte> widths, Vector256<T> state)
            where E : unmanaged
            where T : unmanaged
                => new Bitfield256<E,T>(widths, state);

        /// <summary>
        /// Creates a stateful bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitfieldCover<T> create<T>(in BitfieldSegSpecs spec, T state = default)
            where T : unmanaged
                => new BitfieldCover<T>(spec, state);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static BitfieldCover<S,E,T> create<S,E,T>(in BitfieldSegSpecs spec, T state = default)
            where S : unmanaged
            where E : unmanaged, Enum
            where T : unmanaged
                => new BitfieldCover<S,E,T>(spec, state);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static BitfieldCover<S,E,T> create<S,E,T,W>(T state = default)
            where S : unmanaged
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => new BitfieldCover<S,E,T>(BitfieldSpecs.specify<E,T,W>(), state);
    }
}