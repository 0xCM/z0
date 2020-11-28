//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public partial class Bit
    {
        /// <summary>
        /// Promotes a bit to a numeric value where all target bits are enabled if the state of the
        /// bit is on; otherwise all target bits are disabled
        /// </summary>
        /// <param name="src">The source bit</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline), Op]
        public static T promote<T>(Bit32 src)
            where T : unmanaged
                => src? NumericLiterals.maxval<T>() : default;

        /// <summary>
        /// Promotes a bit to a numeric value where all target bits are enabled if the state of the
        /// bit is on; otherwise all target bits are disabled
        /// </summary>
        /// <param name="src">The source bit</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline), Op]
        public static T promote<T>(bit src)
            where T : unmanaged
                => src? NumericLiterals.maxval<T>() : default;

        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitEdit<T> editor<T>(ref T src)
            where T : unmanaged
                => new BitEdit<T>(ref src);
    }
}