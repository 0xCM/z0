//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    using static Classifiers;

    partial class gbits
    {
        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
        /// <param name="index">The sequence-relative index of the target bit</param>
        /// <typeparam name="T">The sequence element type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitPos<T> bitpos<T>(int index)
            where T : unmanaged
                => BitPos.FromBitIndex<T>((uint)index);

        [MethodImpl(Inline)]
        public static BitPos<T> bitpos<T>(int index, PrimalKind<T> k)
            where T : unmanaged
                => bitpos<T>(index);

    }
}