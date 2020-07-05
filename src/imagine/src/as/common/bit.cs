//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Converts a <see cref='bool' /> to a <see cref='Bit' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe Bit bit(bool src)
            => (Bit) @byte(src);

        [MethodImpl(Inline), TestBit]
        public static unsafe bool @bool(Bit src)
        {
            var dst = false;
            var pSrc = (byte*)&src;
            var pDst = (byte*)&dst;
            *pDst = *pSrc;
            return dst;
        }
    }
}