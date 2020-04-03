//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack4 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack8 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack16 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack32 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref readonly char first(in CharStack64 src)
            => ref first(in src.C0);
    }
}