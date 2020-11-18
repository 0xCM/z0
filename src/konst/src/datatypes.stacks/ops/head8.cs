//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class StackStores
    {
        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock8 src)
            => ref u8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock16 src)
            => ref u8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock32 src)
            => ref u8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock64 src)
            => ref u8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock128 src)
            => ref u8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock256 src)
            => ref head8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock512 src)
            => ref head8(src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref byte head8(in BitBlock1024 src)
            => ref head8(src.X0);
    }
}