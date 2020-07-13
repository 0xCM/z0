//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Converts a <see cref='bool' /> to a <see cref='BitState' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState bitstate(bool src)
            => (BitState) @byte(src);
    }
}