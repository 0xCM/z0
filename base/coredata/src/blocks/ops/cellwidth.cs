//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : unmanaged        
                => Unsafe.SizeOf<T>();

        /// <summary>
        /// The bit width of a cell
        /// </summary>
        [MethodImpl(Inline)]
        public static int cellwidth<T>() 
            where T : unmanaged
                => Unsafe.SizeOf<T>() * 8;
    }
}