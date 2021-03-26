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

    partial class MemBlocks
    {
        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock1 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock2 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock4 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock8 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock16 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock32 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock64 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in MemBlock128 src)
            => ref u8(src);
    }
}