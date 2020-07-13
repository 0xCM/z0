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
        /// Converts a <see cref='bool' /> to a <see cref='BitState' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState bitstate(bool src)
            => (BitState) @byte(src);

        [MethodImpl(Inline), TestBit]
        public static unsafe bool @bool(BitState src)
        {
            var dst = false;
            var pSrc = (byte*)&src;
            var pDst = (byte*)&dst;
            *pDst = *pSrc;
            return dst;
        }
    }
}