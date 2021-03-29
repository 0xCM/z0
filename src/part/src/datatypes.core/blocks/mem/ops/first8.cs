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
        public static ref byte first8(in Block1 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block2 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block4 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block8 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block16 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block32 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block64 src)
            => ref u8(src);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte first8(in Block128 src)
            => ref u8(src);
    }
}