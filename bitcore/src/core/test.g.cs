//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static bit test<T>(T src, int pos)
            where T : unmanaged
                => gbits.testbit(src, (byte)pos);

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static bit test<T>(T src, uint pos)
            where T : unmanaged
                => gbits.testbit(src, (byte)pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static bit test<T>(T src, byte pos)
            where T : unmanaged
                => gbits.testbit(src, pos);

        /// <summary>
        /// Tests a bit value in a T-sequence predicated on a linear index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The linear index of the target bit, relative to the sequence head</param>
        /// <typeparam name="T">The sequence type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static bit test<T>(in Block256<T> src, int index)
            where T : unmanaged
        {
            var loc = bitpos<T>(index);
            return gbits.testbit(src[loc.CellIndex], loc.BitOffset);
        }
    }
}