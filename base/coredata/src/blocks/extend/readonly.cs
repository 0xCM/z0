//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BlockExtend    
    {
        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> ReadOnly<T>(this Block32<T> src)
            where T : unmanaged
                => new ConstBlock32<T>(src);

        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> ReadOnly<T>(this Block64<T> src)
            where T : unmanaged
                => new ConstBlock64<T>(src);

        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> ReadOnly<T>(this Block128<T> src)
            where T : unmanaged
                => new ConstBlock128<T>(src);

        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> ReadOnly<T>(this Block256<T> src)
            where T : unmanaged
                => new ConstBlock256<T>(src);
    }
}