//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsDeprecated
    {
        /// <summary>
        /// Converts a <see cref='bool'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte @byte(bool src)
            => (*((byte*)(&src)));
    }
}