//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct memory
    {
       /// <summary>
        /// Forcefully coerces a <see cref='bool'/> to a <see cref='short'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe short @short(bool src)
            => (*((byte*)(&src)));

        /// <summary>
        /// Presents generic reference as a <see cref='short'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref short @short<T>(in T src)
            where T : unmanaged
                => ref As<T,short>(ref edit(src));
    }
}