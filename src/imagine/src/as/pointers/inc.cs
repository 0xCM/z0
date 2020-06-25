//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* inc<T>(T* pSrc)
            where T : unmanaged
                => ++pSrc;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* add<T>(T* pSrc, int count)
            where T : unmanaged
                =>  pSrc + count; 
    }
}