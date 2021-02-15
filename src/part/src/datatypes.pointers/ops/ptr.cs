//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Creates a representation over a specified generic pointer
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Ptr<T> ptr<T>(T* pSrc)
            where T : unmanaged
                =>  new Ptr<T>(pSrc);
   }
}