//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Presents a parametric source to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        /// <summary>
        /// Presents a parametric source reference to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint uint32<T>(ref T src)
            => ref As<T,uint>(ref src);

        /// <summary>
        /// Presents a nullable parametric source to a nullable <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As<T?, uint?>(ref src);
    }
}