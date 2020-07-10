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
        /// Forcefully coerces a <see cref='bool'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte @byte(bool src)
            => (*((byte*)(&src))); 

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe byte @byte<T>(T src)
            where T : unmanaged             
                => *((byte*)(&src));
    }
}