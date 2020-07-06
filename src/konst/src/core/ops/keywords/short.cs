//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Forcefully coerces a <see cref='bool'/> to a <see cref='short'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe short @short(bool src)
            => (*((byte*)(&src))); 


        [MethodImpl(Inline), Op, Closures(Numeric16x32x64k)]
        public static unsafe short @short<T>(T src)
            where T : unmanaged             
                => *((short*)(&src));            
    }
}