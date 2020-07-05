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

    partial struct As
    {
        /// <summary>
        /// lea rax,[rcx+n] where n = 1,2,4,8
        /// </summary>
        /// <param name="pSrc"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* inc<T>(T* pSrc)
            where T : unmanaged
                => ++pSrc;

        /// <summary>
        /// For n=1: movsxd rax,edx => add rax,rcx 
        /// For n=2,4,2: lea rax,[rcx+rax*n]
        /// </summary>
        /// <param name="pSrc"></param>
        /// <param name="count"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* add<T>(T* pSrc, int count)
            where T : unmanaged
                =>  pSrc + count; 

        /// <summary>
        /// Increments a reference by a unit
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="count">The cell offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>
        /// For n = 1,2,4,8: lea rax,[rcx+4]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T inc<T>(in T src)
            => ref Add(ref edit(src), 1);                
    }
}