//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    partial class gbits
    {
        /// <summary>
        /// Computes the position of the least set source bit, and is a synonum for ntz
        /// </summary>
        /// <param name="src">The source bit</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static int lsbpos<T>(T src)
            where T : unmanaged
                => ntz(src);
    }
}