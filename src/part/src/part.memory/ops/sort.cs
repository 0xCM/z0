//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Produces a sorted <see cref='MemoryAddresses'/> index from a <see cref='MemoryAddress'/> array
        /// </summary>
        /// <param name="src">The source addresses</param>
        [Op]
        public static MemoryAddresses sort(MemoryAddress[] src)
        {
            Array.Sort(src);
            return new MemoryAddresses(src);
        }
    }
}