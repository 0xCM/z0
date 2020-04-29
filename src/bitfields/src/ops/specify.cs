//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSpec specify(params FieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, the underlying numeric type of I, T, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="E">The indexing enum type</typeparam>
        /// <typeparam name="T">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<E,T,W>()
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => GetSpec<E,T,W>();

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, with an assumed underlying 
        /// numeric type of byte, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="I">The indexing enum type</typeparam>
        /// <typeparam name="U">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,W>()
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => specify<I,byte,W>();
    }
}
