//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class BitFields
    {
        [MethodImpl(Inline)]
        public static BitField256<F,T> create<F,T>(BitFieldSpec256<F> spec, Vector256<T> state)
            where F : unmanaged, Enum
            where T : unmanaged
                => new BitField256<F,T>(spec, state);

        /// <summary>
        /// Creates a stateful bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitField<T> create<T>(in BitFieldSpec spec)
            where T : unmanaged
                => new BitField<T>(spec);

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static BitField<E,T> create<E,T,W>()
            where E : unmanaged, Enum
            where T : unmanaged
            where W : unmanaged, Enum
                => new BitField<E,T>(specify<E,T,W>());

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static BitField<S,E,T> create<S,E,T>(in BitFieldSpec spec)
            where S : IScalarBitField<T>
            where E : unmanaged, Enum
            where T : unmanaged
                => new BitField<S,E,T>(spec);

        internal static FixedBits<T> fixedalloc<T>(uint bitcount)
            where T : unmanaged
                => new FixedBits<T>(BufferBlocks.alloc<T>(n64, BufferBlocks.bitcover<T>(bitcount)), bitcount);

        /// <summary>
        /// Defines and creates a fixed-width bitfield
        /// </summary>
        /// <param name="bitcount">The total field bit-width</param>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W"></typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static FixedBits<E,T,W> create<E,T,W>(uint bitcount)
            where E : unmanaged, Enum
            where T : unmanaged
            where W : unmanaged, Enum
        {
            var data = fixedalloc<T>(bitcount);
            var spec = new BitFieldSpec<E,W>(specify<E,T,W>(), bitcount);
            return new FixedBits<E,T,W>(data, spec);
        }

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static BitField<S,E,T> create<S,E,T,W>()
            where S : IScalarBitField<T>
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => new BitField<S,E,T>(specify<E,T,W>());
    }
}