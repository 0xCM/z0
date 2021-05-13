//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Interprets a readonly T-reference as a readonly int32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly int view32i<T>(in T src)
            => ref view<T,int>(src);

        /// <summary>
        /// Interprets a readonly T-reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint view32u<T>(in T src)
            => ref view<T,uint>(src);

        /// <summary>
        /// Interprets a readonly T-reference as a readonly float64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly float view32f<T>(in T src)
             => ref view<T,float>(src);
    }
}