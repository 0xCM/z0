//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Forcefully coerces a <see cref='bool'/> to a <see cref='sbyte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe sbyte @sbyte(bool src)
            => (*((sbyte*)(&src)));

        /// <summary>
        /// Presents generic reference as a <see cref='sbyte'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref sbyte @sbyte<T>(in T src)
            where T : unmanaged
                => ref As<T,sbyte>(ref edit(src));
    }
}