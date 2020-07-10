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
        /// Calculates a hash code for structured content and returns the content along with the calculated hash
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="C">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint bytehash<C>(C src)
            where C : struct
                => hash<byte>(bytes(src));
    }
}