//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack8 src)
            => ref As.uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack16 src)
            => ref As.uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack32 src)
            => ref As.uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack64 src)
            => ref As.uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack128 src)
            => ref As.uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack256 src)
            => ref head8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack512 src)
            => ref head8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(ref MemStack1024 src)
            => ref head8(ref src.X0);
    }
}