//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct BitFields
    {
       public static FixedBits<T> fixedbits<T>(uint bitcount)
            where T : unmanaged
                => new FixedBits<T>(SpanBlocks.alloc<T>(n64, SpanBlocks.bitcover<T>(bitcount)), bitcount);

        /// <summary>
        /// Defines and creates a fixed-width bitfield
        /// </summary>
        /// <param name="bitcount">The total field bit-width</param>
        /// <typeparam name="E">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W"></typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        public static FixedBits<E,T,W> fixedbits<E,T,W>(uint bitcount)
            where E : unmanaged, Enum
            where T : unmanaged
            where W : unmanaged, Enum
        {
            var data = fixedbits<T>(bitcount);
            var spec = new BitFieldSpec<E,W>(BitFieldSpecs.define<E,T,W>(), bitcount);
            return new FixedBits<E,T,W>(data, spec);
        }
    }
}