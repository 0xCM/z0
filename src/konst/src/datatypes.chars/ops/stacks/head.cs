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
    using static MemoryStacks;

    partial struct CharStacks
    {
        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack4 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack8 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack16 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack32 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack64 src)
            => ref c16(src);
    }
}